namespace Lumino
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFrameWidth = new System.Windows.Forms.NumericUpDown();
            this.nudFrameDuration = new System.Windows.Forms.NumericUpDown();
            this.cbxDisplayWidth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxProgrammingPort = new System.Windows.Forms.ComboBox();
            this.btnSearchPorts = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxFont = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközökToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betűkészletkezelőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMessage
            // 
            this.tbxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxMessage.Location = new System.Drawing.Point(162, 158);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(919, 21);
            this.tbxMessage.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.eszközökToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Frame width:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Frame duration:";
            // 
            // nudFrameWidth
            // 
            this.nudFrameWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudFrameWidth.Location = new System.Drawing.Point(162, 251);
            this.nudFrameWidth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFrameWidth.Name = "nudFrameWidth";
            this.nudFrameWidth.Size = new System.Drawing.Size(120, 21);
            this.nudFrameWidth.TabIndex = 16;
            this.nudFrameWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudFrameDuration
            // 
            this.nudFrameDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudFrameDuration.Location = new System.Drawing.Point(163, 282);
            this.nudFrameDuration.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudFrameDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameDuration.Name = "nudFrameDuration";
            this.nudFrameDuration.Size = new System.Drawing.Size(120, 21);
            this.nudFrameDuration.TabIndex = 17;
            this.nudFrameDuration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbxDisplayWidth
            // 
            this.cbxDisplayWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxDisplayWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDisplayWidth.FormattingEnabled = true;
            this.cbxDisplayWidth.Items.AddRange(new object[] {
            "25",
            "50",
            "75"});
            this.cbxDisplayWidth.Location = new System.Drawing.Point(162, 220);
            this.cbxDisplayWidth.Name = "cbxDisplayWidth";
            this.cbxDisplayWidth.Size = new System.Drawing.Size(121, 20);
            this.cbxDisplayWidth.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Display width:";
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbLog.Location = new System.Drawing.Point(308, 189);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(773, 218);
            this.rtbLog.TabIndex = 21;
            this.rtbLog.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Programming port:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Message:";
            // 
            // cbxProgrammingPort
            // 
            this.cbxProgrammingPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxProgrammingPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProgrammingPort.FormattingEnabled = true;
            this.cbxProgrammingPort.Location = new System.Drawing.Point(163, 190);
            this.cbxProgrammingPort.Name = "cbxProgrammingPort";
            this.cbxProgrammingPort.Size = new System.Drawing.Size(57, 20);
            this.cbxProgrammingPort.TabIndex = 26;
            // 
            // btnSearchPorts
            // 
            this.btnSearchPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearchPorts.Location = new System.Drawing.Point(226, 190);
            this.btnSearchPorts.Name = "btnSearchPorts";
            this.btnSearchPorts.Size = new System.Drawing.Size(57, 25);
            this.btnSearchPorts.TabIndex = 27;
            this.btnSearchPorts.Text = "Search";
            this.btnSearchPorts.UseVisualStyleBackColor = true;
            this.btnSearchPorts.Click += new System.EventHandler(this.btnSearchPorts_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Font:";
            // 
            // cbxFont
            // 
            this.cbxFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFont.FormattingEnabled = true;
            this.cbxFont.Location = new System.Drawing.Point(163, 313);
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(121, 20);
            this.cbxFont.TabIndex = 28;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreview.Image = global::Lumino.Properties.Resources.PlaybackPreview;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.Location = new System.Drawing.Point(12, 360);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(125, 47);
            this.btnPreview.TabIndex = 22;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Image = global::Lumino.Properties.Resources.Play;
            this.button2.Location = new System.Drawing.Point(143, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 47);
            this.button2.TabIndex = 20;
            this.button2.Text = "Compile";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 70);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fájlToolStripMenuItem.Image = global::Lumino.Properties.Resources.Document;
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fájlToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Lumino.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // eszközökToolStripMenuItem
            // 
            this.eszközökToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betűkészletkezelőToolStripMenuItem});
            this.eszközökToolStripMenuItem.Image = global::Lumino.Properties.Resources.Toolbox;
            this.eszközökToolStripMenuItem.Name = "eszközökToolStripMenuItem";
            this.eszközökToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.eszközökToolStripMenuItem.Text = "Tools";
            // 
            // betűkészletkezelőToolStripMenuItem
            // 
            this.betűkészletkezelőToolStripMenuItem.Image = global::Lumino.Properties.Resources.Font;
            this.betűkészletkezelőToolStripMenuItem.Name = "betűkészletkezelőToolStripMenuItem";
            this.betűkészletkezelőToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.betűkészletkezelőToolStripMenuItem.Text = "Font editor";
            this.betűkészletkezelőToolStripMenuItem.Click += new System.EventHandler(this.betűkészletkezelőToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::Lumino.Properties.Resources.F1Help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Lumino.Properties.Resources.AboutBox;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 118);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(3, 98);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1073, 17);
            this.hScrollBar1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxFont);
            this.Controls.Add(this.btnSearchPorts);
            this.Controls.Add(this.cbxProgrammingPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDisplayWidth);
            this.Controls.Add(this.nudFrameDuration);
            this.Controls.Add(this.nudFrameWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Lumino Billboard Framework";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszközökToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betűkészletkezelőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFrameWidth;
        private System.Windows.Forms.NumericUpDown nudFrameDuration;
        private System.Windows.Forms.ComboBox cbxDisplayWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxProgrammingPort;
        private System.Windows.Forms.Button btnSearchPorts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

