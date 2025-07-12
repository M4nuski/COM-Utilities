
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
            this.button_list = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.comboBox_portSpeed = new System.Windows.Forms.ComboBox();
            this.checkBox_pause = new System.Windows.Forms.CheckBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.comboBox_LE = new System.Windows.Forms.ComboBox();
            this.comboBox_Format = new System.Windows.Forms.ComboBox();
            this.comboBox_inputType = new System.Windows.Forms.ComboBox();
            this.checkBox_timeStamps = new System.Windows.Forms.CheckBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxRTSenable = new System.Windows.Forms.CheckBox();
            this.label_lineStatus = new System.Windows.Forms.Label();
            this.checkBoxDTRenable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_stopBits = new System.Windows.Forms.ComboBox();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.comboBox_bitLength = new System.Windows.Forms.ComboBox();
            this.comboBox_handshake = new System.Windows.Forms.ComboBox();
            this.timeout_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxTerminalMode = new System.Windows.Forms.CheckBox();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(3, 3);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(91, 23);
            this.button_list.TabIndex = 0;
            this.button_list.Text = "List Devices";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(3, 57);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(91, 23);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Open Device";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
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
            this.textBox_output.Size = new System.Drawing.Size(1236, 609);
            this.textBox_output.TabIndex = 2;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(157, 3);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(91, 23);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Clear Log";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(100, 3);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(91, 23);
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
            this.comboBox_portSpeed.Size = new System.Drawing.Size(91, 23);
            this.comboBox_portSpeed.TabIndex = 5;
            // 
            // checkBox_pause
            // 
            this.checkBox_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_pause.AutoSize = true;
            this.checkBox_pause.Location = new System.Drawing.Point(158, 31);
            this.checkBox_pause.Name = "checkBox_pause";
            this.checkBox_pause.Size = new System.Drawing.Size(85, 19);
            this.checkBox_pause.TabIndex = 6;
            this.checkBox_pause.Text = "Pause Log";
            this.checkBox_pause.UseVisualStyleBackColor = true;
            // 
            // textBox_input
            // 
            this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_input.Location = new System.Drawing.Point(63, 765);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_input.Size = new System.Drawing.Size(971, 26);
            this.textBox_input.TabIndex = 9;
            this.textBox_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyDown);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(100, 57);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(91, 23);
            this.button_close.TabIndex = 10;
            this.button_close.Text = "Close Device";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.Location = new System.Drawing.Point(1183, 765);
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
            this.comboBox_LE.ItemHeight = 15;
            this.comboBox_LE.Items.AddRange(new object[] {
            "Add CR+LF (0x0D 0x0A) Windows \\r\\n",
            "Add LF (0x0A) Linux \\n",
            "No Line Ending"});
            this.comboBox_LE.Location = new System.Drawing.Point(1040, 767);
            this.comboBox_LE.Name = "comboBox_LE";
            this.comboBox_LE.Size = new System.Drawing.Size(137, 23);
            this.comboBox_LE.TabIndex = 12;
            // 
            // comboBox_Format
            // 
            this.comboBox_Format.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Format.FormattingEnabled = true;
            this.comboBox_Format.Items.AddRange(new object[] {
            "Text Only",
            "Hex + Text",
            "Binary + Hex",
            "Binary + Text",
            "Binary + Hex + Text"});
            this.comboBox_Format.Location = new System.Drawing.Point(3, 2);
            this.comboBox_Format.Name = "comboBox_Format";
            this.comboBox_Format.Size = new System.Drawing.Size(143, 23);
            this.comboBox_Format.TabIndex = 13;
            this.comboBox_Format.SelectedIndexChanged += new System.EventHandler(this.comboBox_Format_SelectedIndexChanged);
            // 
            // comboBox_inputType
            // 
            this.comboBox_inputType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_inputType.FormattingEnabled = true;
            this.comboBox_inputType.IntegralHeight = false;
            this.comboBox_inputType.ItemHeight = 15;
            this.comboBox_inputType.Items.AddRange(new object[] {
            "Text",
            "HEX"});
            this.comboBox_inputType.Location = new System.Drawing.Point(10, 766);
            this.comboBox_inputType.Name = "comboBox_inputType";
            this.comboBox_inputType.Size = new System.Drawing.Size(47, 23);
            this.comboBox_inputType.TabIndex = 14;
            this.comboBox_inputType.Text = "Text";
            // 
            // checkBox_timeStamps
            // 
            this.checkBox_timeStamps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_timeStamps.AutoSize = true;
            this.checkBox_timeStamps.Checked = true;
            this.checkBox_timeStamps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_timeStamps.Location = new System.Drawing.Point(6, 31);
            this.checkBox_timeStamps.Name = "checkBox_timeStamps";
            this.checkBox_timeStamps.Size = new System.Drawing.Size(94, 19);
            this.checkBox_timeStamps.TabIndex = 15;
            this.checkBox_timeStamps.Text = "Timestamps";
            this.checkBox_timeStamps.UseVisualStyleBackColor = true;
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
            this.checkBox_sendFTR.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sendFTR.TabIndex = 28;
            this.checkBox_sendFTR.UseVisualStyleBackColor = true;
            // 
            // checkBox_sendHDR
            // 
            this.checkBox_sendHDR.AutoSize = true;
            this.checkBox_sendHDR.Location = new System.Drawing.Point(84, 58);
            this.checkBox_sendHDR.Name = "checkBox_sendHDR";
            this.checkBox_sendHDR.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sendHDR.TabIndex = 27;
            this.checkBox_sendHDR.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Footer:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Header:";
            // 
            // textBox_FTR
            // 
            this.textBox_FTR.Location = new System.Drawing.Point(155, 80);
            this.textBox_FTR.Name = "textBox_FTR";
            this.textBox_FTR.Size = new System.Drawing.Size(91, 21);
            this.textBox_FTR.TabIndex = 24;
            this.textBox_FTR.Text = "1A";
            // 
            // textBox_HDR
            // 
            this.textBox_HDR.Location = new System.Drawing.Point(155, 54);
            this.textBox_HDR.Name = "textBox_HDR";
            this.textBox_HDR.Size = new System.Drawing.Size(91, 21);
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
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chunk Delay (ms):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chunk Size:";
            // 
            // SendBinChunk_textBox
            // 
            this.SendBinChunk_textBox.Location = new System.Drawing.Point(155, 3);
            this.SendBinChunk_textBox.Name = "SendBinChunk_textBox";
            this.SendBinChunk_textBox.Size = new System.Drawing.Size(91, 21);
            this.SendBinChunk_textBox.TabIndex = 19;
            this.SendBinChunk_textBox.Text = "256";
            // 
            // SendBinPause_textBox
            // 
            this.SendBinPause_textBox.Location = new System.Drawing.Point(155, 28);
            this.SendBinPause_textBox.Name = "SendBinPause_textBox";
            this.SendBinPause_textBox.Size = new System.Drawing.Size(91, 21);
            this.SendBinPause_textBox.TabIndex = 18;
            this.SendBinPause_textBox.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBoxRTSenable);
            this.panel2.Controls.Add(this.label_lineStatus);
            this.panel2.Controls.Add(this.checkBoxDTRenable);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox_stopBits);
            this.panel2.Controls.Add(this.comboBox_parity);
            this.panel2.Controls.Add(this.comboBox_bitLength);
            this.panel2.Controls.Add(this.comboBox_handshake);
            this.panel2.Controls.Add(this.timeout_textBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_list);
            this.panel2.Controls.Add(this.comboBox_portName);
            this.panel2.Controls.Add(this.comboBox_portSpeed);
            this.panel2.Controls.Add(this.button_open);
            this.panel2.Controls.Add(this.button_close);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 132);
            this.panel2.TabIndex = 19;
            // 
            // checkBoxRTSenable
            // 
            this.checkBoxRTSenable.AutoSize = true;
            this.checkBoxRTSenable.Checked = true;
            this.checkBoxRTSenable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRTSenable.Location = new System.Drawing.Point(71, 84);
            this.checkBoxRTSenable.Name = "checkBoxRTSenable";
            this.checkBoxRTSenable.Size = new System.Drawing.Size(50, 19);
            this.checkBoxRTSenable.TabIndex = 25;
            this.checkBoxRTSenable.Text = "RTS";
            this.checkBoxRTSenable.UseVisualStyleBackColor = true;
            this.checkBoxRTSenable.CheckedChanged += new System.EventHandler(this.checkBoxDTRenable_CheckedChanged);
            // 
            // label_lineStatus
            // 
            this.label_lineStatus.Location = new System.Drawing.Point(1, 109);
            this.label_lineStatus.Name = "label_lineStatus";
            this.label_lineStatus.Size = new System.Drawing.Size(384, 18);
            this.label_lineStatus.TabIndex = 23;
            this.label_lineStatus.Text = "Lines Status";
            // 
            // checkBoxDTRenable
            // 
            this.checkBoxDTRenable.AutoSize = true;
            this.checkBoxDTRenable.Checked = true;
            this.checkBoxDTRenable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDTRenable.Location = new System.Drawing.Point(4, 84);
            this.checkBoxDTRenable.Name = "checkBoxDTRenable";
            this.checkBoxDTRenable.Size = new System.Drawing.Size(51, 19);
            this.checkBoxDTRenable.TabIndex = 24;
            this.checkBoxDTRenable.Text = "DTR";
            this.checkBoxDTRenable.UseVisualStyleBackColor = true;
            this.checkBoxDTRenable.CheckedChanged += new System.EventHandler(this.checkBoxDTRenable_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Baud Rate:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.comboBox_stopBits.Size = new System.Drawing.Size(91, 23);
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
            this.comboBox_parity.Size = new System.Drawing.Size(91, 23);
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
            this.comboBox_bitLength.Size = new System.Drawing.Size(91, 23);
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
            this.comboBox_handshake.Size = new System.Drawing.Size(91, 23);
            this.comboBox_handshake.TabIndex = 19;
            this.comboBox_handshake.Text = "No Handshake";
            // 
            // timeout_textBox
            // 
            this.timeout_textBox.Location = new System.Drawing.Point(294, 57);
            this.timeout_textBox.Name = "timeout_textBox";
            this.timeout_textBox.Size = new System.Drawing.Size(91, 21);
            this.timeout_textBox.TabIndex = 18;
            this.timeout_textBox.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "RX/TX Timeout:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBoxTerminalMode);
            this.panel3.Controls.Add(this.checkBox_pause);
            this.panel3.Controls.Add(this.checkBox_timeStamps);
            this.panel3.Controls.Add(this.comboBox_Format);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Location = new System.Drawing.Point(993, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 76);
            this.panel3.TabIndex = 20;
            // 
            // checkBoxTerminalMode
            // 
            this.checkBoxTerminalMode.AutoSize = true;
            this.checkBoxTerminalMode.Location = new System.Drawing.Point(6, 51);
            this.checkBoxTerminalMode.Name = "checkBoxTerminalMode";
            this.checkBoxTerminalMode.Size = new System.Drawing.Size(110, 19);
            this.checkBoxTerminalMode.TabIndex = 24;
            this.checkBoxTerminalMode.Text = "Terminal Mode";
            this.checkBoxTerminalMode.UseVisualStyleBackColor = true;
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
            this.panel4.Size = new System.Drawing.Size(206, 117);
            this.panel4.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
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
            this.comboBox_pattern.Size = new System.Drawing.Size(91, 23);
            this.comboBox_pattern.TabIndex = 23;
            this.comboBox_pattern.Text = "Once";
            // 
            // textBox_receivePattern
            // 
            this.textBox_receivePattern.Location = new System.Drawing.Point(74, 84);
            this.textBox_receivePattern.Name = "textBox_receivePattern";
            this.textBox_receivePattern.Size = new System.Drawing.Size(124, 21);
            this.textBox_receivePattern.TabIndex = 22;
            this.textBox_receivePattern.Text = "FF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Repeat Delay (ms):";
            // 
            // textBox_patternDelay
            // 
            this.textBox_patternDelay.Location = new System.Drawing.Point(121, 59);
            this.textBox_patternDelay.Name = "textBox_patternDelay";
            this.textBox_patternDelay.Size = new System.Drawing.Size(77, 21);
            this.textBox_patternDelay.TabIndex = 20;
            this.textBox_patternDelay.Text = "50";
            // 
            // textBox_sendPattern
            // 
            this.textBox_sendPattern.Location = new System.Drawing.Point(5, 34);
            this.textBox_sendPattern.Name = "textBox_sendPattern";
            this.textBox_sendPattern.Size = new System.Drawing.Size(193, 21);
            this.textBox_sendPattern.TabIndex = 1;
            this.textBox_sendPattern.Text = "AA AA AA AA 00 01 0D 0A";
            // 
            // checkBox_sendPattern
            // 
            this.checkBox_sendPattern.AutoSize = true;
            this.checkBox_sendPattern.Location = new System.Drawing.Point(5, 8);
            this.checkBox_sendPattern.Name = "checkBox_sendPattern";
            this.checkBox_sendPattern.Size = new System.Drawing.Size(97, 19);
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
            this.panel5.Location = new System.Drawing.Point(993, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 51);
            this.panel5.TabIndex = 22;
            // 
            // button_stopCapture
            // 
            this.button_stopCapture.Location = new System.Drawing.Point(157, 3);
            this.button_stopCapture.Name = "button_stopCapture";
            this.button_stopCapture.Size = new System.Drawing.Size(91, 23);
            this.button_stopCapture.TabIndex = 32;
            this.button_stopCapture.Text = "Stop";
            this.button_stopCapture.UseVisualStyleBackColor = true;
            this.button_stopCapture.Click += new System.EventHandler(this.button_stopCapture_Click);
            // 
            // button_capture
            // 
            this.button_capture.Location = new System.Drawing.Point(7, 3);
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
            this.label_received.Location = new System.Drawing.Point(8, 28);
            this.label_received.Name = "label_received";
            this.label_received.Size = new System.Drawing.Size(240, 22);
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
            // SerialConsoleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1256, 798);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.Text = "COM Port Console - 20250711";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.ComboBox comboBox_portSpeed;
        private System.Windows.Forms.CheckBox checkBox_pause;
        public System.Windows.Forms.TextBox textBox_output;
        public System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.ComboBox comboBox_LE;
        private System.Windows.Forms.ComboBox comboBox_Format;
        private System.Windows.Forms.ComboBox comboBox_inputType;
        private System.Windows.Forms.CheckBox checkBox_timeStamps;
        private System.Windows.Forms.Button button_sendBIN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SendBinChunk_textBox;
        private System.Windows.Forms.TextBox SendBinPause_textBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox timeout_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.ComboBox comboBox_bitLength;
        private System.Windows.Forms.ComboBox comboBox_handshake;
        private System.Windows.Forms.ComboBox comboBox_stopBits;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label_lineStatus;
        private System.Windows.Forms.CheckBox checkBoxDTRenable;
        private System.Windows.Forms.CheckBox checkBoxRTSenable;
        private System.Windows.Forms.CheckBox checkBoxTerminalMode;
    }
}

