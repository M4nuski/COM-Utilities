using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        byte[] charBuffer = new byte[1];

        StringBuilder sb = new StringBuilder();

        /*
        Add CR+LF
        Add LF 0A
        No Line Ending  
        */
        readonly string[] LE = new string[4] { "\r\n", "\n", "", "\r" };
        readonly List<char> hexChars = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

        public SerialConsoleForm()
        {
            Console.WriteLine("ctor");
            InitializeComponent();
            _serialPort = new SerialPort();
            _serialPort.DataReceived += onDataReceived;
            _serialPort.ErrorReceived += onErrorReceived;
            _serialPort.PinChanged += onPinChanged;

            ExtLog.bx = textBox_output;
            ExtLog.tsf = "HH:mm:ss.ff ";

           // comboBox_Format.SelectedIndex = 0;
            comboBox_LE.SelectedIndex = 0;

            try
            {
                comboBox_portName.Text = Properties.Settings.Default.lastPortName;
                comboBox_portSpeed.Text = Properties.Settings.Default.lastPortSpeed;

                checkBox_text.Checked = Properties.Settings.Default.FormatText;
                checkBox_hex.Checked = Properties.Settings.Default.FormatHex;
                checkBox_bin.Checked = Properties.Settings.Default.FormatBin;

                comboBox_LE.SelectedIndex = Properties.Settings.Default.lastLE;
                checkBox_autoLineEnd.Checked = Properties.Settings.Default.fixLE;
                checkBox_timeStamps.Checked = Properties.Settings.Default.timeStamps;
                checkBox_terminalMode.Checked = Properties.Settings.Default.terminalMode;

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
                ExtLog.AddLine("Error reading Settings", true);
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
            ExtLog.AddLine("Error: " + e.EventType.ToString(), true);
            if (checkBox_sendPattern.Checked) checkBox_sendPattern.Checked = false;
            stopSend = true;
        }

        private void onPinChanged(object sender, SerialPinChangedEventArgs e)
        {
            if (e.EventType == SerialPinChange.Ring)
            {
                ExtLog.AddLine("*RING*", checkBox_timeStamps.Checked);

                this.Invoke((void_voidDelegate)showRing);
            }
        }

        private void showRing()
        {
            label_ring.Visible = true;
            if (timer_ring.Enabled)
            {
                timer_ring.Stop();
                timer_ring.Start();
            }
            else
            {
                timer_ring.Start();
                System.Media.SystemSounds.Beep.Play();
            }
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
                        _serialPort.DtrEnable = checkBox_DTRenable.Checked;
                        _serialPort.RtsEnable = checkBox_RTSenable.Checked;

                        break;
                    case 2:
                        _serialPort.Handshake = Handshake.XOnXOff;
                        break;
                    case 3:
                        _serialPort.Handshake = Handshake.RequestToSendXOnXOff;
                        _serialPort.DtrEnable = checkBox_DTRenable.Checked;
                        _serialPort.RtsEnable = checkBox_RTSenable.Checked;
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
                    ExtLog.AddLine("Invalid timeout value", true);
                    timeout = 500;
                    timeout_textBox.Text = "500";
                }
                _serialPort.ReadTimeout = timeout;
                _serialPort.WriteTimeout = timeout;
            } catch (Exception ex)
            {
                ExtLog.AddLine("Error setting up serial port: " + ex.Message, true);
                return;
            }

            try
            {
               
                _serialPort.Open();
                _serialPort.ReceivedBytesThreshold = 1;
               var cnt = 25;
                while (!_serialPort.IsOpen && (cnt-- > 0)) Thread.Sleep(200);
                if (cnt > 0)
                {
                    ExtLog.AddLine("Session Started: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), false);
                    ExtLog.AddLine(_serialPort.PortName + "@" + _serialPort.BaudRate, false);
                }
                else
                {
                    ExtLog.AddLine("Failed to open port", true);
                    button_close_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                ExtLog.AddLine("Error opening serial port: " + ex.Message, true);
            }
        }

        private void onDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (checkBox_pause.Checked)
            {
                _serialPort.DiscardInBuffer();
                return;
            }

            if (checkBox_terminalMode.Checked)
            {
                var inText = _serialPort.ReadExisting();
                inText = fixLineEndings(inText);
                ExtLog.AddLine(inText, false, false);

                if (capturing && (captureFile != null))
                {
                    var sb = Encoding.ASCII.GetBytes(inText);
                    captureFile.Write(sb, 0, sb.Length);
                    updateCapturedLabel(captureFile.Length.ToString());
                }

                return;
            }

            // Text Only
            if (checkBox_text.Checked && !checkBox_hex.Checked && !checkBox_bin.Checked)
            {
                string inText = "";
                while (_serialPort.BytesToRead > 0)
                {
                    try
                    {
                        inText += _serialPort.ReadLine();
                    }
                    catch
                    {
                        inText += _serialPort.ReadExisting();
                    }
                }

                if (capturing && (captureFile != null))
                {
                    var sb = Encoding.ASCII.GetBytes(inText);
                    captureFile.Write(sb, 0, sb.Length);
                    updateCapturedLabel(captureFile.Length.ToString());
                }

                inText = fixLineEndings(inText);
                ExtLog.AddLine(inText, checkBox_timeStamps.Checked);
                return;
            }

            var toRead = _serialPort.BytesToRead;
            while (toRead > 0)
            {
                sb.Clear();
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

                if (checkBox_bin.Checked)
                {
                    sb.Append(binStr + " ");
                }

                if (checkBox_hex.Checked)
                {
                    sb.Append(hexStr + " ");
                }

                if (checkBox_text.Checked)
                {
                    sb.Append(txtStr);
                }

                ExtLog.AddLine(sb.ToString(), checkBox_timeStamps.Checked);
                toRead = _serialPort.BytesToRead;
                //ExtLog.Add(toRead.ToString() + '/' + _serialPort.BytesToRead.ToString());
            }
        }

        private string fixLineEndings(string inText)
        {
            if (!checkBox_autoLineEnd.Checked) return inText;

            inText = inText.Replace("\r\n", "\n");
            inText = inText.Replace("\r", "\n");
            inText = inText.Replace("\n", "\r\n");
            return inText;
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
            //return "" + Convert.ToChar(b);
            charBuffer[0] = b;
            return Encoding.ASCII.GetString(charBuffer);
        }

      //  public string ts()
      //  {
      //      return checkBox_timeStamps.Checked ? DateTime.Now.ToString("HH:mm:ss.ff ") : "";
      //  }

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
               // Invoke(new void_voidDelegate(_serialPort.Close), null);
                _serialPort.Close();
            }
            try
            {
                Properties.Settings.Default.lastPortName = comboBox_portName.Text;
                Properties.Settings.Default.lastPortSpeed = comboBox_portSpeed.Text;

                Properties.Settings.Default.FormatText = checkBox_text.Checked;
                Properties.Settings.Default.FormatHex = checkBox_hex.Checked;
                Properties.Settings.Default.FormatBin = checkBox_bin.Checked;

                Properties.Settings.Default.lastLE = comboBox_LE.SelectedIndex;
                Properties.Settings.Default.fixLE = checkBox_autoLineEnd.Checked;
                Properties.Settings.Default.timeStamps = checkBox_timeStamps.Checked;
                Properties.Settings.Default.terminalMode = checkBox_terminalMode.Checked;

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
                if ((s.Length % 2) != 0) s = "0" + s;
                for (var i = 0; i < s.Length; i += 2) dataBuffer[i / 2] = hexToByte(s.Substring(i, 2));

                _serialPort.Write(dataBuffer, 0, s.Length / 2);
            }
            ExtLog.AddLine("> " + textBox_input.Text, checkBox_timeStamps.Checked);
            if ((textBox_input.Text.Trim() != "") && (textBox_input.Text != safeLastHistory())) history.Add(textBox_input.Text);
            historyIndex = history.Count;
            textBox_input.Clear();
        }

        private string safeLastHistory()
        {
            if (history.Count == 0) return "";
            return history.Last();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            Invoke(new void_voidDelegate(_serialPort.Close), null);
            
            ExtLog.AddLine("Port Closed", checkBox_timeStamps.Checked);
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
                ExtLog.AddLine("Reading file " + openFileDialog1.FileName, false);
                stopSend = false;
                lastFileName = openFileDialog1.FileName;
                sendBIN(f);
                f.Close();
            } catch (Exception ex)
            {
                ExtLog.AddLine(ex.Message, true);
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
                ExtLog.AddLine("Invalid chunk size value", true);
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
                ExtLog.AddLine("Invalid chunk delay value", true);
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
                    ExtLog.AddLine("-> Header " + textBox_HDR.Text, checkBox_timeStamps.Checked);
                }
                catch (Exception ex)
                {
                    ExtLog.AddLine(ex.Message, true);
                }
            }

            var data = new byte[chunkSize];
            var dataLength = f.Read(data, 0, chunkSize);

            if ((1000 * chunkSize / (_serialPort.BaudRate / 10)) > _serialPort.WriteTimeout) ExtLog.AddLine("**** Chunk size might be too high for baudrate/timeout ****", true);


            while ((dataLength > 0) && !stopSend)
            {
                try
                {
                    _serialPort.Write(data, 0, dataLength);
                    totalSent += dataLength;
                    ExtLog.AddLine("-> " + dataLength.ToString("D"), checkBox_timeStamps.Checked);                    
                }
                catch (Exception ex)
                {
                    ExtLog.AddLine(ex.Message, true);
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
                    ExtLog.AddLine("-> Footer " + textBox_FTR.Text, checkBox_timeStamps.Checked);
                }
                catch (Exception ex)
                {
                    ExtLog.AddLine(ex.Message, true);
                }
            }

            ExtLog.AddLine($"Sent {totalSent}/{f.Length} bytes", checkBox_timeStamps.Checked);
            
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            stopSend = true;
        }

        public List<byte> textBoxToByteList(TextBox tb)
        {
            var c = tb.Text.ToUpperInvariant().Where(v => hexChars.Contains(v));
            string s = string.Concat(c);
            if ((s.Length % 2) != 0) s = "0" + s;
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
                        ExtLog.AddLine("-> " + textBox_sendPattern.Text, checkBox_timeStamps.Checked);
                        _serialPort.Write(sendPattern.ToArray(), 0, sendPattern.Count);
                    } catch (Exception ex)
                    {
                        ExtLog.AddLine(ex.Message, true);
                    }
                checkBox_sendPattern.Checked = false;
                } else if (comboBox_pattern.SelectedIndex == 1)
                {
                    while (checkBox_sendPattern.Checked && _serialPort.IsOpen)
                    {
                        try {
                            ExtLog.AddLine("-> " + textBox_sendPattern.Text, checkBox_timeStamps.Checked);
                            _serialPort.Write(sendPattern.ToArray(), 0, sendPattern.Count);
                        } catch (Exception ex)
                        {
                            ExtLog.AddLine(ex.Message, true);
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
                ExtLog.AddLine("Reading file " + lastFileName, false);
                stopSend = false;
                sendBIN(f);
                f.Close();
            }
            catch (Exception ex)
            {
                ExtLog.AddLine(ex.Message, true);
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
                ExtLog.AddLine("Capture Started in " + saveFileDialog1.FileName, checkBox_timeStamps.Checked);
                label_received.Text = "0";
            } catch (Exception ex) {
                ExtLog.AddLine(ex.Message, true);
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
            if (captureFile == null) return;
            
            captureFile.Close();
            captureFile = null;
            ExtLog.AddLine("Capture Stopped.", checkBox_timeStamps.Checked);
        }

        private void updateCapturedLabel(string s)
        {
            if (label_received.InvokeRequired)
            {
                label_received.Invoke((void_stringDelegate)updateCapturedLabel, new object[] { s });
            }
            else label_received.Text = s;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            checkBox_BH.Checked = _serialPort.BreakState;
            checkBox_CDH.Checked = _serialPort.CDHolding;
            checkBox_CTSH.Checked = _serialPort.CtsHolding;
            checkBox_DSRH.Checked = _serialPort.DsrHolding;
        }


        private void checkBox_lineControl_CheckedChanged(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            _serialPort.DtrEnable = checkBox_DTRenable.Checked;
            _serialPort.RtsEnable = checkBox_RTSenable.Checked;
        }

        private void timer_ring_Tick(object sender, EventArgs e)
        {
            label_ring.Visible = false;
        }

        private void checkBoxDTRenable_CheckedChanged(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen) return;
            _serialPort.DtrEnable = checkBox_DTRenable.Checked;
            _serialPort.RtsEnable = checkBox_RTSenable.Checked;
        }
    }

    delegate void void_stringDelegate(string text);
    delegate void void_stringboolboolDelegate(string text, bool tmstmp, bool term);
    delegate void void_voidDelegate();
    public delegate string string_voidDelegage();

    public static class ExtLog
    {

        public static TextBox bx;
        public static string tsf = "HH:mm:ss.ff ";

        public static void AddLine(string s, bool timestamp, bool autoTerminate = true)
        {
            if (bx == null) return;
            if (s == "") return;

            if (bx.InvokeRequired)
            {
                bx.Invoke((void_stringboolboolDelegate)AddLine, new object[] { s, timestamp, autoTerminate });
            }
            else
            {
                if (autoTerminate && (bx.Text.Length != 0) && !bx.Text.EndsWith("\r\n")) bx.AppendText("\r\n");
                if (timestamp) bx.AppendText(DateTime.Now.ToString(tsf));

                bx.AppendText(s.EndsWith("\r\n") ? s : s + "\r\n");
            }

        }

    }
}
