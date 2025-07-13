
namespace SerialBase
{
    partial class SerialBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialBaseForm));
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
            this.comboBox_lineEnding = new System.Windows.Forms.ComboBox();
            this.comboBox_inputType = new System.Windows.Forms.ComboBox();
            this.checkBox_timeStamps = new System.Windows.Forms.CheckBox();
            this.panel_COMcontrols = new System.Windows.Forms.Panel();
            this.label_ring = new System.Windows.Forms.Label();
            this.checkBox_BH = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel_LOGcontrols = new System.Windows.Forms.Panel();
            this.checkBox_bin = new System.Windows.Forms.CheckBox();
            this.checkBox_hex = new System.Windows.Forms.CheckBox();
            this.checkBox_text = new System.Windows.Forms.CheckBox();
            this.checkBox_terminalMode = new System.Windows.Forms.CheckBox();
            this.timer_COMstatus = new System.Windows.Forms.Timer(this.components);
            this.timer_ring = new System.Windows.Forms.Timer(this.components);
            this.panel_COMcontrols.SuspendLayout();
            this.panel_LOGcontrols.SuspendLayout();
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
            this.textBox_output.Size = new System.Drawing.Size(1044, 609);
            this.textBox_output.TabIndex = 2;
            this.textBox_output.Text = resources.GetString("textBox_output.Text");
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(3, 104);
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
            this.checkBox_pause.AutoSize = true;
            this.checkBox_pause.Location = new System.Drawing.Point(3, 6);
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
            this.textBox_input.Size = new System.Drawing.Size(779, 26);
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
            this.button_send.Location = new System.Drawing.Point(991, 765);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(64, 26);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // comboBox_lineEnding
            // 
            this.comboBox_lineEnding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_lineEnding.FormattingEnabled = true;
            this.comboBox_lineEnding.ItemHeight = 15;
            this.comboBox_lineEnding.Items.AddRange(new object[] {
            "Add CR+LF (0x0D 0x0A) Windows \\r\\n",
            "Add LF (0x0A) Linux \\n",
            "No Line Ending"});
            this.comboBox_lineEnding.Location = new System.Drawing.Point(848, 767);
            this.comboBox_lineEnding.Name = "comboBox_lineEnding";
            this.comboBox_lineEnding.Size = new System.Drawing.Size(137, 23);
            this.comboBox_lineEnding.TabIndex = 12;
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
            this.checkBox_timeStamps.AutoSize = true;
            this.checkBox_timeStamps.Checked = true;
            this.checkBox_timeStamps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_timeStamps.Location = new System.Drawing.Point(3, 32);
            this.checkBox_timeStamps.Name = "checkBox_timeStamps";
            this.checkBox_timeStamps.Size = new System.Drawing.Size(94, 19);
            this.checkBox_timeStamps.TabIndex = 15;
            this.checkBox_timeStamps.Text = "Timestamps";
            this.checkBox_timeStamps.UseVisualStyleBackColor = true;
            // 
            // panel_COMcontrols
            // 
            this.panel_COMcontrols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_COMcontrols.Controls.Add(this.label_ring);
            this.panel_COMcontrols.Controls.Add(this.checkBox_BH);
            this.panel_COMcontrols.Controls.Add(this.label1);
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
            this.panel_COMcontrols.Location = new System.Drawing.Point(12, 12);
            this.panel_COMcontrols.Name = "panel_COMcontrols";
            this.panel_COMcontrols.Size = new System.Drawing.Size(393, 132);
            this.panel_COMcontrols.TabIndex = 19;
            // 
            // label_ring
            // 
            this.label_ring.AutoSize = true;
            this.label_ring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ring.ForeColor = System.Drawing.Color.Red;
            this.label_ring.Location = new System.Drawing.Point(346, 85);
            this.label_ring.Name = "label_ring";
            this.label_ring.Size = new System.Drawing.Size(41, 15);
            this.label_ring.TabIndex = 32;
            this.label_ring.Text = "RING";
            this.label_ring.Visible = false;
            // 
            // checkBox_BH
            // 
            this.checkBox_BH.AutoSize = true;
            this.checkBox_BH.Location = new System.Drawing.Point(331, 107);
            this.checkBox_BH.Name = "checkBox_BH";
            this.checkBox_BH.Size = new System.Drawing.Size(58, 19);
            this.checkBox_BH.TabIndex = 31;
            this.checkBox_BH.Text = "Break";
            this.checkBox_BH.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Control Lines:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox_DSRH
            // 
            this.checkBox_DSRH.AutoSize = true;
            this.checkBox_DSRH.Location = new System.Drawing.Point(244, 107);
            this.checkBox_DSRH.Name = "checkBox_DSRH";
            this.checkBox_DSRH.Size = new System.Drawing.Size(81, 19);
            this.checkBox_DSRH.TabIndex = 29;
            this.checkBox_DSRH.Text = "DSR Hold";
            this.checkBox_DSRH.UseVisualStyleBackColor = true;
            // 
            // checkBox_CTSH
            // 
            this.checkBox_CTSH.AutoSize = true;
            this.checkBox_CTSH.Location = new System.Drawing.Point(164, 107);
            this.checkBox_CTSH.Name = "checkBox_CTSH";
            this.checkBox_CTSH.Size = new System.Drawing.Size(78, 19);
            this.checkBox_CTSH.TabIndex = 28;
            this.checkBox_CTSH.Text = "CTS Hold";
            this.checkBox_CTSH.UseVisualStyleBackColor = true;
            // 
            // label_ls
            // 
            this.label_ls.AutoSize = true;
            this.label_ls.Location = new System.Drawing.Point(8, 108);
            this.label_ls.Name = "label_ls";
            this.label_ls.Size = new System.Drawing.Size(77, 15);
            this.label_ls.TabIndex = 27;
            this.label_ls.Text = "Lines Status:";
            this.label_ls.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox_CDH
            // 
            this.checkBox_CDH.AutoSize = true;
            this.checkBox_CDH.Location = new System.Drawing.Point(86, 107);
            this.checkBox_CDH.Name = "checkBox_CDH";
            this.checkBox_CDH.Size = new System.Drawing.Size(72, 19);
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
            this.checkBox_RTSenable.Size = new System.Drawing.Size(50, 19);
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
            this.checkBox_DTRenable.Size = new System.Drawing.Size(51, 19);
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
            this.label_br.Size = new System.Drawing.Size(68, 15);
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
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(196, 60);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(93, 15);
            this.label_to.TabIndex = 17;
            this.label_to.Text = "RX/TX Timeout:";
            this.label_to.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel_LOGcontrols
            // 
            this.panel_LOGcontrols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LOGcontrols.Controls.Add(this.checkBox_bin);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_hex);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_text);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_terminalMode);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_pause);
            this.panel_LOGcontrols.Controls.Add(this.checkBox_timeStamps);
            this.panel_LOGcontrols.Controls.Add(this.button_clear);
            this.panel_LOGcontrols.Location = new System.Drawing.Point(411, 12);
            this.panel_LOGcontrols.Name = "panel_LOGcontrols";
            this.panel_LOGcontrols.Size = new System.Drawing.Size(182, 132);
            this.panel_LOGcontrols.TabIndex = 20;
            // 
            // checkBox_bin
            // 
            this.checkBox_bin.AutoSize = true;
            this.checkBox_bin.Location = new System.Drawing.Point(118, 58);
            this.checkBox_bin.Name = "checkBox_bin";
            this.checkBox_bin.Size = new System.Drawing.Size(60, 19);
            this.checkBox_bin.TabIndex = 27;
            this.checkBox_bin.Text = "Binary";
            this.checkBox_bin.UseVisualStyleBackColor = true;
            // 
            // checkBox_hex
            // 
            this.checkBox_hex.AutoSize = true;
            this.checkBox_hex.Location = new System.Drawing.Point(118, 32);
            this.checkBox_hex.Name = "checkBox_hex";
            this.checkBox_hex.Size = new System.Drawing.Size(51, 19);
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
            this.checkBox_text.Size = new System.Drawing.Size(49, 19);
            this.checkBox_text.TabIndex = 25;
            this.checkBox_text.Text = "Text";
            this.checkBox_text.UseVisualStyleBackColor = true;
            // 
            // checkBox_terminalMode
            // 
            this.checkBox_terminalMode.AutoSize = true;
            this.checkBox_terminalMode.Location = new System.Drawing.Point(3, 58);
            this.checkBox_terminalMode.Name = "checkBox_terminalMode";
            this.checkBox_terminalMode.Size = new System.Drawing.Size(110, 19);
            this.checkBox_terminalMode.TabIndex = 24;
            this.checkBox_terminalMode.Text = "Terminal Mode";
            this.checkBox_terminalMode.UseVisualStyleBackColor = true;
            // 
            // timer_COMstatus
            // 
            this.timer_COMstatus.Enabled = true;
            this.timer_COMstatus.Tick += new System.EventHandler(this.timer_Status_Tick);
            // 
            // timer_ring
            // 
            this.timer_ring.Interval = 1000;
            this.timer_ring.Tick += new System.EventHandler(this.timer_ring_Tick);
            // 
            // SerialBaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 798);
            this.Controls.Add(this.panel_LOGcontrols);
            this.Controls.Add(this.panel_COMcontrols);
            this.Controls.Add(this.comboBox_inputType);
            this.Controls.Add(this.comboBox_lineEnding);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_output);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(620, 240);
            this.Name = "SerialBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM Port Base - 20250712";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_COMcontrols.ResumeLayout(false);
            this.panel_COMcontrols.PerformLayout();
            this.panel_LOGcontrols.ResumeLayout(false);
            this.panel_LOGcontrols.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox_lineEnding;
        private System.Windows.Forms.ComboBox comboBox_inputType;
        private System.Windows.Forms.CheckBox checkBox_timeStamps;
        private System.Windows.Forms.Panel panel_COMcontrols;
        private System.Windows.Forms.Panel panel_LOGcontrols;
        private System.Windows.Forms.TextBox timeout_textBox;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.ComboBox comboBox_bitLength;
        private System.Windows.Forms.ComboBox comboBox_handshake;
        private System.Windows.Forms.ComboBox comboBox_stopBits;
        private System.Windows.Forms.Label label_br;
        private System.Windows.Forms.Timer timer_COMstatus;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.CheckBox checkBox_DTRenable;
        private System.Windows.Forms.CheckBox checkBox_RTSenable;
        private System.Windows.Forms.CheckBox checkBox_terminalMode;
        private System.Windows.Forms.CheckBox checkBox_bin;
        private System.Windows.Forms.CheckBox checkBox_hex;
        private System.Windows.Forms.CheckBox checkBox_text;
        private System.Windows.Forms.CheckBox checkBox_CDH;
        private System.Windows.Forms.CheckBox checkBox_DSRH;
        private System.Windows.Forms.CheckBox checkBox_CTSH;
        private System.Windows.Forms.Label label_ls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_BH;
        private System.Windows.Forms.Label label_ring;
        private System.Windows.Forms.Timer timer_ring;
    }
}

