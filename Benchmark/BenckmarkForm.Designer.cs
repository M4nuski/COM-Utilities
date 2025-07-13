
namespace Benchmark
{
    partial class BenckmarkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox_CTS = new System.Windows.Forms.CheckBox();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBox_portSpeed = new System.Windows.Forms.ComboBox();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_list = new System.Windows.Forms.Button();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.packetSize_comboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputrate_button = new System.Windows.Forms.Button();
            this.loopback_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_CTS
            // 
            this.checkBox_CTS.AutoSize = true;
            this.checkBox_CTS.Location = new System.Drawing.Point(341, 14);
            this.checkBox_CTS.Name = "checkBox_CTS";
            this.checkBox_CTS.Size = new System.Drawing.Size(47, 17);
            this.checkBox_CTS.TabIndex = 22;
            this.checkBox_CTS.Text = "CTS";
            this.checkBox_CTS.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(507, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(105, 23);
            this.button_close.TabIndex = 21;
            this.button_close.Text = "Close Device";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
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
            "28800",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600",
            "1843200",
            "3686400"});
            this.comboBox_portSpeed.Location = new System.Drawing.Point(232, 12);
            this.comboBox_portSpeed.Name = "comboBox_portSpeed";
            this.comboBox_portSpeed.Size = new System.Drawing.Size(104, 21);
            this.comboBox_portSpeed.TabIndex = 20;
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(123, 12);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(104, 21);
            this.comboBox_portName.TabIndex = 19;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(396, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(105, 23);
            this.button_open.TabIndex = 18;
            this.button_open.Text = "Open Device";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(12, 12);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(105, 23);
            this.button_list.TabIndex = 17;
            this.button_list.Text = "List Devices";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_output.Location = new System.Drawing.Point(12, 150);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_output.Size = new System.Drawing.Size(1056, 570);
            this.textBox_output.TabIndex = 23;
            // 
            // packetSize_comboBox
            // 
            this.packetSize_comboBox.FormattingEnabled = true;
            this.packetSize_comboBox.Items.AddRange(new object[] {
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768",
            "65536"});
            this.packetSize_comboBox.Location = new System.Drawing.Point(218, 111);
            this.packetSize_comboBox.Name = "packetSize_comboBox";
            this.packetSize_comboBox.Size = new System.Drawing.Size(104, 21);
            this.packetSize_comboBox.TabIndex = 25;
            this.packetSize_comboBox.SelectedIndexChanged += new System.EventHandler(this.packetSize_comboBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "10";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputrate_button
            // 
            this.inputrate_button.Location = new System.Drawing.Point(12, 85);
            this.inputrate_button.Name = "inputrate_button";
            this.inputrate_button.Size = new System.Drawing.Size(133, 23);
            this.inputrate_button.TabIndex = 28;
            this.inputrate_button.Text = "Mesure Input Rate";
            this.inputrate_button.UseVisualStyleBackColor = true;
            this.inputrate_button.Click += new System.EventHandler(this.inputrate_button_Click);
            // 
            // loopback_button
            // 
            this.loopback_button.Location = new System.Drawing.Point(12, 111);
            this.loopback_button.Name = "loopback_button";
            this.loopback_button.Size = new System.Drawing.Size(133, 23);
            this.loopback_button.TabIndex = 29;
            this.loopback_button.Text = "Mesure Loopback Rate";
            this.loopback_button.UseVisualStyleBackColor = true;
            this.loopback_button.Click += new System.EventHandler(this.loopback_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(12, 56);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(133, 23);
            this.cancel_button.TabIndex = 30;
            this.cancel_button.Text = "Stop / Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chunk Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Duration (s):";
            // 
            // BenckmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 732);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.loopback_button);
            this.Controls.Add(this.inputrate_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.packetSize_comboBox);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.checkBox_CTS);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.comboBox_portSpeed);
            this.Controls.Add(this.comboBox_portName);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_list);
            this.Name = "BenckmarkForm";
            this.Text = "COM port benchmarking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BenckmarkForm_FormClosing);
            this.Load += new System.EventHandler(this.BenckmarkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_CTS;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ComboBox comboBox_portSpeed;
        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_list;
        public System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.ComboBox packetSize_comboBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button inputrate_button;
        private System.Windows.Forms.Button loopback_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

