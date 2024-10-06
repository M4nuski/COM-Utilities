using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace Benchmark
{
    public partial class BenckmarkForm : Form
    {
        static SerialPort _serialPort;
        byte[] dataInBuffer = new byte[1024 * 64];
        byte[] dataOutBuffer = new byte[1024 * 64];
        StringBuilder sb = new StringBuilder();
        private int totalreceived;
        private int totalsent;
        private int packetLength = 256;
        private List<int> chunkLength = new List<int>();
        private long startTicks;
        private List<long> chunkTicks = new List<long>();
        private int duration = 10;

        private enum stateType
        {
            Idle,
            Input,
            Loopback
        }
        private stateType state = stateType.Idle;

        public BenckmarkForm()
        {
            InitializeComponent();
            _serialPort = new SerialPort();
            _serialPort.DataReceived += onDataReceived;
            _serialPort.ErrorReceived += onErrorReceived;

            ExtLog.bx = textBox_output;

        }
        private void button_close_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            Invoke(new void_voidDelegate(_serialPort.Close), null);
            ExtLog.AddLine("Port Closed");
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            comboBox_portName.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox_portName.Items.Add(s);
                if (comboBox_portName.Items.Contains(comboBox_portName.Text)) comboBox_portName.SelectedItem = comboBox_portName.Text;
            }

            if (comboBox_portName.Items.Count == 0) comboBox_portName.Text = "";
            if (comboBox_portName.Items.Count == 1) comboBox_portName.SelectedIndex = 0;
        }

        private void onErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            ExtLog.AddLine("Error: " + e.EventType.ToString());
        }

        private void onDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (state == stateType.Idle)
            {
                _serialPort.DiscardInBuffer();
                return;
            }

            var nAvail = _serialPort.BytesToRead;
            var nRead = _serialPort.Read(dataInBuffer, 0, nAvail);
            totalreceived += nRead;
            chunkLength.Add(nRead);
            chunkTicks.Add(DateTime.Now.Ticks);

            ExtLog.AddLine($"nAvail: {nAvail}, nRead: {nRead}");

         //   _serialPort.Write(dataOutBuffer, 0, nRead);
         //   totalsent += packetLength;
        }

        // 1 886 6960 4021 poste 79971
            #region extlog
        delegate void void_stringDelegate(string text);
        delegate void void_voidDelegate();
        public static class ExtLog
        {

            public static TextBox bx;
            public static void AddLine(string s)
            {
                if (bx != null)
                {
                    if (bx.InvokeRequired)
                    {
                        bx.Invoke((void_stringDelegate)AddLine, new object[] { s });
                    }
                    else bx.AppendText(s + "\r\n");
                }
            }

            public static void terminateLineIfNecessary()
            {
                if (bx != null)
                {
                    if (bx.InvokeRequired)
                    {
                        bx.Invoke((void_voidDelegate)terminateLineIfNecessary);
                    }
                    else
                    {
                        if (bx.Text.Length == 0) return;
                        if (!bx.Text.EndsWith("\r\n")) bx.AppendText("\r\n");
                    }
                }
            }

            public static void UpdateLine(string s)
            {
                if (bx != null)
                {
                    if (bx.InvokeRequired)
                    {
                        bx.Invoke((void_stringDelegate)UpdateLine, new object[] { s });
                    }
                    else
                    {
                        bx.Lines[bx.Lines.Count() - 1] = s;
                    }
                }
            }

            public static void NewLine()
            {
                if (bx != null)
                {
                    if (bx.InvokeRequired)
                    {
                        bx.Invoke((void_voidDelegate)NewLine);
                    }
                    else
                    {
                        bx.Lines[bx.Lines.Count() - 1] += "\r\n";
                    }
                }
            }


            public static void Add(string s)
            {
                if (bx != null)
                {
                    if (bx.InvokeRequired)
                    {
                        bx.Invoke((void_stringDelegate)Add, new object[] { s });
                    }
                    else bx.AppendText(s);
                }
            }

            public static void Clear()
            {
                if (bx != null)
                {
                    if (bx.InvokeRequired)
                    {
                        bx.Invoke((void_voidDelegate)Clear);
                    }
                    else bx.Clear();
                }
            }

        }
        #endregion

        private void BenckmarkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.DiscardOutBuffer();
                _serialPort.DiscardInBuffer();
                Invoke(new void_voidDelegate(_serialPort.Close), null);
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen) button_close_Click(sender, e);

            try
            {
                _serialPort.PortName = comboBox_portName.Text;
                _serialPort.BaudRate = int.Parse(comboBox_portSpeed.Text);
                _serialPort.Parity = Parity.None;
                _serialPort.DataBits = 8;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Handshake = Handshake.None;

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 2500;
                _serialPort.WriteTimeout = 2500;
            }
            catch (Exception ex)
            {
                ExtLog.AddLine("Error setting up serial port: " + ex.Message);
                return;
            }

            try
            {
                _serialPort.Open();
                var cnt = 25;
                while (!_serialPort.IsOpen && (cnt-- > 0)) Thread.Sleep(200);
                if (cnt > 0)
                {
                    ExtLog.AddLine("Session Started: " + DateTime.Now.ToString("yyyy-MM-dd"));
                    ExtLog.AddLine(_serialPort.PortName + "@" + _serialPort.BaudRate);
                }
                else
                {
                    ExtLog.AddLine("Failed to open port");
                    button_close_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                ExtLog.AddLine("Error opening serial port: " + ex.Message);
            }


        }

        private void BenckmarkForm_Load(object sender, EventArgs e)
        {
            packetSize_comboBox.SelectedIndex = 0;
            button_list_Click(null, null);
            for (var i = 0; i < dataOutBuffer.Length; ++i) dataOutBuffer[i] = (byte)(i % 256);
        }

        private void bench_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loopBack_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ExtLog.AddLine(totalreceived.ToString());

            if ((DateTime.Now.Ticks - startTicks) > (duration*1000*10000))
            {
                state = stateType.Idle;
                timer1.Enabled = false;
                ExtLog.AddLine("Time duration reached");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int.TryParse(textBox1.Text, out duration);
            textBox1.Text = duration.ToString();
        }

        private void inputrate_button_Click(object sender, EventArgs e)
        {
            if (state != stateType.Idle) return;
            if (!_serialPort.IsOpen) return;

            chunkLength.Clear();
            chunkTicks.Clear();
            startTicks = DateTime.Now.Ticks;
            totalreceived = 0;
            timer1.Enabled = true;
            _serialPort.DiscardInBuffer();

            state = stateType.Input;
        }

        private void loopback_button_Click(object sender, EventArgs e)
        {
            if (state != stateType.Idle) return;
            if (!_serialPort.IsOpen) return;

            chunkLength.Clear();
            chunkTicks.Clear();
            startTicks = DateTime.Now.Ticks;
            totalreceived = 0;
            timer1.Enabled = true;
            _serialPort.DiscardInBuffer();

            _serialPort.Write(dataOutBuffer, 0, 1);
            totalsent = packetLength;
            state = stateType.Loopback;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (state == stateType.Idle) return;

            state = stateType.Idle;
            chunkLength.Clear();
            chunkTicks.Clear();
            totalreceived = 0;
            timer1.Enabled = false;

            ExtLog.AddLine("Cancelled benchmark");
        }

        private void packetSize_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            packetLength = int.Parse(packetSize_comboBox.Text);
        }
    }
}
