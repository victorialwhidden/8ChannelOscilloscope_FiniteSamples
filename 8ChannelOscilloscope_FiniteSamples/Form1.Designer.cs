namespace _8ChannelOscilloscope_FiniteSamples
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_DAQ = new System.Windows.Forms.GroupBox();
            this.lbl_ADrate = new System.Windows.Forms.Label();
            this.lbl_AcqTime = new System.Windows.Forms.Label();
            this.lbl_ADrateTimeLabel = new System.Windows.Forms.Label();
            this.lbl_AcqTimeLabel = new System.Windows.Forms.Label();
            this.lbl_ChanRange = new System.Windows.Forms.Label();
            this.lbl_NumOfSamples = new System.Windows.Forms.Label();
            this.lbl_SampleRate = new System.Windows.Forms.Label();
            this.lbl_VolRange = new System.Windows.Forms.Label();
            this.lbl_HighChan = new System.Windows.Forms.Label();
            this.lbl_LowChan = new System.Windows.Forms.Label();
            this.lbl_TermConfig = new System.Windows.Forms.Label();
            this.lbl_Device = new System.Windows.Forms.Label();
            this.NumUD_SampPerChan = new System.Windows.Forms.NumericUpDown();
            this.NumUD_ChanSampRate = new System.Windows.Forms.NumericUpDown();
            this.NumUD_HighChan = new System.Windows.Forms.NumericUpDown();
            this.NumUD_LowChan = new System.Windows.Forms.NumericUpDown();
            this.Cbx_VoltageRange = new System.Windows.Forms.ComboBox();
            this.Cbx_TerminalConfig = new System.Windows.Forms.ComboBox();
            this.Cbx_Device = new System.Windows.Forms.ComboBox();
            this.cht_Data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_New = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Append = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Acquire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.gb_DAQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_SampPerChan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_ChanSampRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_HighChan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_LowChan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Data)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DAQ
            // 
            this.gb_DAQ.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_DAQ.Controls.Add(this.lbl_ADrate);
            this.gb_DAQ.Controls.Add(this.lbl_AcqTime);
            this.gb_DAQ.Controls.Add(this.lbl_ADrateTimeLabel);
            this.gb_DAQ.Controls.Add(this.lbl_AcqTimeLabel);
            this.gb_DAQ.Controls.Add(this.lbl_ChanRange);
            this.gb_DAQ.Controls.Add(this.lbl_NumOfSamples);
            this.gb_DAQ.Controls.Add(this.lbl_SampleRate);
            this.gb_DAQ.Controls.Add(this.lbl_VolRange);
            this.gb_DAQ.Controls.Add(this.lbl_HighChan);
            this.gb_DAQ.Controls.Add(this.lbl_LowChan);
            this.gb_DAQ.Controls.Add(this.lbl_TermConfig);
            this.gb_DAQ.Controls.Add(this.lbl_Device);
            this.gb_DAQ.Controls.Add(this.NumUD_SampPerChan);
            this.gb_DAQ.Controls.Add(this.NumUD_ChanSampRate);
            this.gb_DAQ.Controls.Add(this.NumUD_HighChan);
            this.gb_DAQ.Controls.Add(this.NumUD_LowChan);
            this.gb_DAQ.Controls.Add(this.Cbx_VoltageRange);
            this.gb_DAQ.Controls.Add(this.Cbx_TerminalConfig);
            this.gb_DAQ.Controls.Add(this.Cbx_Device);
            this.gb_DAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_DAQ.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DAQ.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_DAQ.Location = new System.Drawing.Point(12, 71);
            this.gb_DAQ.Name = "gb_DAQ";
            this.gb_DAQ.Size = new System.Drawing.Size(510, 371);
            this.gb_DAQ.TabIndex = 0;
            this.gb_DAQ.TabStop = false;
            this.gb_DAQ.Text = "DAQ Configuration";
            // 
            // lbl_ADrate
            // 
            this.lbl_ADrate.AutoSize = true;
            this.lbl_ADrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_ADrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ADrate.Location = new System.Drawing.Point(372, 329);
            this.lbl_ADrate.Name = "lbl_ADrate";
            this.lbl_ADrate.Size = new System.Drawing.Size(0, 14);
            this.lbl_ADrate.TabIndex = 20;
            // 
            // lbl_AcqTime
            // 
            this.lbl_AcqTime.AutoSize = true;
            this.lbl_AcqTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_AcqTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AcqTime.Location = new System.Drawing.Point(372, 225);
            this.lbl_AcqTime.Name = "lbl_AcqTime";
            this.lbl_AcqTime.Size = new System.Drawing.Size(0, 14);
            this.lbl_AcqTime.TabIndex = 19;
            // 
            // lbl_ADrateTimeLabel
            // 
            this.lbl_ADrateTimeLabel.AutoSize = true;
            this.lbl_ADrateTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_ADrateTimeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ADrateTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ADrateTimeLabel.Location = new System.Drawing.Point(315, 294);
            this.lbl_ADrateTimeLabel.Name = "lbl_ADrateTimeLabel";
            this.lbl_ADrateTimeLabel.Size = new System.Drawing.Size(115, 16);
            this.lbl_ADrateTimeLabel.TabIndex = 18;
            this.lbl_ADrateTimeLabel.Text = "A/D Rate (S/s)";
            // 
            // lbl_AcqTimeLabel
            // 
            this.lbl_AcqTimeLabel.AutoSize = true;
            this.lbl_AcqTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_AcqTimeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AcqTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AcqTimeLabel.Location = new System.Drawing.Point(294, 195);
            this.lbl_AcqTimeLabel.Name = "lbl_AcqTimeLabel";
            this.lbl_AcqTimeLabel.Size = new System.Drawing.Size(157, 16);
            this.lbl_AcqTimeLabel.TabIndex = 17;
            this.lbl_AcqTimeLabel.Text = "Acquisition Time (s)";
            // 
            // lbl_ChanRange
            // 
            this.lbl_ChanRange.AutoSize = true;
            this.lbl_ChanRange.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ChanRange.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChanRange.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_ChanRange.Location = new System.Drawing.Point(14, 157);
            this.lbl_ChanRange.Name = "lbl_ChanRange";
            this.lbl_ChanRange.Size = new System.Drawing.Size(123, 16);
            this.lbl_ChanRange.TabIndex = 14;
            this.lbl_ChanRange.Text = "Channel Range:";
            // 
            // lbl_NumOfSamples
            // 
            this.lbl_NumOfSamples.AutoSize = true;
            this.lbl_NumOfSamples.Location = new System.Drawing.Point(264, 140);
            this.lbl_NumOfSamples.Name = "lbl_NumOfSamples";
            this.lbl_NumOfSamples.Size = new System.Drawing.Size(187, 14);
            this.lbl_NumOfSamples.TabIndex = 13;
            this.lbl_NumOfSamples.Text = "Number samples / Channels:";
            // 
            // lbl_SampleRate
            // 
            this.lbl_SampleRate.AutoSize = true;
            this.lbl_SampleRate.Location = new System.Drawing.Point(264, 91);
            this.lbl_SampleRate.Name = "lbl_SampleRate";
            this.lbl_SampleRate.Size = new System.Drawing.Size(148, 14);
            this.lbl_SampleRate.TabIndex = 12;
            this.lbl_SampleRate.Text = "Channel Sample Rate:";
            // 
            // lbl_VolRange
            // 
            this.lbl_VolRange.AutoSize = true;
            this.lbl_VolRange.Location = new System.Drawing.Point(264, 28);
            this.lbl_VolRange.Name = "lbl_VolRange";
            this.lbl_VolRange.Size = new System.Drawing.Size(106, 14);
            this.lbl_VolRange.TabIndex = 11;
            this.lbl_VolRange.Text = "Voltage Range:";
            // 
            // lbl_HighChan
            // 
            this.lbl_HighChan.AutoSize = true;
            this.lbl_HighChan.Location = new System.Drawing.Point(14, 248);
            this.lbl_HighChan.Name = "lbl_HighChan";
            this.lbl_HighChan.Size = new System.Drawing.Size(100, 14);
            this.lbl_HighChan.TabIndex = 10;
            this.lbl_HighChan.Text = "High Channel:";
            // 
            // lbl_LowChan
            // 
            this.lbl_LowChan.AutoSize = true;
            this.lbl_LowChan.Location = new System.Drawing.Point(14, 189);
            this.lbl_LowChan.Name = "lbl_LowChan";
            this.lbl_LowChan.Size = new System.Drawing.Size(96, 14);
            this.lbl_LowChan.TabIndex = 9;
            this.lbl_LowChan.Text = "Low Channel:";
            // 
            // lbl_TermConfig
            // 
            this.lbl_TermConfig.AutoSize = true;
            this.lbl_TermConfig.Location = new System.Drawing.Point(14, 91);
            this.lbl_TermConfig.Name = "lbl_TermConfig";
            this.lbl_TermConfig.Size = new System.Drawing.Size(163, 14);
            this.lbl_TermConfig.TabIndex = 8;
            this.lbl_TermConfig.Text = "Terminal Configuration:";
            // 
            // lbl_Device
            // 
            this.lbl_Device.AutoSize = true;
            this.lbl_Device.Location = new System.Drawing.Point(14, 28);
            this.lbl_Device.Name = "lbl_Device";
            this.lbl_Device.Size = new System.Drawing.Size(56, 14);
            this.lbl_Device.TabIndex = 7;
            this.lbl_Device.Text = "Device:";
            // 
            // NumUD_SampPerChan
            // 
            this.NumUD_SampPerChan.Location = new System.Drawing.Point(267, 157);
            this.NumUD_SampPerChan.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumUD_SampPerChan.Name = "NumUD_SampPerChan";
            this.NumUD_SampPerChan.Size = new System.Drawing.Size(221, 22);
            this.NumUD_SampPerChan.TabIndex = 6;
            this.NumUD_SampPerChan.ValueChanged += new System.EventHandler(this.NumUD_SampPerChan_ValueChanged);
            // 
            // NumUD_ChanSampRate
            // 
            this.NumUD_ChanSampRate.Location = new System.Drawing.Point(267, 108);
            this.NumUD_ChanSampRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumUD_ChanSampRate.Name = "NumUD_ChanSampRate";
            this.NumUD_ChanSampRate.Size = new System.Drawing.Size(221, 22);
            this.NumUD_ChanSampRate.TabIndex = 5;
            this.NumUD_ChanSampRate.ValueChanged += new System.EventHandler(this.NumUD_ChanSampRate_ValueChanged);
            // 
            // NumUD_HighChan
            // 
            this.NumUD_HighChan.Location = new System.Drawing.Point(17, 265);
            this.NumUD_HighChan.Name = "NumUD_HighChan";
            this.NumUD_HighChan.Size = new System.Drawing.Size(221, 22);
            this.NumUD_HighChan.TabIndex = 4;
            this.NumUD_HighChan.ValueChanged += new System.EventHandler(this.NumUD_HighChan_ValueChanged);
            // 
            // NumUD_LowChan
            // 
            this.NumUD_LowChan.Location = new System.Drawing.Point(17, 206);
            this.NumUD_LowChan.Name = "NumUD_LowChan";
            this.NumUD_LowChan.Size = new System.Drawing.Size(221, 22);
            this.NumUD_LowChan.TabIndex = 3;
            this.NumUD_LowChan.ValueChanged += new System.EventHandler(this.NumUD_LowChan_ValueChanged);
            // 
            // Cbx_VoltageRange
            // 
            this.Cbx_VoltageRange.FormattingEnabled = true;
            this.Cbx_VoltageRange.Location = new System.Drawing.Point(267, 45);
            this.Cbx_VoltageRange.Name = "Cbx_VoltageRange";
            this.Cbx_VoltageRange.Size = new System.Drawing.Size(221, 22);
            this.Cbx_VoltageRange.TabIndex = 2;
            this.Cbx_VoltageRange.SelectedIndexChanged += new System.EventHandler(this.Cbx_VoltageRange_SelectedIndexChanged);
            // 
            // Cbx_TerminalConfig
            // 
            this.Cbx_TerminalConfig.FormattingEnabled = true;
            this.Cbx_TerminalConfig.Location = new System.Drawing.Point(17, 108);
            this.Cbx_TerminalConfig.Name = "Cbx_TerminalConfig";
            this.Cbx_TerminalConfig.Size = new System.Drawing.Size(221, 22);
            this.Cbx_TerminalConfig.TabIndex = 1;
            this.Cbx_TerminalConfig.SelectedIndexChanged += new System.EventHandler(this.Cbx_TerminalConfig_SelectedIndexChanged);
            // 
            // Cbx_Device
            // 
            this.Cbx_Device.FormattingEnabled = true;
            this.Cbx_Device.Location = new System.Drawing.Point(17, 45);
            this.Cbx_Device.Name = "Cbx_Device";
            this.Cbx_Device.Size = new System.Drawing.Size(221, 22);
            this.Cbx_Device.TabIndex = 0;
            this.Cbx_Device.SelectedIndexChanged += new System.EventHandler(this.Cbx_Device_SelectedIndexChanged);
            // 
            // cht_Data
            // 
            chartArea1.Name = "ChartArea1";
            this.cht_Data.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.cht_Data.Legends.Add(legend1);
            this.cht_Data.Location = new System.Drawing.Point(551, 46);
            this.cht_Data.Name = "cht_Data";
            this.cht_Data.Size = new System.Drawing.Size(571, 415);
            this.cht_Data.TabIndex = 1;
            this.cht_Data.Text = "chart1";
            title1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DeepPink;
            title1.Name = "Title1";
            title1.Text = "Voltage vs Time";
            this.cht_Data.Titles.Add(title1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File,
            this.mnu_Acquire,
            this.mnu_Clear,
            this.mnu_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_File
            // 
            this.mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Open,
            this.mnu_Save,
            this.mnu_Quit});
            this.mnu_File.Name = "mnu_File";
            this.mnu_File.ShortcutKeyDisplayString = "Ctrl+F";
            this.mnu_File.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnu_File.Size = new System.Drawing.Size(37, 20);
            this.mnu_File.Text = "&File";
            // 
            // mnu_Open
            // 
            this.mnu_Open.Name = "mnu_Open";
            this.mnu_Open.ShortcutKeyDisplayString = "Ctrl+O";
            this.mnu_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnu_Open.Size = new System.Drawing.Size(180, 22);
            this.mnu_Open.Text = "&Open";
            this.mnu_Open.Click += new System.EventHandler(this.mnu_Open_Click);
            // 
            // mnu_Save
            // 
            this.mnu_Save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_New,
            this.mnu_Append});
            this.mnu_Save.Name = "mnu_Save";
            this.mnu_Save.ShortcutKeyDisplayString = "Ctrl+S";
            this.mnu_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnu_Save.Size = new System.Drawing.Size(180, 22);
            this.mnu_Save.Text = "&Save";
            // 
            // mnu_New
            // 
            this.mnu_New.Name = "mnu_New";
            this.mnu_New.ShortcutKeyDisplayString = "Ctrl+N";
            this.mnu_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnu_New.Size = new System.Drawing.Size(180, 22);
            this.mnu_New.Text = "&New";
            this.mnu_New.Click += new System.EventHandler(this.mnu_New_Click);
            // 
            // mnu_Append
            // 
            this.mnu_Append.Name = "mnu_Append";
            this.mnu_Append.ShortcutKeyDisplayString = "Ctrl+A";
            this.mnu_Append.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnu_Append.Size = new System.Drawing.Size(180, 22);
            this.mnu_Append.Text = "&Append";
            this.mnu_Append.Click += new System.EventHandler(this.mnu_Append_Click);
            // 
            // mnu_Quit
            // 
            this.mnu_Quit.Name = "mnu_Quit";
            this.mnu_Quit.ShortcutKeyDisplayString = "Ctrl+Q";
            this.mnu_Quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnu_Quit.Size = new System.Drawing.Size(180, 22);
            this.mnu_Quit.Text = "&Quit";
            this.mnu_Quit.Click += new System.EventHandler(this.mnu_Quit_Click);
            // 
            // mnu_Acquire
            // 
            this.mnu_Acquire.Name = "mnu_Acquire";
            this.mnu_Acquire.ShortcutKeyDisplayString = "Ctrl+D";
            this.mnu_Acquire.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnu_Acquire.Size = new System.Drawing.Size(60, 20);
            this.mnu_Acquire.Text = "&Acquire";
            this.mnu_Acquire.Click += new System.EventHandler(this.mnu_Acquire_Click);
            // 
            // mnu_Clear
            // 
            this.mnu_Clear.Name = "mnu_Clear";
            this.mnu_Clear.ShortcutKeyDisplayString = "Ctrl+C";
            this.mnu_Clear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnu_Clear.Size = new System.Drawing.Size(78, 20);
            this.mnu_Clear.Text = "&Clear Chart";
            this.mnu_Clear.Click += new System.EventHandler(this.mnu_Clear_Click);
            // 
            // mnu_Help
            // 
            this.mnu_Help.Name = "mnu_Help";
            this.mnu_Help.ShortcutKeyDisplayString = "Ctrl+H";
            this.mnu_Help.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnu_Help.Size = new System.Drawing.Size(44, 20);
            this.mnu_Help.Text = "&Help";
            this.mnu_Help.Click += new System.EventHandler(this.mnu_Help_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1134, 478);
            this.Controls.Add(this.cht_Data);
            this.Controls.Add(this.gb_DAQ);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_DAQ.ResumeLayout(false);
            this.gb_DAQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_SampPerChan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_ChanSampRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_HighChan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_LowChan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Data)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DAQ;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Data;
        private System.Windows.Forms.Label lbl_ADrate;
        private System.Windows.Forms.Label lbl_AcqTime;
        private System.Windows.Forms.Label lbl_ADrateTimeLabel;
        private System.Windows.Forms.Label lbl_AcqTimeLabel;
        private System.Windows.Forms.Label lbl_ChanRange;
        private System.Windows.Forms.Label lbl_NumOfSamples;
        private System.Windows.Forms.Label lbl_SampleRate;
        private System.Windows.Forms.Label lbl_VolRange;
        private System.Windows.Forms.Label lbl_HighChan;
        private System.Windows.Forms.Label lbl_LowChan;
        private System.Windows.Forms.Label lbl_TermConfig;
        private System.Windows.Forms.Label lbl_Device;
        private System.Windows.Forms.NumericUpDown NumUD_SampPerChan;
        private System.Windows.Forms.NumericUpDown NumUD_ChanSampRate;
        private System.Windows.Forms.NumericUpDown NumUD_HighChan;
        private System.Windows.Forms.NumericUpDown NumUD_LowChan;
        private System.Windows.Forms.ComboBox Cbx_VoltageRange;
        private System.Windows.Forms.ComboBox Cbx_TerminalConfig;
        private System.Windows.Forms.ComboBox Cbx_Device;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_File;
        private System.Windows.Forms.ToolStripMenuItem mnu_Open;
        private System.Windows.Forms.ToolStripMenuItem mnu_Save;
        private System.Windows.Forms.ToolStripMenuItem mnu_New;
        private System.Windows.Forms.ToolStripMenuItem mnu_Append;
        private System.Windows.Forms.ToolStripMenuItem mnu_Quit;
        private System.Windows.Forms.ToolStripMenuItem mnu_Acquire;
        private System.Windows.Forms.ToolStripMenuItem mnu_Clear;
        private System.Windows.Forms.ToolStripMenuItem mnu_Help;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}

