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

namespace PCtoCenturion
{
    public partial class PCtoCenturionForm : Form
    {

        public class sector
        {
          //  public int address; // 0 to 0x3200-1
            public byte[] data = new byte[400];
            public byte[] crc = new byte[2];
        }
        public List<sector> data;

        public enum state
        {
            Idle, Ready, WaitingStart, Transmit, WaitTransmitConfirmation, Abort
        }
       /* public enum inputFormat
        {
            Hawk, Finch, Raw
        }*/
        public state currentState = state.Idle;
     //   public inputFormat dataFormat = inputFormat.Raw;

        public int sectorNumber = 0;
        static SerialPort COMport;

        public Stream fileInput;
        // public byte[] data = new byte[402];
        const byte OK = 0xFF;
        const byte FAILED = 0x00;
        const int maxRetry = 10;
        public int currentTry = 0; 
        byte[] bbuff = new byte[1];

        const int poly = 0x1021;
        public int[] crct = new int[256];

        #region form setup
        public PCtoCenturionForm()
        {
            InitializeComponent();

            COMport = new SerialPort();
            //COMport.DataReceived += onDataReceived;
            COMport.ErrorReceived += onErrorReceived;

            comboBox_portSpeed.SelectedIndex = 6;

            ExtLog.bx = textBox_output;
        }
        private void PCtoCenturionForm_Load(object sender, EventArgs e)
        {
            button_list_Click(sender, e);
            /*
            testData = testData.Replace(" ", "");
            Console.WriteLine(testData.Length / 2);
            var testBytes = new byte[400];
            for (var i = 0; i < 400; ++i) testBytes[i] = Convert.ToByte(testData.Substring(i * 2, 2), 16);
            Console.WriteLine("0x" + calcCRC(testBytes).ToString("X2"));
            */
        }

        private void PCtoCenturionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (COMport.IsOpen)
            {
                COMport.DiscardOutBuffer();
                COMport.DiscardInBuffer();
                Invoke(new void_voidDelegate(COMport.Close), null);
            }
        }

        #endregion

        #region transfer events
        private void button_loadFile_Click(object sender, EventArgs e)
        {
            if (currentState != state.Idle) return;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            fileInput = File.OpenRead(openFileDialog1.FileName);
            var header = new byte[8];
            fileInput.Read(header, 0, 8);
            for (var i = 0; i < 8; ++i) header[i] = (byte)(header[i] & 0x7F);
            var marker = Encoding.ASCII.GetString(header);
            marker = marker.ToUpperInvariant();
            if (marker == "HAWKDUMP")
            {
           //     dataFormat = inputFormat.Hawk;
                ExtLog.AddLine("File format: HawkDump");
                fileInput.Seek(0, SeekOrigin.Begin);
                ExtLog.AddLine("NOT IMPLEMENTED");
            }
            else if (marker == "FINCHDUM")
            {
            //    dataFormat = inputFormat.Finch;
                ExtLog.AddLine("File format: FinchDump");
                fileInput.Seek(0, SeekOrigin.Begin);

                var t = fileInput.Length;
                if ((t % 419) != 0)
                {
                    ExtLog.AddLine("File size mismatch: " + ((float)t / 419.0f).ToString("F8") + " blocks?");
                 //   return;
                }
                fileInput.Seek(0, SeekOrigin.Begin);

                data = new List<sector>();
                var s = 0;

                // 419 per sector
                // "FinchDump\r\n" 11b
                // address 4b
                // data 400b  
                // crc 2b
                // \r\n 2b

                while (((s + 1) * 419) <= fileInput.Length)
                {
                    fileInput.Read(header, 0, 8);
                    for (var i = 0; i < 8; ++i) header[i] = (byte)(header[i] & 0x7F);
                    marker = Encoding.ASCII.GetString(header);
                    marker = marker.ToUpperInvariant();
                    if (marker != "FINCHDUM")
                    {
                        ExtLog.AddLine("Missing \"FinchDump\" header at sector 0x" + s.ToString("X4"));
                        return;
                    }
                    fileInput.Seek(3 + 4, SeekOrigin.Current);

                    var ns = new sector();
                    //    ns.address = s;
                    fileInput.Read(ns.data, 0, 400); // sector data
                    var dataCRC = calcCRC(ns.data);
                    ns.crc[0] = (byte)((dataCRC & 0xFF00) >> 8); // high byte
                    ns.crc[1] = (byte)(dataCRC & 0xFF); // low byte

                    var crcH = fileInput.ReadByte(); // crc high byte
                    var crcL = fileInput.ReadByte(); // crc low byte

                    if ((crcL == 0xFF) && (crcH == 0xFF))
                    {
                        // no crc
                    }
                    else
                    {
                        if ((!ignoreCRC_checkBox.Checked) && ((crcL != ns.crc[1]) || (crcH != ns.crc[0])))
                        {
                            ExtLog.AddLine("CRC mismatch at sector 0x" + s.ToString("X4"));
                            ExtLog.AddLine("Sector CRC: 0x" + byteToHex(ns.crc[0]) + byteToHex(ns.crc[1]));
                            ExtLog.AddLine("File CRC: 0x" + byteToHex((byte)crcH) + byteToHex((byte)crcL));
                        }
                    }
                    data.Add(ns);
                    s++;
                    fileInput.Seek(2, SeekOrigin.Current); // \r\n
                }
                currentState = state.Ready;
                sectorNumber = 0;
                ExtLog.AddLine("Loaded " + s + " sectors");
            }
            else
            {
             //   dataFormat = inputFormat.Raw;

                // finch2.bin total 30 469 061
                // finchdump 0x0D 0x0A, 4 bytes sector, 400 bytes sector data, 2 bytes checksum, 0x0D 0x0A, 419 total per sector

                // HACKfix.img total 6 651 904, 512 bytes per blocks, 12 992 blocks
                // CPU5fix.img total 6 651 904

                // CRC 16 XMODEM CCITT
                ExtLog.AddLine("File format: RAW, 512 bytes blocks");
                var t = fileInput.Length;
                if ((t % 512) != 0)
                {
                    ExtLog.AddLine("File size mismatch: " + ((float)t / 512.0f).ToString("F8") + " blocks?");
                    return;
                }
                fileInput.Seek(0, SeekOrigin.Begin);

                data = new List<sector>();
                var s = 0;
                while (((s+1)*512) <= fileInput.Length)
                {
                    var ns = new sector();
                //    ns.address = s;
                    fileInput.Read(ns.data, 0, 400);
                    var dataCRC = calcCRC(ns.data);
                    ns.crc[0] = (byte)((dataCRC & 0xFF00) >> 8); // high byte
                    ns.crc[1] = (byte)(dataCRC & 0xFF); // low byte
                    var crcH = fileInput.ReadByte();
                    var crcL = fileInput.ReadByte();

                    if ((crcL == 0xFF) && (crcH == 0xFF))
                    {
                        // no crc
                    } else
                    {
                        if ((!ignoreCRC_checkBox.Checked) && ((crcL != ns.crc[1]) || (crcH != ns.crc[0])))
                        {
                            ExtLog.AddLine("CRC mismatch at sector 0x" + s.ToString("X4"));
                            ExtLog.AddLine("Sector CRC: 0x" + byteToHex(ns.crc[0]) + byteToHex(ns.crc[1]));
                            ExtLog.AddLine("File CRC: 0x" + byteToHex((byte)crcH) + byteToHex((byte)crcL));
                        }
                    }
                    data.Add(ns);
                    s++;
                    fileInput.Seek(512 * s, SeekOrigin.Begin);
                }
                currentState = state.Ready;
                sectorNumber = 0;
                ExtLog.AddLine("Loaded " + s + " sectors");
            }
        }

        private void button_abortSend_Click(object sender, EventArgs e)
        {
            if (currentState == state.Idle) return;
            ExtLog.AddLine("Aborting send...");
            currentState = state.Abort;
            timer1_Tick(null, null);
        }

        private void button_sendFile_Click(object sender, EventArgs e)
        {


            if (!COMport.IsOpen) return;
            if (currentState != state.Ready) return;

            ExtLog.AddLine("Pinging Centurion...");
            currentState = state.WaitingStart;

            timer1.Enabled = true;

            //ping with 0xFF
            

            // wait for 0xFF

            // 
            // send 402 chunk

            // wait for FF (good) or 00 (bad)
            // resend if 00
            // load next chunk if under 0x3200


         /*   crc_init();
            Console.WriteLine(crct);
            var c = 0;
            crc_add(c, 0);
            Console.WriteLine(c);
            c = crc_add(c, 1);
            Console.WriteLine(c);
            c = crc_add(c, 16);
            Console.WriteLine(c);
            c = crc_add(c, 32);
            Console.WriteLine(c);
            c = crc_add(c, 2);
            Console.WriteLine(c);*/
        }
        #endregion

        #region data management
        private void crc_init()
        {
            for (var i = 0; i < 256; ++i)
            {
                var v = i << 8;
                for (var x = 0; x < 8; ++x) v = ((v << 1) ^ (((v & 0x8000) != 0) ? poly : 0));
                crct[i] = v & 0xffff;
            }
        }

        private int crc_add(int crc, byte val)
        {
            return ((crc << 8) ^ crct[((crc >> 8) ^ val) & 0xff]) & 0xffff;
        }

        private int calcCRC(byte[] d)
        {
            crc_init();
            var c = 0;
            for (var i = 0; i < d.Length; ++i) c = crc_add(c, d[i]);
            return c;
        }

        private string testData = "01 01 01 73 03 00 64 C5 3A B1 00 6C B1 00 FC B1 00 AE 90 05 96 B1 00 FE 83 ED A1 04 67 A1 06 14 90 00 F0 5F 90 F8 00 F6 31 01 1A 02 73 09 61 00 1A 50 54 FF EC 73 19 90 10 00 5B 5C 8A C0 FF EA CA 14 0D B0 00 00 AA 50 64 90 F0 00 51 40 15 EC 69 03 2C 55 42 50 32 FC EB F1 04 F6 50 32 FE 70 F1 04 F8 50 32 FE 70 55 2A D0 FE 7B 50 42 F1 02 8F 80 BD A1 06 BE 90 01 7E B1 06 A6 73 38 04 47 4C 00 FF 02 35 47 9C 09 A0 03 92 79 06 00 79 05 DC 03 6F C0 8A A1 03 71 7C F5 03 7B 79 06 AF 03 90 79 05 DC 03 87 80 01 A1 06 90 79 06 AF 03 A0 79 05 DC 03 8D 05 80 02 A1 05 8B A1 03 33 90 03 A0 5E 95 81 14 06 79 03 F1 B1 01 05 7E 09 32 18 05 97 31 10 05 97 91 05 97 A1 03 35 32 20 C1 03 31 90 03 32 79 05 81 79 03 3C 79 03 4D 90 00 43 D0 F8 00 F6 13 00 79 03 3C 79 03 5E F6 12 00 90 00 45 D0 F8 00 F6 13 00 79 03 3C 79 03 5E F6 12 00 C0 19 49 14 BC 30 10 05 97 7F 09 46 02 3C 0E 04 7B 79 04 FA 00 85 88 08 28 14 0A 04 79 05 DC 03 A7 71 01 7E 00 95 88 06 3B C0 80 07 36 00 11 02 43 30 D0 3C B1 44 32 54 02 81 02 35 15 05 F1 01 05 73 0F 91 01 05 59 14 09 04 79 05 DC 03 C7 71 04 F3 95 88 04 44 10 D0 3C B1 54 02 91 01 05 50 20 35 03 5B 46 02 3C 00 04 7B B1 04 7C 79 04 FA 00 95 88 0E B1 04 C7 30 8F 79 05 AD 01 85 00";

        #endregion

        #region COM port
        private void button_open_Click(object sender, EventArgs e)
        {
            if (COMport.IsOpen) button_close_Click(sender, e);

            try
            {
                COMport.PortName = comboBox_portName.Text;
                COMport.BaudRate = int.Parse(comboBox_portSpeed.Text);
                COMport.Parity = Parity.None;
                COMport.DataBits = 8;
                COMport.StopBits = StopBits.One;
                COMport.Handshake = checkBox_CTS.Checked ? Handshake.RequestToSend : Handshake.None;

                // Set the read/write timeouts
                COMport.ReadTimeout = 1000;
                COMport.WriteTimeout = 1000;
            }
            catch (Exception ex)
            {
                ExtLog.AddLine("Error setting up serial port: " + ex.Message);
                return;
            }

            try
            {
                COMport.Open();
                var cnt = 25;
                while (!COMport.IsOpen && (cnt-- > 0)) Thread.Sleep(100);
                if (cnt > 0)
                {
                    ExtLog.AddLine("Session Started: " + DateTime.Now.ToString("yyyy-MM-dd"));
                    ExtLog.AddLine(COMport.PortName + " " + COMport.BaudRate + ", 8N1, Handshake: " + (checkBox_CTS.Checked ? "CTS/RTS" : "None"));
                    ExtLog.AddLine($"ReadTimeout: {COMport.ReadTimeout}ms, WriteTimeout: {COMport.WriteTimeout}ms, maxRetry: {maxRetry}");
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
        private void button_close_Click(object sender, EventArgs e)
        {
            if (!COMport.IsOpen) return;
            Invoke(new void_voidDelegate(COMport.Close), null);
            ExtLog.AddLine("Port Closed");
        }

        private void checkBox_CTS_CheckedChanged(object sender, EventArgs e)
        {
            COMport.Handshake = checkBox_CTS.Checked ? Handshake.RequestToSend : Handshake.None;
        }


        #endregion

        #region string and format
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

        public static string ts()
        {
            return DateTime.Now.ToString("HH:mm:ss.ff ");
        }
        #endregion

        #region log
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
                    else bx.AppendText(ts() + s + "\r\n");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            switch (currentState)
            {
                case state.Abort:
                {
                        currentState = state.Idle;
                        sectorNumber = 0;
                        if (COMport.IsOpen) COMport.DiscardOutBuffer();
                    break;
                }
                case state.Idle:
                {
                    break;
                }
                case state.Transmit:
                {
                        label_sector.Text = "Sector: 0x" + sectorNumber.ToString("X4");
                        try
                        {
                            COMport.Write(data[sectorNumber].data, 0, 400);
                            COMport.Write(data[sectorNumber].crc, 0, 2);
                            currentState = state.WaitTransmitConfirmation;
                            timer1.Enabled = true;
                        } 
                        catch (Exception ex)
                        {
                            ExtLog.terminateLineIfNecessary();
                            ExtLog.AddLine("TX Exception: " + ex.Message);
                            currentState = state.Idle;
                        }
                    break;
                }
                case state.WaitingStart:
                {
                        bbuff[0] = OK;
                        var r = 0;
                        try
                        {
                            COMport.Write(bbuff, 0, 1);
                            r = COMport.Read(bbuff, 0, 1);
                        }
                        catch
                        {
                            r = 0;
                        }
                        if (r == 1)
                        {
                            if (bbuff[0] == OK)
                            {
                                ExtLog.terminateLineIfNecessary();
                                ExtLog.Add("Sending");
                                currentTry = 0;
                                currentState = state.Transmit;
                            }
                            else
                            {
                                ExtLog.Add("X");
                            }
                        } else
                        {
                            ExtLog.Add(".");
                        }
                        timer1.Enabled = true;
                        break;
                }
                case state.WaitTransmitConfirmation:
                {
                        var r = 0;
                      //  COMport.Write(bbuff, 0, 1);
                        try
                        {
                            r = COMport.Read(bbuff, 0, 1);
                        }
                        catch
                        {
                            r = -1;
                        }
                        if (r == 1)
                        {
                            if (bbuff[0] == OK)
                            {
                                ExtLog.Add(".");
                                sectorNumber++;
                                currentTry = 0;
                                if (sectorNumber >= data.Count)
                                {
                                    ExtLog.terminateLineIfNecessary();
                                    ExtLog.AddLine("Done.");
                                    currentState = state.Idle;
                                } else
                                {
                                    currentState = state.Transmit;
                                }
                            }
                            else
                            {
                                ExtLog.Add("X");
                                currentTry++;
                                if (currentTry < maxRetry)
                                {
                                    currentState = state.Transmit;
                                } else
                                {
                                    ExtLog.Add("max retry exceeded at sector 0x" + sectorNumber.ToString("X4"));
                                    currentState = state.Abort;
                                }
                            }
                        }
                        timer1.Enabled = true;
                        break;
                }
            }
        }
    }
}
