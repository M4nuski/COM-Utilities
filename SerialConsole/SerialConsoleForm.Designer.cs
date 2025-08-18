
namespace SerialConsole
{
    partial class SerialConsoleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
       // private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      /*  protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.comboBox_LE = new System.Windows.Forms.ComboBox();
            this.comboBox_inputType = new System.Windows.Forms.ComboBox();
            this.button_sendBIN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_sent = new System.Windows.Forms.Label();
            this.button_Resend = new System.Windows.Forms.Button();
            this.checkBox_sendFTR = new System.Windows.Forms.CheckBox();
            this.checkBox_sendHDR = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_FTR = new System.Windows.Forms.TextBox();
            this.textBox_HDR = new System.Windows.Forms.TextBox();
            this.button_X = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendBinChunk_textBox = new System.Windows.Forms.TextBox();
            this.SendBinPause_textBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_pattern = new System.Windows.Forms.ComboBox();
            this.textBox_receivePattern = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_patternDelay = new System.Windows.Forms.TextBox();
            this.textBox_sendPattern = new System.Windows.Forms.TextBox();
            this.checkBox_sendPattern = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_stopCapture = new System.Windows.Forms.Button();
            this.button_capture = new System.Windows.Forms.Button();
            this.label_received = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_COMcontrols = new System.Windows.Forms.Panel();
            this.label_ring = new System.Windows.Forms.Label();
            this.checkBox_BH = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_DSRH = new System.Windows.Forms.CheckBox();
            this.checkBox_CTSH = new System.Windows.Forms.CheckBox();
            this.label_ls = new System.Windows.Forms.Label();
            this.checkBox_CDH = new System.Windows.Forms.CheckBox();
            this.checkBox_RTSenable = new System.Windows.Forms.CheckBox();
            this.checkBox_DTRenable = new System.Windows.Forms.CheckBox();
            this.label_br = new System.Windows.Forms.Label();
            this.comboBox_stopBits = new System.Windows.Forms.ComboBox();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.comboBox_bitLength = new System.Windows.Forms.ComboBox();
            this.comboBox_handshake = new System.Windows.Forms.ComboBox();
            this.timeout_textBox = new System.Windows.Forms.TextBox();
            this.label_to = new System.Windows.Forms.Label();
            this.button_list = new System.Windows.Forms.Button();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.comboBox_portSpeed = new System.Windows.Forms.ComboBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_LOGcontrols = new System.Windows.Forms.Panel();
            this.checkBox_autoLineEnd = new System.Windows.Forms.CheckBox();
            this.checkBox_bin = new System.Windows.Forms.CheckBox();
            this.checkBox_hex = new System.Windows.Forms.CheckBox();
            this.checkBox_text = new System.Windows.Forms.CheckBox();
            this.checkBox_terminalMode = new System.Windows.Forms.CheckBox();
            this.checkBox_pause = new System.Windows.Forms.CheckBox();
            this.checkBox_timeStamps = new System.Windows.Forms.CheckBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.timer_ring = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_COMcontrols.SuspendLayout();
            this.panel_LOGcontrols.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_output.Location = new System.Drawing.Point(10, 150);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_output.Size = new System.Drawing.Size(1329, 609);
            this.textBox_output.TabIndex = 2;
            // 
            // textBox_input
            // 
            this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_input.Location = new System.Drawing.Point(63, 765);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_input.Size = new System.Drawing.Size(1048, 31);
            this.textBox_input.TabIndex = 9;
            this.textBox_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyDown);
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.Location = new System.Drawing.Point(1278, 765);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(64, 26);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // comboBox_LE
            // 
            this.comboBox_LE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_LE.FormattingEnabled = true;
            this.comboBox_LE.ItemHeight = 18;
            this.comboBox_LE.Items.AddRange(new object[] {
            "Add CR+LF (0x0D 0x0A) Windows \\r\\n",
            "Add LF (0x0A) Linux \\n",
            "No Line Ending",
            "Add CR (0x0D) Vintage"});
            this.comboBox_LE.Location = new System.Drawing.Point(1117, 767);
            this.comboBox_LE.Name = "comboBox_LE";
            this.comboBox_LE.Size = new System.Drawing.Size(155, 26);
            this.comboBox_LE.TabIndex = 12;
            // 
            // comboBox_inputType
            // 
            this.comboBox_inputType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_inputType.FormattingEnabled = true;
            this.comboBox_inputType.IntegralHeight = false;
            this.comboBox_inputType.ItemHeight = 18;
            this.comboBox_inputType.Items.AddRange(new object[] {
            "Text",
            "HEX"});
            this.comboBox_inputType.Location = new System.Drawing.Point(10, 766);
            this.comboBox_inputType.Name = "comboBox_inputType";
            this.comboBox_inputType.Size = new System.Drawing.Size(47, 26);
            this.comboBox_inputType.TabIndex = 14;
            this.comboBox_inputType.Text = "Text";
            // 
            // button_sendBIN
            // 
            this.button_sendBIN.Location = new System.Drawing.Point(4, 3);
            this.button_sendBIN.Name = "button_sendBIN";
            this.button_sendBIN.Size = new System.Drawing.Size(75, 23);
            this.button_sendBIN.TabIndex = 17;
            this.button_sendBIN.Text = "Send File";
            this.button_sendBIN.UseVisualStyleBackColor = true;
            this.button_sendBIN.Click += new System.EventHandler(this.button_sendBIN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bin";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_sent);
            this.panel1.Controls.Add(this.button_Resend);
            this.panel1.Controls.Add(this.checkBox_sendFTR);
            this.panel1.Controls.Add(this.checkBox_sendHDR);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_FTR);
            this.panel1.Controls.Add(this.textBox_HDR);
            this.panel1.Controls.Add(this.button_X);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SendBinChunk_textBox);
            this.panel1.Controls.Add(this.SendBinPause_textBox);
            this.panel1.Controls.Add(this.button_sendBIN);
            this.panel1.Location = new System.Drawing.Point(411, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 132);
            this.panel1.TabIndex = 18;
            // 
            // label_sent
            // 
            this.label_sent.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sent.Location = new System.Drawing.Point(-1, 107);
            this.label_sent.Name = "label_sent";
            this.label_sent.Size = new System.Drawing.Size(247, 22);
            this.label_sent.TabIndex = 22;
            this.label_sent.Text = "0/0";
            this.label_sent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Resend
            // 
            this.button_Resend.Location = new System.Drawing.Point(4, 53);
            this.button_Resend.Name = "button_Resend";
            this.button_Resend.Size = new System.Drawing.Size(75, 23);
            this.button_Resend.TabIndex = 29;
            this.button_Resend.Text = "Resend";
            this.button_Resend.UseVisualStyleBackColor = true;
            this.button_Resend.Click += new System.EventHandler(this.button_Resend_Click);
            // 
            // checkBox_sendFTR
            // 
            this.checkBox_sendFTR.AutoSize = true;
            this.checkBox_sendFTR.Location = new System.Drawing.Point(84, 84);
            this.checkBox_sendFTR.Name = "checkBox_sendFTR";
            this.checkBox_sendFTR.Size = new System.Drawing.Size(18, 17);
            this.checkBox_sendFTR.TabIndex = 28;
            this.checkBox_sendFTR.UseVisualStyleBackColor = true;
            // 
            // checkBox_sendHDR
            // 
            this.checkBox_sendHDR.AutoSize = true;
            this.checkBox_sendHDR.Location = new System.Drawing.Point(84, 58);
            this.checkBox_sendHDR.Name = "checkBox_sendHDR";
            this.checkBox_sendHDR.Size = new System.Drawing.Size(18, 17);
            this.checkBox_sendHDR.TabIndex = 27;
            this.checkBox_sendHDR.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Footer:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Header:";
            // 
            // textBox_FTR
            // 
            this.textBox_FTR.Location = new System.Drawing.Point(155, 80);
            this.textBox_FTR.Name = "textBox_FTR";
            this.textBox_FTR.Size = new System.Drawing.Size(91, 24);
            this.textBox_FTR.TabIndex = 24;
            this.textBox_FTR.Text = "1A";
            // 
            // textBox_HDR
            // 
            this.textBox_HDR.Location = new System.Drawing.Point(155, 54);
            this.textBox_HDR.Name = "textBox_HDR";
            this.textBox_HDR.Size = new System.Drawing.Size(91, 24);
            this.textBox_HDR.TabIndex = 23;
            this.textBox_HDR.Text = "F0 0D 0A";
            // 
            // button_X
            // 
            this.button_X.Location = new System.Drawing.Point(4, 78);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(74, 23);
            this.button_X.TabIndex = 22;
            this.button_X.Text = "CANCEL";
            this.button_X.UseVisualStyleBackColor = true;
            this.button_X.Click += new System.EventHandler(this.button_X_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chunk Delay (ms):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chunk Size:";
            // 
            // SendBinChunk_textBox
            // 
            this.SendBinChunk_textBox.Location = new System.Drawing.Point(155, 3);
            this.SendBinChunk_textBox.Name = "SendBinChunk_textBox";
            this.SendBinChunk_textBox.Size = new System.Drawing.Size(91, 24);
            this.SendBinChunk_textBox.TabIndex = 19;
            this.SendBinChunk_textBox.Text = "256";
            // 
            // SendBinPause_textBox
            // 
            this.SendBinPause_textBox.Location = new System.Drawing.Point(155, 28);
            this.SendBinPause_textBox.Name = "SendBinPause_textBox";
            this.SendBinPause_textBox.Size = new System.Drawing.Size(91, 24);
            this.SendBinPause_textBox.TabIndex = 18;
            this.SendBinPause_textBox.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.comboBox_pattern);
            this.panel4.Controls.Add(this.textBox_receivePattern);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox_patternDelay);
            this.panel4.Controls.Add(this.textBox_sendPattern);
            this.panel4.Controls.Add(this.checkBox_sendPattern);
            this.panel4.Location = new System.Drawing.Point(672, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 132);
            this.panel4.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Reply On:";
            // 
            // comboBox_pattern
            // 
            this.comboBox_pattern.FormattingEnabled = true;
            this.comboBox_pattern.Items.AddRange(new object[] {
            "Once",
            "Repeat",
            "Reply Once",
            "Reply Always"});
            this.comboBox_pattern.Location = new System.Drawing.Point(107, 7);
            this.comboBox_pattern.Name = "comboBox_pattern";
            this.comboBox_pattern.Size = new System.Drawing.Size(91, 26);
            this.comboBox_pattern.TabIndex = 23;
            this.comboBox_pattern.Text = "Once";
            // 
            // textBox_receivePattern
            // 
            this.textBox_receivePattern.Location = new System.Drawing.Point(74, 84);
            this.textBox_receivePattern.Name = "textBox_receivePattern";
            this.textBox_receivePattern.Size = new System.Drawing.Size(124, 24);
            this.textBox_receivePattern.TabIndex = 22;
            this.textBox_receivePattern.Text = "FF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Repeat Delay (ms):";
            // 
            // textBox_patternDelay
            // 
            this.textBox_patternDelay.Location = new System.Drawing.Point(121, 59);
            this.textBox_patternDelay.Name = "textBox_patternDelay";
            this.textBox_patternDelay.Size = new System.Drawing.Size(77, 24);
            this.textBox_patternDelay.TabIndex = 20;
            this.textBox_patternDelay.Text = "50";
            // 
            // textBox_sendPattern
            // 
            this.textBox_sendPattern.Location = new System.Drawing.Point(5, 34);
            this.textBox_sendPattern.Name = "textBox_sendPattern";
            this.textBox_sendPattern.Size = new System.Drawing.Size(193, 24);
            this.textBox_sendPattern.TabIndex = 1;
            this.textBox_sendPattern.Text = "AA AA AA AA 00 01 0D 0A";
            // 
            // checkBox_sendPattern
            // 
            this.checkBox_sendPattern.AutoSize = true;
            this.checkBox_sendPattern.Location = new System.Drawing.Point(5, 8);
            this.checkBox_sendPattern.Name = "checkBox_sendPattern";
            this.checkBox_sendPattern.Size = new System.Drawing.Size(115, 22);
            this.checkBox_sendPattern.TabIndex = 0;
            this.checkBox_sendPattern.Text = "Send Pattern";
            this.checkBox_sendPattern.UseVisualStyleBackColor = true;
            this.checkBox_sendPattern.CheckedChanged += new System.EventHandler(this.checkBox_sendPattern_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button_stopCapture);
            this.panel5.Controls.Add(this.button_capture);
            this.panel5.Controls.Add(this.label_received);
            this.panel5.Location = new System.Drawing.Point(1002, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 132);
            this.panel5.TabIndex = 22;
            // 
            // button_stopCapture
            // 
            this.button_stopCapture.Location = new System.Drawing.Point(4, 52);
            this.button_stopCapture.Name = "button_stopCapture";
            this.button_stopCapture.Size = new System.Drawing.Size(91, 23);
            this.button_stopCapture.TabIndex = 32;
            this.button_stopCapture.Text = "Stop";
            this.button_stopCapture.UseVisualStyleBackColor = true;
            this.button_stopCapture.Click += new System.EventHandler(this.button_stopCapture_Click);
            // 
            // button_capture
            // 
            this.button_capture.Location = new System.Drawing.Point(3, 1);
            this.button_capture.Name = "button_capture";
            this.button_capture.Size = new System.Drawing.Size(139, 23);
            this.button_capture.TabIndex = 31;
            this.button_capture.Text = "Capture RX Data";
            this.button_capture.UseVisualStyleBackColor = true;
            this.button_capture.Click += new System.EventHandler(this.button_capture_Click);
            // 
            // label_received
            // 
            this.label_received.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_received.Location = new System.Drawing.Point(3, 27);
            this.label_received.Name = "label_received";
            this.label_received.Size = new System.Drawing.Size(139, 22);
            this.label_received.TabIndex = 30;
            this.label_received.Text = "0";
            this.label_received.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bin";
            this.saveFileDialog1.Filter = "Text|*.txt|Binary|.bin|All|*.*";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_COMcontrols
            // 
            this.panel_COMcontrols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_COMcontrols.Controls.Add(this.label_ring);
            this.panel_COMcontrols.Controls.Add(this.checkBox_BH);
            this.panel_COMcontrols.Controls.Add(this.label3);
            this.panel_COMcontrols.Controls.Add(this.checkBox_DSRH);
            this.panel_COMcontrols.Controls.Add(this.checkBox_CTSH);
            this.panel_COMcontrols.Controls.Add(this.label_ls);
            this.panel_COMcontrols.Controls.Add(this.checkBox_CDH);
            this.panel_COMcontrols.Controls.Add(this.checkBox_RTSenable);
            this.panel_COMcontrols.Controls.Add(this.checkBox_DTRenable);
            this.panel_COMcontrols.Controls.Add(this.label_br);
            this.panel_COMcontrols.Controls.Add(this.comboBox_stopBits);
            this.panel_COMcontrols.Controls.Add(this.comboBox_parity);
            this.panel_COMcontrols.Controls.Add(this.comboBox_bitLength);
            this.panel_COMcontrols.Controls.Add(this.comboBox_handshake);
            this.panel_COMcontrols.Controls.Add(this.timeout_textBox);
            this.panel_COMcontrols.Controls.Add(this.label_to);
            this.panel_COMcontrols.Controls.Add(this.button_list);
            this.panel_COMcontrols.Controls.Add(this.comboBox_portName);
            this.panel_COMcontrols.Controls.Add(this.comboBox_portSpeed);
            this.panel_COMcontrols.Controls.Add(this.button_open);
            this.panel_COMcontrols.Controls.Add(this.button_close);
            this.panel_COMcontrols.Location = new System.Drawing.Point(10, 12);
            this.panel_COMcontrols.Name = "panel_COMcontrols";
            this.panel_COMcontrols.Size = new System.Drawing.Size(393, 132);
            this.panel_COMcontrols.TabIndex = 33;
            // 
            // label_ring
            // 
            this.label_ring.AutoSize = true;
            this.label_ring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ring.ForeColor = System.Drawing.Color.Red;
            this.label_ring.Location = new System.Drawing.Point(346, 85);
            this.label_ring.Name = "label_ring";
            this.label_ring.Size = new System.Drawing.Size(49, 18);
            this.label_ring.TabIndex = 32;
            this.label_ring.Text = "RING";
            this.label_ring.Visible = false;
            // 
            // checkBox_BH
            // 
            this.checkBox_BH.AutoSize = true;
            this.checkBox_BH.Location = new System.Drawing.Point(331, 107);
            this.checkBox_BH.Name = "checkBox_BH";
            this.checkBox_BH.Size = new System.Drawing.Size(69, 22);
            this.checkBox_BH.TabIndex = 31;
            this.checkBox_BH.Text = "Break";
            this.checkBox_BH.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Control Lines:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox_DSRH
            // 
            this.checkBox_DSRH.AutoSize = true;
            this.checkBox_DSRH.Location = new System.Drawing.Point(244, 107);
            this.checkBox_DSRH.Name = "checkBox_DSRH";
            this.checkBox_DSRH.Size = new System.Drawing.Size(97, 22);
            this.checkBox_DSRH.TabIndex = 29;
            this.checkBox_DSRH.Text = "DSR Hold";
            this.checkBox_DSRH.UseVisualStyleBackColor = true;
            // 
            // checkBox_CTSH
            // 
            this.checkBox_CTSH.AutoSize = true;
            this.checkBox_CTSH.Location = new System.Drawing.Point(164, 107);
            this.checkBox_CTSH.Name = "checkBox_CTSH";
            this.checkBox_CTSH.Size = new System.Drawing.Size(95, 22);
            this.checkBox_CTSH.TabIndex = 28;
            this.checkBox_CTSH.Text = "CTS Hold";
            this.checkBox_CTSH.UseVisualStyleBackColor = true;
            // 
            // label_ls
            // 
            this.label_ls.AutoSize = true;
            this.label_ls.Location = new System.Drawing.Point(8, 108);
            this.label_ls.Name = "label_ls";
            this.label_ls.Size = new System.Drawing.Size(93, 18);
            this.label_ls.TabIndex = 27;
            this.label_ls.Text = "Lines Status:";
            this.label_ls.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox_CDH
            // 
            this.checkBox_CDH.AutoSize = true;
            this.checkBox_CDH.Location = new System.Drawing.Point(86, 107);
            this.checkBox_CDH.Name = "checkBox_CDH";
            this.checkBox_CDH.Size = new System.Drawing.Size(87, 22);
            this.checkBox_CDH.TabIndex = 26;
            this.checkBox_CDH.Text = "CD Hold";
            this.checkBox_CDH.UseVisualStyleBackColor = true;
            // 
            // checkBox_RTSenable
            // 
            this.checkBox_RTSenable.AutoSize = true;
            this.checkBox_RTSenable.Checked = true;
            this.checkBox_RTSenable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RTSenable.Location = new System.Drawing.Point(164, 84);
            this.checkBox_RTSenable.Name = "checkBox_RTSenable";
            this.checkBox_RTSenable.Size = new System.Drawing.Size(60, 22);
            this.checkBox_RTSenable.TabIndex = 25;
            this.checkBox_RTSenable.Text = "RTS";
            this.checkBox_RTSenable.UseVisualStyleBackColor = true;
            this.checkBox_RTSenable.CheckedChanged += new System.EventHandler(this.checkBox_lineControl_CheckedChanged);
            // 
            // checkBox_DTRenable
            // 
            this.checkBox_DTRenable.AutoSize = true;
            this.checkBox_DTRenable.Checked = true;
            this.checkBox_DTRenable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DTRenable.Location = new System.Drawing.Point(86, 84);
            this.checkBox_DTRenable.Name = "checkBox_DTRenable";
            this.checkBox_DTRenable.Size = new System.Drawing.Size(61, 22);
            this.checkBox_DTRenable.TabIndex = 24;
            this.checkBox_DTRenable.Text = "DTR";
            this.checkBox_DTRenable.UseVisualStyleBackColor = true;
            this.checkBox_DTRenable.CheckedChanged += new System.EventHandler(this.checkBox_lineControl_CheckedChanged);
            // 
            // label_br
            // 
            this.label_br.AutoSize = true;
            this.label_br.Location = new System.Drawing.Point(222, 8);
            this.label_br.Name = "label_br";
            this.label_br.Size = new System.Drawing.Size(81, 18);
            this.label_br.TabIndex = 23;
            this.label_br.Text = "Baud Rate:";
            this.label_br.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox_stopBits
            // 
            this.comboBox_stopBits.FormattingEnabled = true;
            this.comboBox_stopBits.Items.AddRange(new object[] {
            "No Stop Bits",
            "1 Stop Bit",
            "1.5 Stop Bits",
            "2 Stop Bits"});
            this.comboBox_stopBits.Location = new System.Drawing.Point(294, 30);
            this.comboBox_stopBits.Name = "comboBox_stopBits";
            this.comboBox_stopBits.Size = new System.Drawing.Size(91, 26);
            this.comboBox_stopBits.TabIndex = 22;
            this.comboBox_stopBits.Text = "No Stop Bits";
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Items.AddRange(new object[] {
            "No Parity",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBox_parity.Location = new System.Drawing.Point(197, 30);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(91, 26);
            this.comboBox_parity.TabIndex = 21;
            this.comboBox_parity.Text = "No Parity";
            // 
            // comboBox_bitLength
            // 
            this.comboBox_bitLength.FormattingEnabled = true;
            this.comboBox_bitLength.Items.AddRange(new object[] {
            "7 Bits",
            "8 Bits"});
            this.comboBox_bitLength.Location = new System.Drawing.Point(4, 30);
            this.comboBox_bitLength.Name = "comboBox_bitLength";
            this.comboBox_bitLength.Size = new System.Drawing.Size(91, 26);
            this.comboBox_bitLength.TabIndex = 20;
            this.comboBox_bitLength.Text = "8 Bits";
            // 
            // comboBox_handshake
            // 
            this.comboBox_handshake.FormattingEnabled = true;
            this.comboBox_handshake.Items.AddRange(new object[] {
            "No Handshake",
            "RTS/CTS",
            "XonXoff",
            "RTS+XonXoff"});
            this.comboBox_handshake.Location = new System.Drawing.Point(101, 30);
            this.comboBox_handshake.Name = "comboBox_handshake";
            this.comboBox_handshake.Size = new System.Drawing.Size(91, 26);
            this.comboBox_handshake.TabIndex = 19;
            this.comboBox_handshake.Text = "No Handshake";
            // 
            // timeout_textBox
            // 
            this.timeout_textBox.Location = new System.Drawing.Point(294, 57);
            this.timeout_textBox.Name = "timeout_textBox";
            this.timeout_textBox.Size = new System.Drawing.Size(91, 24);
            this.timeout_textBox.TabIndex = 18;
            this.timeout_textBox.Text = "500";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(196, 60);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(114, 18);
            this.label_to.TabIndex = 17;
            this.label_to.Text = "RX/TX Timeout:";
            this.label_to.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(3, 3);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(91, 23);
            this.button_list.TabIndex = 0;
            this.button_list.Text = "List Devices";
            this.button_list.UseVisualStyleBackColor = true;
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(100, 3);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(91, 26);
            this.comboBox_portName.TabIndex = 4;
            // 
            // comboBox_portSpeed
            // 
            this.comboBox_portSpeed.FormattingEnabled = true;
            this.comboBox_portSpeed.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBox_portSpeed.Location = new System.Drawing.Point(294, 3);
            this.comboBox_portSpeed.Name = "comboBox_portSpeed";
            this.comboBox_portSpeed.Size = new System.Drawing.Size(91, 26);
            this.comboBox_portSpeed.TabIndex = 5;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(3, 57);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(91, 23);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Open Device";
            this.button_open.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(100, 57);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(91, 23);
            this.button_close.TabIndex = 10;
            this.button_close.Text = "Close Device";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // panel_LOGcontrols
            // 
            this.panel_LOGcontrols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_LOGcontrols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LOGcontrols.Controls.Add(this.checkBox_autoLineEnd);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_bin);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_hex);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_text);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_terminalMode);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_pause);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_timeStamps);
            this.panel_LOGcontrols.Controls.Add(this.button_clear);
            this.panel_LOGcontrols.Location = new System.Drawing.Point(1157, 12);
            this.panel_LOGcontrols.Name = "panel_LOGcontrols";
            this.panel_LOGcontrols.Size = new System.Drawing.Size(182, 132);
            this.panel_LOGcontrols.TabIndex = 33;
            // 
            // checkBox_autoLineEnd
            // 
            this.checkBox_autoLineEnd.AutoSize = true;
            this.checkBox_autoLineEnd.Location = new System.Drawing.Point(3, 83);
            this.checkBox_autoLineEnd.Name = "checkBox_autoLineEnd";
            this.checkBox_autoLineEnd.Size = new System.Drawing.Size(114, 22);
            this.checkBox_autoLineEnd.TabIndex = 28;
            this.checkBox_autoLineEnd.Text = "Fix LineEnds";
            this.checkBox_autoLineEnd.UseVisualStyleBackColor = true;
            // 
            // checkBox_bin
            // 
            this.checkBox_bin.AutoSize = true;
            this.checkBox_bin.Location = new System.Drawing.Point(118, 58);
            this.checkBox_bin.Name = "checkBox_bin";
            this.checkBox_bin.Size = new System.Drawing.Size(71, 22);
            this.checkBox_bin.TabIndex = 27;
            this.checkBox_bin.Text = "Binary";
            this.checkBox_bin.UseVisualStyleBackColor = true;
            // 
            // checkBox_hex
            // 
            this.checkBox_hex.AutoSize = true;
            this.checkBox_hex.Location = new System.Drawing.Point(118, 32);
            this.checkBox_hex.Name = "checkBox_hex";
            this.checkBox_hex.Size = new System.Drawing.Size(61, 22);
            this.checkBox_hex.TabIndex = 26;
            this.checkBox_hex.Text = "HEX";
            this.checkBox_hex.UseVisualStyleBackColor = true;
            // 
            // checkBox_text
            // 
            this.checkBox_text.AutoSize = true;
            this.checkBox_text.Checked = true;
            this.checkBox_text.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_text.Location = new System.Drawing.Point(118, 6);
            this.checkBox_text.Name = "checkBox_text";
            this.checkBox_text.Size = new System.Drawing.Size(58, 22);
            this.checkBox_text.TabIndex = 25;
            this.checkBox_text.Text = "Text";
            this.checkBox_text.UseVisualStyleBackColor = true;
            // 
            // checkBox_terminalMode
            // 
            this.checkBox_terminalMode.AutoSize = true;
            this.checkBox_terminalMode.Location = new System.Drawing.Point(3, 58);
            this.checkBox_terminalMode.Name = "checkBox_terminalMode";
            this.checkBox_terminalMode.Size = new System.Drawing.Size(129, 22);
            this.checkBox_terminalMode.TabIndex = 24;
            this.checkBox_terminalMode.Text = "Terminal Mode";
            this.checkBox_terminalMode.UseVisualStyleBackColor = true;
            // 
            // checkBox_pause
            // 
            this.checkBox_pause.AutoSize = true;
            this.checkBox_pause.Location = new System.Drawing.Point(3, 6);
            this.checkBox_pause.Name = "checkBox_pause";
            this.checkBox_pause.Size = new System.Drawing.Size(101, 22);
            this.checkBox_pause.TabIndex = 6;
            this.checkBox_pause.Text = "Pause Log";
            this.checkBox_pause.UseVisualStyleBackColor = true;
            // 
            // checkBox_timeStamps
            // 
            this.checkBox_timeStamps.AutoSize = true;
            this.checkBox_timeStamps.Checked = true;
            this.checkBox_timeStamps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_timeStamps.Location = new System.Drawing.Point(3, 32);
            this.checkBox_timeStamps.Name = "checkBox_timeStamps";
            this.checkBox_timeStamps.Size = new System.Drawing.Size(112, 22);
            this.checkBox_timeStamps.TabIndex = 15;
            this.checkBox_timeStamps.Text = "Timestamps";
            this.checkBox_timeStamps.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(3, 104);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(91, 23);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Clear Log";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // timer_ring
            // 
            this.timer_ring.Tick += new System.EventHandler(this.timer_ring_Tick);
            // 
            // SerialConsoleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1351, 798);
            this.Controls.Add(this.panel_LOGcontrols);
            this.Controls.Add(this.panel_COMcontrols);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_inputType);
            this.Controls.Add(this.comboBox_LE);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_output);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1163, 240);
            this.Name = "SerialConsoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Console - 20250817";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel_COMcontrols.ResumeLayout(false);
            this.panel_COMcontrols.PerformLayout();
            this.panel_LOGcontrols.ResumeLayout(false);
            this.panel_LOGcontrols.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox_output;
        public System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.ComboBox comboBox_LE;
        private System.Windows.Forms.ComboBox comboBox_inputType;
        private System.Windows.Forms.Button button_sendBIN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SendBinChunk_textBox;
        private System.Windows.Forms.TextBox SendBinPause_textBox;
        private System.Windows.Forms.Button button_X;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox_pattern;
        private System.Windows.Forms.TextBox textBox_receivePattern;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_patternDelay;
        private System.Windows.Forms.TextBox textBox_sendPattern;
        private System.Windows.Forms.CheckBox checkBox_sendPattern;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_FTR;
        private System.Windows.Forms.TextBox textBox_HDR;
        private System.Windows.Forms.Button button_Resend;
        private System.Windows.Forms.CheckBox checkBox_sendFTR;
        private System.Windows.Forms.CheckBox checkBox_sendHDR;
        private System.Windows.Forms.Label label_sent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_stopCapture;
        private System.Windows.Forms.Button button_capture;
        private System.Windows.Forms.Label label_received;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel panel_COMcontrols;
        private System.Windows.Forms.Label label_ring;
        private System.Windows.Forms.CheckBox checkBox_BH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_DSRH;
        private System.Windows.Forms.CheckBox checkBox_CTSH;
        private System.Windows.Forms.Label label_ls;
        private System.Windows.Forms.CheckBox checkBox_CDH;
        private System.Windows.Forms.CheckBox checkBox_RTSenable;
        private System.Windows.Forms.CheckBox checkBox_DTRenable;
        private System.Windows.Forms.Label label_br;
        private System.Windows.Forms.ComboBox comboBox_stopBits;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.ComboBox comboBox_bitLength;
        private System.Windows.Forms.ComboBox comboBox_handshake;
        private System.Windows.Forms.TextBox timeout_textBox;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.ComboBox comboBox_portSpeed;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel_LOGcontrols;
        private System.Windows.Forms.CheckBox checkBox_autoLineEnd;
        private System.Windows.Forms.CheckBox checkBox_bin;
        private System.Windows.Forms.CheckBox checkBox_hex;
        private System.Windows.Forms.CheckBox checkBox_text;
        private System.Windows.Forms.CheckBox checkBox_terminalMode;
        private System.Windows.Forms.CheckBox checkBox_pause;
        private System.Windows.Forms.CheckBox checkBox_timeStamps;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Timer timer_ring;
    }
}

