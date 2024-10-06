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

namespace SerialConsole // Terminal
{
    public partial class SerialConsoleForm : Form
    {
        static SerialPort _serialPort;

        int _formatIndex = 0;

        static string _history_fileName = "history.txt";
        List<string> history = new List<string>();
        int historyIndex = 0;

        byte[] dataBuffer = new byte[1024];

        StringBuilder sb = new StringBuilder();

        /*
        Add CR+LF
        Add CR 0D
        Add LF 0A
        No Line Ending  
        */
        readonly string[] LE = new string[3] { "\r\n", "\n", "" };
        readonly List<char> hexChars = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};


        public SerialConsoleForm()
        {
            Console.WriteLine("ctor");
            InitializeComponent();
            _serialPort = new SerialPort();
            _serialPort.DataReceived += onDataReceived;
            _serialPort.ErrorReceived += onErrorReceived;

            ExtLog.bx = textBox_output;

            comboBox_Format.SelectedIndex = 0;
            comboBox_LE.SelectedIndex = 0;

            try
            {
                comboBox_portName.Text = Properties.Settings.Default.lastPortName;
                comboBox_portSpeed.Text = Properties.Settings.Default.lastPortSpeed;
                comboBox_Format.SelectedIndex = Properties.Settings.Default.lastFormat;
                comboBox_LE.SelectedIndex = Properties.Settings.Default.lastLE;

                if (comboBox_portSpeed.Items.Contains(comboBox_portSpeed.Text)) comboBox_portSpeed.SelectedItem = comboBox_portSpeed.Text;
            }
            catch
            {
                ExtLog.AddLine("Error reading Settings");
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("load");
            button_list_Click(sender, e);

            if (!File.Exists(_history_fileName)) return;

            var f = File.OpenText(_history_fileName);
            while (!f.EndOfStream) history.Add(f.ReadLine());
            f.Close();
            historyIndex = history.Count;
        }

        private void onErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            ExtLog.AddLine("Error: " + e.EventType.ToString());
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
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;
            } catch (Exception ex)
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

        private void onDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (checkBox_pause.Checked)
            {
                _serialPort.DiscardInBuffer();
                return;
            }

            if (_formatIndex == 0)  // text only
            {
                ExtLog.terminateLineIfNecessary();
                string inText;
                try
                {
                    inText = _serialPort.ReadLine();
                } catch
                {
                    inText = _serialPort.ReadExisting() + " *\r\n";
                }
                ExtLog.Add(ts() + "" + inText);
                return;
            }
            else
            {
                sb.Clear();
                sb.Append(ts());
                var toRead = _serialPort.BytesToRead;
                while (toRead > 0)
                {
                    if (toRead > 8) toRead = 8;
                    toRead = _serialPort.Read(dataBuffer, 0, toRead);

                    var binStr = "";
                    var hexStr = "";
                    var txtStr = "";
                    for (var i = 0; i < toRead; ++i)
                    {
                        binStr += byteToBin(dataBuffer[i]);
                        hexStr += byteToHex(dataBuffer[i]);
                        txtStr += safeCharConvert(dataBuffer[i]);
                        if (i != 3)
                        {
                            binStr += " ";
                            hexStr += " ";
                        }
                        else
                        {
                            binStr += "  ";
                            hexStr += "  ";
                            txtStr += " ";
                        }
                    }

                    for (var i = toRead; i < 8; ++i)
                    {
                        binStr += "________";
                        hexStr += "__";
                        txtStr += " ";
                        if (i != 3)
                        {
                            binStr += " ";
                            hexStr += " ";
                        }
                        else
                        {
                            binStr += "  ";
                            hexStr += "  ";
                            txtStr += " ";
                        }
                    }

                    /*  comboBox_Format
                       0 Text Only
                       1 Hex + Text
                       2 Binary + Hex
                       3 Binary + Text
                       4 Binary + Hex + Text
                    */
                    if (_formatIndex >= 2)
                    {
                        sb.Append(binStr + " ");
                    }

                    if (_formatIndex != 3)
                    {
                        sb.Append(hexStr + " ");
                    }

                    if (_formatIndex != 2)
                    {
                        sb.Append(txtStr);
                    }

                    sb.AppendLine();

                    toRead = _serialPort.BytesToRead;
                }

                ExtLog.Add(sb.ToString());
            }

            // numData format 

            /* var dataLen = _serialPort.BytesToRead;
                 for (var i = 0; i < dataLen; ++i)
                 {
                     if (numData >= 8)
                     {
                         ExtLog.AddLine(textBox_input.Text);
                         textBox2Clear();
                         numData = 0;
                     }
                     var newDataInt = _serialPort.ReadByte();
                     if (newDataInt == -1) break;

                     bData[numData] = (byte)newDataInt;
                     if (!checkBox_pause.Checked) textBox2Text(formatData(bData, numData));

                     numData++;
                 }
            */
        }

        private static string byteToHex(byte b)
        {
            return Convert.ToString(b, 16).PadLeft(2, '0').ToUpperInvariant();
        }
        private static byte hexToByte(string h)
        {
            return Convert.ToByte(h, 16);
        }
        private static string byteToBin(byte b)
        {
            return Convert.ToString(b, 2).PadLeft(8, '0');
        }
        private string safeCharConvert(byte b)
        {
            if ((b < 32) || (b >= 127)) return ".";
            return "" + Convert.ToChar(b);
        }

        private string ts()
        {
            return checkBox_timeStamps.Checked ? DateTime.Now.ToString("HH:mm:ss.ff ") : "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.DiscardOutBuffer();
                _serialPort.DiscardInBuffer();
                Invoke(new void_voidDelegate(_serialPort.Close), null);
            }
            try
            {
                Properties.Settings.Default.lastPortName = comboBox_portName.Text;
                Properties.Settings.Default.lastPortSpeed = comboBox_portSpeed.Text;

                Properties.Settings.Default.lastLE = comboBox_LE.SelectedIndex;
                Properties.Settings.Default.lastFormat = comboBox_Format.SelectedIndex;

                Properties.Settings.Default.Save();

                if (history.Count != 0)
                {
                    if (history.Count > 512) history.RemoveRange(0, history.Count - 512);

                    var f = File.CreateText(_history_fileName);
                    history.ForEach(s => f.WriteLine(s));
                    f.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error saving Settings");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_output.Clear();
        }


        private void textBox_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button_send_Click(sender, null);

            if (e.KeyCode == Keys.Up)
            {
                historyIndex--;
                if ((historyIndex >= 0) && (historyIndex < history.Count))
                {
                    textBox_input.Text = history[historyIndex];
                    textBox_input.SelectionStart = textBox_input.Text.Length;
                    textBox_input.SelectionLength = 0;
                }
                else
                {
                    historyIndex = 0;
                }

                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                historyIndex++;
                if (historyIndex < history.Count)
                {
                    textBox_input.Text = history[historyIndex];
                    textBox_input.SelectionStart = textBox_input.Text.Length;
                    textBox_input.SelectionLength = 0;
                }
                else
                {
                    textBox_input.Text = "";
                    historyIndex = history.Count;
                }

                e.SuppressKeyPress = true;
            }
        }


        private void button_send_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;

            if (comboBox_inputType.SelectedIndex == 0)
            {
                _serialPort.Write(textBox_input.Text + LE[comboBox_LE.SelectedIndex]);
            } 
            else
            {
                var c = textBox_input.Text.ToUpperInvariant().Where(v => hexChars.Contains(v));
                string s = string.Concat(c);
                if ((s.Length % 2) != 0) s += "0";
                for (var i = 0; i < s.Length; i += 2) dataBuffer[i / 2] = hexToByte(s.Substring(i, 2));

                _serialPort.Write(dataBuffer, 0, s.Length / 2);
            }
            ExtLog.terminateLineIfNecessary();
            ExtLog.AddLine(ts() + "> " + textBox_input.Text);
            if ((textBox_input.Text.Trim() != "") && (textBox_input.Text != safeLastHistory())) history.Add(textBox_input.Text);
            historyIndex = history.Count;
            textBox_input.Clear();
        }

        private string safeLastHistory()
        {
            if (history.Count == 0) return "";
            return history.Last();
        }

        private void comboBox_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            _formatIndex = comboBox_Format.SelectedIndex;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            Invoke(new void_voidDelegate(_serialPort.Close), null);
            ExtLog.AddLine("Port Closed");
        }

        private void checkBox_CTS_CheckedChanged(object sender, EventArgs e)
        {
            _serialPort.Handshake = checkBox_CTS.Checked ? Handshake.RequestToSend : Handshake.None;
        }

        private void button_sendBIN_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            openFileDialog1.FileName = "*.bin";
            openFileDialog1.Filter = "Binary|*.bin|All Files|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            var f = File.OpenRead(openFileDialog1.FileName);
            ExtLog.AddLine("Reading file " + openFileDialog1.FileName);
            var b = new byte[1];
            var data = f.ReadByte();
            var i = 0;
            //var mdelay = 32;
            //var tdealy = 200;

            while ((data != -1) & (_serialPort.BytesToWrite < 128)) { 

               // while (_serialPort.CtsHolding == false) { };
                b[0] = (byte)data;
                _serialPort.Write(b, 0, 1);
                data = f.ReadByte();
                i++;
            //    if ((i % mdelay) == 0) Thread.Sleep(tdealy);
            }
            ExtLog.AddLine("Sent " + i + " bytes");
            f.Close();
        }
    }

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
}
