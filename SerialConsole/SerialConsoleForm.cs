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
using System.Net.Http;
using System.Xml.Linq;

namespace SerialConsole // Terminal
{
    public partial class SerialConsoleForm : Form
    {
        static SerialPort _serialPort;

        int _formatIndex = 0;
        bool stopSend = false;
        List<byte> sendPattern = new List<byte>();
        List<byte> receivePattern = new List<byte>();
        List<byte> receiveMatchBuffer = new List<byte>();
        List<byte> headerPattern = new List<byte>();
        List<byte> footerPattern = new List<byte>();

        static string _history_fileName = "history.txt";
        List<string> history = new List<string>();
        int historyIndex = 0;
        string lastFileName = "";

        bool capturing = false;
        FileStream captureFile;

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
              
                timeout_textBox.Text = Properties.Settings.Default.timeout.ToString("D");
                comboBox_bitLength.SelectedIndex = Properties.Settings.Default.bitLength;
                comboBox_handshake.SelectedIndex = Properties.Settings.Default.handshake;
                comboBox_parity.SelectedIndex = Properties.Settings.Default.parity;
                comboBox_stopBits.SelectedIndex = Properties.Settings.Default.stopBits;

                textBox_sendPattern.Text = Properties.Settings.Default.pattern;
                textBox_receivePattern.Text = Properties.Settings.Default.patternReply;
                textBox_patternDelay.Text = Properties.Settings.Default.patternDelay.ToString("D");
                comboBox_pattern.SelectedIndex = Properties.Settings.Default.patternMode;

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
            if (checkBox_sendPattern.Checked) checkBox_sendPattern.Checked = false;
            stopSend = true;
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

                switch (comboBox_bitLength.SelectedIndex)
                {
                    case 0:
                        _serialPort.DataBits = 7;
                        break;
                    case 1:
                        _serialPort.DataBits = 8;
                        break;
                }

                switch (comboBox_handshake.SelectedIndex)
                {
                    case 0:
                        _serialPort.Handshake = Handshake.None;
                        break;
                    case 1:
                        _serialPort.Handshake = Handshake.RequestToSend;
                        break;
                    case 2:
                        _serialPort.Handshake = Handshake.XOnXOff;
                        break;
                    case 3:
                        _serialPort.Handshake = Handshake.RequestToSendXOnXOff;
                        break;
                }

                switch (comboBox_parity.SelectedIndex)
                {
                    case 0:
                        _serialPort.Parity = Parity.None;
                        break;
                    case 1:
                        _serialPort.Parity = Parity.Odd;
                        break;
                    case 2:
                        _serialPort.Parity = Parity.Even;
                        break;
                    case 3:
                        _serialPort.Parity = Parity.Mark;
                        break;
                    case 4:
                        _serialPort.Parity = Parity.Space;
                        break;
                }

                switch (comboBox_stopBits.SelectedIndex)
                {
                    case 0:
                        _serialPort.StopBits = StopBits.None;
                        break;
                    case 1:
                        _serialPort.StopBits = StopBits.One;
                        break;
                    case 2:
                        _serialPort.StopBits = StopBits.OnePointFive;
                        break;
                    case 3:
                        _serialPort.StopBits = StopBits.Two;
                        break;
                }

                // Set the read/write timeouts
                int timeout;
                try
                {
                    timeout = int.Parse(timeout_textBox.Text);
                    if (timeout < 0) timeout = 1;
                } catch
                {
                    ExtLog.AddLine("Invalid timeout value");
                    timeout = 500;
                    timeout_textBox.Text = "500";
                }
                _serialPort.ReadTimeout = timeout;
                _serialPort.WriteTimeout = timeout;
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

           // var d = _serialPort.
           // load serial data
           // check for reply mode
           // convert to text or raw data



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
                if (capturing && (captureFile != null))
                {
                    var sb = Encoding.ASCII.GetBytes(inText);
                    captureFile.Write(sb, 0, sb.Length);
                    updateCapturedLabel(captureFile.Length.ToString());
                }
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
                    if (capturing && (captureFile != null))
                    {
                        captureFile.Write(dataBuffer, 0, toRead);
                        updateCapturedLabel(captureFile.Length.ToString());
                    }

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
            if (captureFile != null) try
                {
                    captureFile.Close();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
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

                Properties.Settings.Default.timeout = int.Parse(timeout_textBox.Text);
                Properties.Settings.Default.bitLength = comboBox_bitLength.SelectedIndex;
                Properties.Settings.Default.handshake = comboBox_handshake.SelectedIndex;
                Properties.Settings.Default.parity = comboBox_parity.SelectedIndex;                
                Properties.Settings.Default.stopBits = comboBox_stopBits.SelectedIndex;

                Properties.Settings.Default.pattern = textBox_sendPattern.Text;
                Properties.Settings.Default.patternReply = textBox_receivePattern.Text;
                Properties.Settings.Default.patternDelay = int.Parse(textBox_patternDelay.Text);
                Properties.Settings.Default.patternMode = comboBox_pattern.SelectedIndex;

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

        private void button_sendBIN_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            openFileDialog1.FileName = "*.*";
            openFileDialog1.Filter = "Binary|*.bin|All Files|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            label_sent.Text = "0/0";
            try
            {
                var f = File.OpenRead(openFileDialog1.FileName);
                ExtLog.AddLine("Reading file " + openFileDialog1.FileName);
                stopSend = false;
                lastFileName = openFileDialog1.FileName;
                sendBIN(f);
                f.Close();
            } catch (Exception ex)
            {
                ExtLog.AddLine(ex.Message);
                return;
            }
        }

        private void sendBIN(FileStream f)
        {

            int chunkSize;
            try
            {
                chunkSize = int.Parse(SendBinChunk_textBox.Text);
            }
            catch
            {
                ExtLog.AddLine("Invalid chunk size value");
                chunkSize = 256;
                SendBinChunk_textBox.Text = "256";
            }
            if (chunkSize < 0)
            {
                chunkSize = 1;
                SendBinChunk_textBox.Text = "1";
            }

            if (chunkSize > _serialPort.WriteBufferSize) chunkSize = _serialPort.WriteBufferSize;

            int chunkDelay;
            try
            {
                chunkDelay = int.Parse(SendBinPause_textBox.Text);
            }
            catch
            {
                ExtLog.AddLine("Invalid chunk delay value");
                chunkDelay = 0;
                SendBinPause_textBox.Text = "0";
            }
            if (chunkDelay < 0)
            {
                chunkDelay = 0;
                SendBinPause_textBox.Text = "0";
            }

            var totalSent = 0;

            if (checkBox_sendHDR.Checked) {
                try
                {
                    var hData = textBoxToByteList(textBox_HDR).ToArray();
                    _serialPort.Write(hData, 0, hData.Length);
                    totalSent += hData.Length;
                    ExtLog.AddLine(ts() + "-> Header " + textBox_HDR.Text);
                }
                catch (Exception ex)
                {
                    ExtLog.AddLine(ts() + " " + ex.Message);
                }
            }

            var data = new byte[chunkSize];
            var dataLength = f.Read(data, 0, chunkSize);

            if ((1000 * chunkSize / (_serialPort.BaudRate / 10)) > _serialPort.WriteTimeout) ExtLog.AddLine("**** Chunk size might be too high for baudrate/timeout ****");


            while ((dataLength > 0) && !stopSend)
            {
                try
                {
                    _serialPort.Write(data, 0, dataLength);
                    totalSent += dataLength;
                    ExtLog.AddLine(ts() + "-> " + dataLength.ToString("D"));                    
                }
                catch (Exception ex)
                {
                    ExtLog.AddLine(ts() + " " + ex.Message);
                }
                label_sent.Text = $"{totalSent}/{f.Length}";
                if (chunkDelay != 0) Thread.Sleep(chunkDelay);
                Application.DoEvents();
                this.Refresh();
  
                dataLength = f.Read(data, 0, chunkSize);
            }

            if (checkBox_sendFTR.Checked)
            {
                try
                {
                    var fData = textBoxToByteList(textBox_FTR).ToArray();
                    _serialPort.Write(fData, 0, fData.Length);
                    totalSent += fData.Length;
                    ExtLog.AddLine(ts() + "-> Footer " + textBox_FTR.Text);
                }
                catch (Exception ex)
                {
                    ExtLog.AddLine(ts() + " " + ex.Message);
                }
            }

            ExtLog.AddLine($"Sent {totalSent}/{f.Length} bytes");
            
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            stopSend = true;
        }

        public List<byte> textBoxToByteList(TextBox tb)
        {
            var c = tb.Text.ToUpperInvariant().Where(v => hexChars.Contains(v));
            string s = string.Concat(c);
            if ((s.Length % 2) != 0) s += "0";
            var result = new List<byte>();
            for (var i = 0; i < s.Length; i += 2) result.Add(hexToByte(s.Substring(i, 2)));
            return result;

        }

        private void checkBox_sendPattern_CheckedChanged(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;

            if (checkBox_sendPattern.Checked)
            {
                sendPattern.Clear();
                receivePattern.Clear();
                receiveMatchBuffer.Clear();

                var patternDelay = int.Parse(textBox_patternDelay.Text);
                if (patternDelay < 0) patternDelay = 0;

                //var c = textBox_sendPattern.Text.ToUpperInvariant().Where(v => hexChars.Contains(v));
                //string s = string.Concat(c);
                //if ((s.Length % 2) != 0) s += "0";
                //for (var i = 0; i < s.Length; i += 2) sendPattern.Add(hexToByte(s.Substring(i, 2)));
                sendPattern = textBoxToByteList(textBox_sendPattern);

                //c = textBox_receivePattern.Text.ToUpperInvariant().Where(v => hexChars.Contains(v));
                //s = string.Concat(c);
                //if ((s.Length % 2) != 0) s += "0";
                //for (var i = 0; i < s.Length; i += 2) receivePattern.Add(hexToByte(s.Substring(i, 2)));
                receivePattern = textBoxToByteList(textBox_receivePattern);

                if (comboBox_pattern.SelectedIndex == 0)
                {
                    try { 
                        _serialPort.Write(sendPattern.ToArray(), 0, sendPattern.Count);
                        ExtLog.AddLine(ts() + " " + textBox_sendPattern.Text);
                    } catch (Exception ex)
                    {
                        ExtLog.AddLine(ts() + " " + ex.Message);
                    }
                checkBox_sendPattern.Checked = false;
                } else if (comboBox_pattern.SelectedIndex == 1)
                {
                    while (checkBox_sendPattern.Checked && _serialPort.IsOpen)
                    {
                        try { 
                            _serialPort.Write(sendPattern.ToArray(), 0, sendPattern.Count);
                            ExtLog.AddLine(ts() + " " + textBox_sendPattern.Text);
                        } catch (Exception ex)
                        {
                            ExtLog.AddLine(ts() + " " + ex.Message);
                            checkBox_sendPattern.Checked = false;
                        }
                    if (patternDelay != 0) Thread.Sleep(patternDelay);
                        Application.DoEvents();
                        this.Refresh();
                    }
                }
            } else
            {
                // not checked
            }
        }

        private void button_Resend_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            if (lastFileName == "") return;

            try
            {
                var f = File.OpenRead(lastFileName);
                ExtLog.AddLine("Reading file " + lastFileName);
                stopSend = false;
                sendBIN(f);
                f.Close();
            }
            catch (Exception ex)
            {
                ExtLog.AddLine(ex.Message);
                return;
            }
        }

        private void button_capture_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                if (captureFile != null)
                {
                    captureFile.Close();
                    captureFile = null;
                }
                captureFile = File.OpenWrite(saveFileDialog1.FileName);
                capturing = true;
                ExtLog.AddLine("Capture Started in " + saveFileDialog1.FileName);
                label_received.Text = "0";
            } catch (Exception ex) {
                ExtLog.AddLine(ex.Message);
                capturing = false;
                if (captureFile != null) {
                    captureFile.Close();
                    captureFile = null;
                }
            }

        }

        private void button_stopCapture_Click(object sender, EventArgs e)
        {
            capturing = false;
            if (captureFile != null)
            {
                captureFile.Close();
                captureFile = null;
                ExtLog.AddLine("Capture Stopped.");
            }
        }

        private void updateCapturedLabel(string s)
        {
            if (label_received.InvokeRequired)
            {
                label_received.Invoke((void_stringDelegate)updateCapturedLabel, new object[] { s });
            }
            else label_received.Text = s;
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
