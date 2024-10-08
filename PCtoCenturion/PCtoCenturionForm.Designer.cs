
namespace PCtoCenturion
{
    partial class PCtoCenturionForm
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
            this.button_loadFile = new System.Windows.Forms.Button();
            this.button_sendFile = new System.Windows.Forms.Button();
            this.button_abortSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_sector = new System.Windows.Forms.Label();
            this.ignoreCRC_checkBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_CTS
            // 
            this.checkBox_CTS.AutoSize = true;
            this.checkBox_CTS.Checked = true;
            this.checkBox_CTS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CTS.Location = new System.Drawing.Point(343, 16);
            this.checkBox_CTS.Name = "checkBox_CTS";
            this.checkBox_CTS.Size = new System.Drawing.Size(47, 17);
            this.checkBox_CTS.TabIndex = 22;
            this.checkBox_CTS.Text = "CTS";
            this.checkBox_CTS.UseVisualStyleBackColor = true;
            this.checkBox_CTS.CheckedChanged += new System.EventHandler(this.checkBox_CTS_CheckedChanged);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(486, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(84, 23);
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
            "57600",
            "115200"});
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
            this.button_open.Size = new System.Drawing.Size(84, 23);
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
            this.button_list.Text = "List COM Devices";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_output.Location = new System.Drawing.Point(12, 43);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_output.Size = new System.Drawing.Size(1049, 699);
            this.textBox_output.TabIndex = 23;
            // 
            // button_loadFile
            // 
            this.button_loadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_loadFile.Location = new System.Drawing.Point(797, 12);
            this.button_loadFile.Name = "button_loadFile";
            this.button_loadFile.Size = new System.Drawing.Size(84, 23);
            this.button_loadFile.TabIndex = 24;
            this.button_loadFile.Text = "Load data file";
            this.button_loadFile.UseVisualStyleBackColor = true;
            this.button_loadFile.Click += new System.EventHandler(this.button_loadFile_Click);
            // 
            // button_sendFile
            // 
            this.button_sendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sendFile.Location = new System.Drawing.Point(887, 12);
            this.button_sendFile.Name = "button_sendFile";
            this.button_sendFile.Size = new System.Drawing.Size(84, 23);
            this.button_sendFile.TabIndex = 25;
            this.button_sendFile.Text = "Begin Send";
            this.button_sendFile.UseVisualStyleBackColor = true;
            this.button_sendFile.Click += new System.EventHandler(this.button_sendFile_Click);
            // 
            // button_abortSend
            // 
            this.button_abortSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_abortSend.Location = new System.Drawing.Point(977, 12);
            this.button_abortSend.Name = "button_abortSend";
            this.button_abortSend.Size = new System.Drawing.Size(84, 23);
            this.button_abortSend.TabIndex = 26;
            this.button_abortSend.Text = "Abort Send";
            this.button_abortSend.UseVisualStyleBackColor = true;
            this.button_abortSend.Click += new System.EventHandler(this.button_abortSend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_sector
            // 
            this.label_sector.AutoSize = true;
            this.label_sector.Location = new System.Drawing.Point(576, 17);
            this.label_sector.Name = "label_sector";
            this.label_sector.Size = new System.Drawing.Size(79, 13);
            this.label_sector.TabIndex = 27;
            this.label_sector.Text = "Sector: 0x0000";
            // 
            // ignoreCRC_checkBox
            // 
            this.ignoreCRC_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreCRC_checkBox.AutoSize = true;
            this.ignoreCRC_checkBox.Location = new System.Drawing.Point(691, 16);
            this.ignoreCRC_checkBox.Name = "ignoreCRC_checkBox";
            this.ignoreCRC_checkBox.Size = new System.Drawing.Size(100, 17);
            this.ignoreCRC_checkBox.TabIndex = 28;
            this.ignoreCRC_checkBox.Text = "Ignore File CRC";
            this.ignoreCRC_checkBox.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 753);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1073, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 29;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // PCtoCenturionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 775);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ignoreCRC_checkBox);
            this.Controls.Add(this.label_sector);
            this.Controls.Add(this.button_abortSend);
            this.Controls.Add(this.button_sendFile);
            this.Controls.Add(this.button_loadFile);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.checkBox_CTS);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.comboBox_portSpeed);
            this.Controls.Add(this.comboBox_portName);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_list);
            this.Name = "PCtoCenturionForm";
            this.Text = "PC to Centurion serial platter dumper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCtoCenturionForm_FormClosing);
            this.Load += new System.EventHandler(this.PCtoCenturionForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button_loadFile;
        private System.Windows.Forms.Button button_sendFile;
        private System.Windows.Forms.Button button_abortSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_sector;
        private System.Windows.Forms.CheckBox ignoreCRC_checkBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

