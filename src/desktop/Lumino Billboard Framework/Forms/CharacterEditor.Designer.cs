namespace Lumino
{
    partial class CharacterEditor
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
            this.pnlDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.nudCharacterWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCharacterName = new System.Windows.Forms.TextBox();
            this.columnEditor1 = new Lumino.ColumnEditor();
            this.columnEditor2 = new Lumino.ColumnEditor();
            this.columnEditor3 = new Lumino.ColumnEditor();
            this.columnEditor4 = new Lumino.ColumnEditor();
            this.columnEditor5 = new Lumino.ColumnEditor();
            this.columnEditor6 = new Lumino.ColumnEditor();
            this.columnEditor8 = new Lumino.ColumnEditor();
            this.columnEditor7 = new Lumino.ColumnEditor();
            this.columnEditor9 = new Lumino.ColumnEditor();
            this.columnEditor10 = new Lumino.ColumnEditor();
            this.columnEditor11 = new Lumino.ColumnEditor();
            this.columnEditor12 = new Lumino.ColumnEditor();
            this.columnEditor13 = new Lumino.ColumnEditor();
            this.columnEditor14 = new Lumino.ColumnEditor();
            this.columnEditor15 = new Lumino.ColumnEditor();
            this.columnEditor16 = new Lumino.ColumnEditor();
            this.columnEditor17 = new Lumino.ColumnEditor();
            this.columnEditor18 = new Lumino.ColumnEditor();
            this.columnEditor19 = new Lumino.ColumnEditor();
            this.columnEditor20 = new Lumino.ColumnEditor();
            this.columnEditor21 = new Lumino.ColumnEditor();
            this.columnEditor22 = new Lumino.ColumnEditor();
            this.columnEditor23 = new Lumino.ColumnEditor();
            this.columnEditor24 = new Lumino.ColumnEditor();
            this.columnEditor25 = new Lumino.ColumnEditor();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.columnEditor1);
            this.pnlDisplay.Controls.Add(this.columnEditor2);
            this.pnlDisplay.Controls.Add(this.columnEditor3);
            this.pnlDisplay.Controls.Add(this.columnEditor4);
            this.pnlDisplay.Controls.Add(this.columnEditor5);
            this.pnlDisplay.Controls.Add(this.columnEditor6);
            this.pnlDisplay.Controls.Add(this.columnEditor8);
            this.pnlDisplay.Controls.Add(this.columnEditor7);
            this.pnlDisplay.Controls.Add(this.columnEditor9);
            this.pnlDisplay.Controls.Add(this.columnEditor10);
            this.pnlDisplay.Controls.Add(this.columnEditor11);
            this.pnlDisplay.Controls.Add(this.columnEditor12);
            this.pnlDisplay.Controls.Add(this.columnEditor13);
            this.pnlDisplay.Controls.Add(this.columnEditor14);
            this.pnlDisplay.Controls.Add(this.columnEditor15);
            this.pnlDisplay.Controls.Add(this.columnEditor16);
            this.pnlDisplay.Controls.Add(this.columnEditor17);
            this.pnlDisplay.Controls.Add(this.columnEditor18);
            this.pnlDisplay.Controls.Add(this.columnEditor19);
            this.pnlDisplay.Controls.Add(this.columnEditor20);
            this.pnlDisplay.Controls.Add(this.columnEditor21);
            this.pnlDisplay.Controls.Add(this.columnEditor22);
            this.pnlDisplay.Controls.Add(this.columnEditor23);
            this.pnlDisplay.Controls.Add(this.columnEditor24);
            this.pnlDisplay.Controls.Add(this.columnEditor25);
            this.pnlDisplay.Location = new System.Drawing.Point(10, 13);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1083, 330);
            this.pnlDisplay.TabIndex = 0;
            // 
            // nudCharacterWidth
            // 
            this.nudCharacterWidth.Location = new System.Drawing.Point(126, 369);
            this.nudCharacterWidth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudCharacterWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCharacterWidth.Name = "nudCharacterWidth";
            this.nudCharacterWidth.Size = new System.Drawing.Size(105, 21);
            this.nudCharacterWidth.TabIndex = 1;
            this.nudCharacterWidth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudCharacterWidth.ValueChanged += new System.EventHandler(this.nudCharacterWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Character width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Character:";
            // 
            // tbxCharacterName
            // 
            this.tbxCharacterName.Location = new System.Drawing.Point(126, 400);
            this.tbxCharacterName.Name = "tbxCharacterName";
            this.tbxCharacterName.Size = new System.Drawing.Size(106, 21);
            this.tbxCharacterName.TabIndex = 4;
            // 
            // columnEditor1
            // 
            this.columnEditor1.Location = new System.Drawing.Point(2, 2);
            this.columnEditor1.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor1.Name = "columnEditor1";
            this.columnEditor1.Size = new System.Drawing.Size(37, 313);
            this.columnEditor1.TabIndex = 0;
            this.columnEditor1.Values = ((byte)(0));
            // 
            // columnEditor2
            // 
            this.columnEditor2.Location = new System.Drawing.Point(43, 2);
            this.columnEditor2.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor2.Name = "columnEditor2";
            this.columnEditor2.Size = new System.Drawing.Size(37, 313);
            this.columnEditor2.TabIndex = 1;
            this.columnEditor2.Values = ((byte)(0));
            // 
            // columnEditor3
            // 
            this.columnEditor3.Location = new System.Drawing.Point(84, 2);
            this.columnEditor3.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor3.Name = "columnEditor3";
            this.columnEditor3.Size = new System.Drawing.Size(37, 313);
            this.columnEditor3.TabIndex = 2;
            this.columnEditor3.Values = ((byte)(0));
            // 
            // columnEditor4
            // 
            this.columnEditor4.Location = new System.Drawing.Point(125, 2);
            this.columnEditor4.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor4.Name = "columnEditor4";
            this.columnEditor4.Size = new System.Drawing.Size(37, 313);
            this.columnEditor4.TabIndex = 3;
            this.columnEditor4.Values = ((byte)(0));
            // 
            // columnEditor5
            // 
            this.columnEditor5.Location = new System.Drawing.Point(166, 2);
            this.columnEditor5.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor5.Name = "columnEditor5";
            this.columnEditor5.Size = new System.Drawing.Size(37, 313);
            this.columnEditor5.TabIndex = 4;
            this.columnEditor5.Values = ((byte)(0));
            // 
            // columnEditor6
            // 
            this.columnEditor6.Location = new System.Drawing.Point(207, 2);
            this.columnEditor6.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor6.Name = "columnEditor6";
            this.columnEditor6.Size = new System.Drawing.Size(37, 313);
            this.columnEditor6.TabIndex = 5;
            this.columnEditor6.Values = ((byte)(0));
            // 
            // columnEditor8
            // 
            this.columnEditor8.Enabled = false;
            this.columnEditor8.Location = new System.Drawing.Point(248, 2);
            this.columnEditor8.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor8.Name = "columnEditor8";
            this.columnEditor8.Size = new System.Drawing.Size(37, 313);
            this.columnEditor8.TabIndex = 7;
            this.columnEditor8.Values = ((byte)(0));
            // 
            // columnEditor7
            // 
            this.columnEditor7.Enabled = false;
            this.columnEditor7.Location = new System.Drawing.Point(289, 2);
            this.columnEditor7.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor7.Name = "columnEditor7";
            this.columnEditor7.Size = new System.Drawing.Size(37, 313);
            this.columnEditor7.TabIndex = 6;
            this.columnEditor7.Values = ((byte)(0));
            // 
            // columnEditor9
            // 
            this.columnEditor9.Enabled = false;
            this.columnEditor9.Location = new System.Drawing.Point(330, 2);
            this.columnEditor9.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor9.Name = "columnEditor9";
            this.columnEditor9.Size = new System.Drawing.Size(37, 313);
            this.columnEditor9.TabIndex = 8;
            this.columnEditor9.Values = ((byte)(0));
            // 
            // columnEditor10
            // 
            this.columnEditor10.Enabled = false;
            this.columnEditor10.Location = new System.Drawing.Point(371, 2);
            this.columnEditor10.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor10.Name = "columnEditor10";
            this.columnEditor10.Size = new System.Drawing.Size(37, 313);
            this.columnEditor10.TabIndex = 9;
            this.columnEditor10.Values = ((byte)(0));
            // 
            // columnEditor11
            // 
            this.columnEditor11.Enabled = false;
            this.columnEditor11.Location = new System.Drawing.Point(412, 2);
            this.columnEditor11.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor11.Name = "columnEditor11";
            this.columnEditor11.Size = new System.Drawing.Size(37, 313);
            this.columnEditor11.TabIndex = 10;
            this.columnEditor11.Values = ((byte)(0));
            // 
            // columnEditor12
            // 
            this.columnEditor12.Enabled = false;
            this.columnEditor12.Location = new System.Drawing.Point(453, 2);
            this.columnEditor12.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor12.Name = "columnEditor12";
            this.columnEditor12.Size = new System.Drawing.Size(37, 313);
            this.columnEditor12.TabIndex = 11;
            this.columnEditor12.Values = ((byte)(0));
            // 
            // columnEditor13
            // 
            this.columnEditor13.Enabled = false;
            this.columnEditor13.Location = new System.Drawing.Point(494, 2);
            this.columnEditor13.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor13.Name = "columnEditor13";
            this.columnEditor13.Size = new System.Drawing.Size(37, 313);
            this.columnEditor13.TabIndex = 12;
            this.columnEditor13.Values = ((byte)(0));
            // 
            // columnEditor14
            // 
            this.columnEditor14.Enabled = false;
            this.columnEditor14.Location = new System.Drawing.Point(535, 2);
            this.columnEditor14.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor14.Name = "columnEditor14";
            this.columnEditor14.Size = new System.Drawing.Size(37, 313);
            this.columnEditor14.TabIndex = 13;
            this.columnEditor14.Values = ((byte)(0));
            // 
            // columnEditor15
            // 
            this.columnEditor15.Enabled = false;
            this.columnEditor15.Location = new System.Drawing.Point(576, 2);
            this.columnEditor15.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor15.Name = "columnEditor15";
            this.columnEditor15.Size = new System.Drawing.Size(37, 313);
            this.columnEditor15.TabIndex = 14;
            this.columnEditor15.Values = ((byte)(0));
            // 
            // columnEditor16
            // 
            this.columnEditor16.Enabled = false;
            this.columnEditor16.Location = new System.Drawing.Point(617, 2);
            this.columnEditor16.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor16.Name = "columnEditor16";
            this.columnEditor16.Size = new System.Drawing.Size(37, 313);
            this.columnEditor16.TabIndex = 15;
            this.columnEditor16.Values = ((byte)(0));
            // 
            // columnEditor17
            // 
            this.columnEditor17.Enabled = false;
            this.columnEditor17.Location = new System.Drawing.Point(658, 2);
            this.columnEditor17.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor17.Name = "columnEditor17";
            this.columnEditor17.Size = new System.Drawing.Size(37, 313);
            this.columnEditor17.TabIndex = 16;
            this.columnEditor17.Values = ((byte)(0));
            // 
            // columnEditor18
            // 
            this.columnEditor18.Enabled = false;
            this.columnEditor18.Location = new System.Drawing.Point(699, 2);
            this.columnEditor18.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor18.Name = "columnEditor18";
            this.columnEditor18.Size = new System.Drawing.Size(37, 313);
            this.columnEditor18.TabIndex = 17;
            this.columnEditor18.Values = ((byte)(0));
            // 
            // columnEditor19
            // 
            this.columnEditor19.Enabled = false;
            this.columnEditor19.Location = new System.Drawing.Point(740, 2);
            this.columnEditor19.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor19.Name = "columnEditor19";
            this.columnEditor19.Size = new System.Drawing.Size(37, 313);
            this.columnEditor19.TabIndex = 19;
            this.columnEditor19.Values = ((byte)(0));
            // 
            // columnEditor20
            // 
            this.columnEditor20.Enabled = false;
            this.columnEditor20.Location = new System.Drawing.Point(781, 2);
            this.columnEditor20.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor20.Name = "columnEditor20";
            this.columnEditor20.Size = new System.Drawing.Size(37, 313);
            this.columnEditor20.TabIndex = 18;
            this.columnEditor20.Values = ((byte)(0));
            // 
            // columnEditor21
            // 
            this.columnEditor21.Enabled = false;
            this.columnEditor21.Location = new System.Drawing.Point(822, 2);
            this.columnEditor21.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor21.Name = "columnEditor21";
            this.columnEditor21.Size = new System.Drawing.Size(37, 313);
            this.columnEditor21.TabIndex = 20;
            this.columnEditor21.Values = ((byte)(0));
            // 
            // columnEditor22
            // 
            this.columnEditor22.Enabled = false;
            this.columnEditor22.Location = new System.Drawing.Point(863, 2);
            this.columnEditor22.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor22.Name = "columnEditor22";
            this.columnEditor22.Size = new System.Drawing.Size(37, 313);
            this.columnEditor22.TabIndex = 21;
            this.columnEditor22.Values = ((byte)(0));
            // 
            // columnEditor23
            // 
            this.columnEditor23.Enabled = false;
            this.columnEditor23.Location = new System.Drawing.Point(904, 2);
            this.columnEditor23.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor23.Name = "columnEditor23";
            this.columnEditor23.Size = new System.Drawing.Size(37, 313);
            this.columnEditor23.TabIndex = 22;
            this.columnEditor23.Values = ((byte)(0));
            // 
            // columnEditor24
            // 
            this.columnEditor24.Enabled = false;
            this.columnEditor24.Location = new System.Drawing.Point(945, 2);
            this.columnEditor24.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor24.Name = "columnEditor24";
            this.columnEditor24.Size = new System.Drawing.Size(37, 313);
            this.columnEditor24.TabIndex = 23;
            this.columnEditor24.Values = ((byte)(0));
            // 
            // columnEditor25
            // 
            this.columnEditor25.Enabled = false;
            this.columnEditor25.Location = new System.Drawing.Point(986, 2);
            this.columnEditor25.Margin = new System.Windows.Forms.Padding(2);
            this.columnEditor25.Name = "columnEditor25";
            this.columnEditor25.Size = new System.Drawing.Size(37, 313);
            this.columnEditor25.TabIndex = 24;
            this.columnEditor25.Values = ((byte)(0));
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Lumino.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(1009, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::Lumino.Properties.Resources.StatusOK;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(922, 414);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 35);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CharacterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxCharacterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCharacterWidth);
            this.Controls.Add(this.pnlDisplay);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CharacterEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit Character";
            this.pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlDisplay;
        private System.Windows.Forms.NumericUpDown nudCharacterWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCharacterName;
        private ColumnEditor columnEditor1;
        private ColumnEditor columnEditor2;
        private ColumnEditor columnEditor3;
        private ColumnEditor columnEditor4;
        private ColumnEditor columnEditor5;
        private ColumnEditor columnEditor6;
        private ColumnEditor columnEditor8;
        private ColumnEditor columnEditor7;
        private ColumnEditor columnEditor9;
        private ColumnEditor columnEditor10;
        private ColumnEditor columnEditor11;
        private ColumnEditor columnEditor12;
        private ColumnEditor columnEditor13;
        private ColumnEditor columnEditor14;
        private ColumnEditor columnEditor15;
        private ColumnEditor columnEditor16;
        private ColumnEditor columnEditor17;
        private ColumnEditor columnEditor18;
        private ColumnEditor columnEditor19;
        private ColumnEditor columnEditor20;
        private ColumnEditor columnEditor21;
        private ColumnEditor columnEditor22;
        private ColumnEditor columnEditor23;
        private ColumnEditor columnEditor24;
        private ColumnEditor columnEditor25;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}