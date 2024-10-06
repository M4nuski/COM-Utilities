
namespace SerialReader
{
    partial class SerialReaderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.checkbox_timestamps = new System.Windows.Forms.CheckBox();
            this.checkBox_CTS = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(12, 12);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(123, 23);
            this.button_list.TabIndex = 0;
            this.button_list.Text = "List Devices";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(395, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(123, 23);
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
            this.textBox_output.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_output.Location = new System.Drawing.Point(12, 41);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_output.Size = new System.Drawing.Size(1110, 692);
            this.textBox_output.TabIndex = 2;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(999, 12);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(123, 23);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(141, 12);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(89, 23);
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
            "19200",
            "57600",
            "115200"});
            this.comboBox_portSpeed.Location = new System.Drawing.Point(236, 12);
            this.comboBox_portSpeed.Name = "comboBox_portSpeed";
            this.comboBox_portSpeed.Size = new System.Drawing.Size(89, 23);
            this.comboBox_portSpeed.TabIndex = 5;
            this.comboBox_portSpeed.Text = "9600";
            // 
            // checkBox_pause
            // 
            this.checkBox_pause.AutoSize = true;
            this.checkBox_pause.Location = new System.Drawing.Point(653, 16);
            this.checkBox_pause.Name = "checkBox_pause";
            this.checkBox_pause.Size = new System.Drawing.Size(88, 19);
            this.checkBox_pause.TabIndex = 6;
            this.checkBox_pause.Text = "Pause Input";
            this.checkBox_pause.UseVisualStyleBackColor = true;
            // 
            // textBox_input
            // 
            this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_input.Location = new System.Drawing.Point(12, 739);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_input.Size = new System.Drawing.Size(816, 26);
            this.textBox_input.TabIndex = 9;
            this.textBox_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyDown);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(524, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(123, 23);
            this.button_close.TabIndex = 10;
            this.button_close.Text = "Close Device";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.Location = new System.Drawing.Point(999, 741);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(123, 23);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // comboBox_LE
            // 
            this.comboBox_LE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_LE.FormattingEnabled = true;
            this.comboBox_LE.Items.AddRange(new object[] {
            "Add CR+LF (0x0D 0x0A)",
            "Add CR (0x0D)",
            "Add LF (0X0A)",
            "No Line Ending"});
            this.comboBox_LE.Location = new System.Drawing.Point(834, 741);
            this.comboBox_LE.Name = "comboBox_LE";
            this.comboBox_LE.Size = new System.Drawing.Size(159, 23);
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
            this.comboBox_Format.Location = new System.Drawing.Point(834, 12);
            this.comboBox_Format.Name = "comboBox_Format";
            this.comboBox_Format.Size = new System.Drawing.Size(159, 23);
            this.comboBox_Format.TabIndex = 13;
            this.comboBox_Format.SelectedIndexChanged += new System.EventHandler(this.comboBox_Format_SelectedIndexChanged);
            // 
            // checkbox_timestamps
            // 
            this.checkbox_timestamps.AutoSize = true;
            this.checkbox_timestamps.Location = new System.Drawing.Point(740, 16);
            this.checkbox_timestamps.Name = "checkbox_timestamps";
            this.checkbox_timestamps.Size = new System.Drawing.Size(90, 19);
            this.checkbox_timestamps.TabIndex = 14;
            this.checkbox_timestamps.Text = "Timestamps";
            this.checkbox_timestamps.UseVisualStyleBackColor = true;
            // 
            // checkBox_CTS
            // 
            this.checkBox_CTS.AutoSize = true;
            this.checkBox_CTS.Location = new System.Drawing.Point(331, 14);
            this.checkBox_CTS.Name = "checkBox_CTS";
            this.checkBox_CTS.Size = new System.Drawing.Size(46, 19);
            this.checkBox_CTS.TabIndex = 15;
            this.checkBox_CTS.Text = "CTS";
            this.checkBox_CTS.UseVisualStyleBackColor = true;
            this.checkBox_CTS.CheckedChanged += new System.EventHandler(this.checkBox_CTS_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 777);
            this.Controls.Add(this.checkBox_CTS);
            this.Controls.Add(this.checkbox_timestamps);
            this.Controls.Add(this.comboBox_Format);
            this.Controls.Add(this.comboBox_LE);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.checkBox_pause);
            this.Controls.Add(this.comboBox_portSpeed);
            this.Controls.Add(this.comboBox_portName);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_list);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM Port Data Reader - 20240706";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.CheckBox checkbox_timestamps;
        private System.Windows.Forms.CheckBox checkBox_CTS;
    }
}

