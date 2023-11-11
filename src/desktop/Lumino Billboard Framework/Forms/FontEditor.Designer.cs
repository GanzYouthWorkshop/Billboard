namespace Lumino
{
    partial class FontEditor
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
            this.lbxCharacters = new System.Windows.Forms.ListBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.btnRemoveCharacter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditCharacter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxFontName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCharacters
            // 
            this.lbxCharacters.FormattingEnabled = true;
            this.lbxCharacters.ItemHeight = 17;
            this.lbxCharacters.Location = new System.Drawing.Point(6, 24);
            this.lbxCharacters.Name = "lbxCharacters";
            this.lbxCharacters.Size = new System.Drawing.Size(251, 276);
            this.lbxCharacters.TabIndex = 0;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(6, 306);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(81, 35);
            this.btnAddCharacter.TabIndex = 1;
            this.btnAddCharacter.Text = "Add";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveCharacter
            // 
            this.btnRemoveCharacter.Location = new System.Drawing.Point(178, 306);
            this.btnRemoveCharacter.Name = "btnRemoveCharacter";
            this.btnRemoveCharacter.Size = new System.Drawing.Size(79, 35);
            this.btnRemoveCharacter.TabIndex = 2;
            this.btnRemoveCharacter.Text = "Remove";
            this.btnRemoveCharacter.UseVisualStyleBackColor = true;
            this.btnRemoveCharacter.Click += new System.EventHandler(this.btnRemoveCharacter_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(199, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.Location = new System.Drawing.Point(93, 306);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.Size = new System.Drawing.Size(79, 35);
            this.btnEditCharacter.TabIndex = 4;
            this.btnEditCharacter.Text = "Edit";
            this.btnEditCharacter.UseVisualStyleBackColor = true;
            this.btnEditCharacter.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxCharacters);
            this.groupBox1.Controls.Add(this.btnAddCharacter);
            this.groupBox1.Controls.Add(this.btnRemoveCharacter);
            this.groupBox1.Controls.Add(this.btnEditCharacter);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 351);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characters";
            // 
            // tbxFontName
            // 
            this.tbxFontName.Location = new System.Drawing.Point(66, 12);
            this.tbxFontName.Name = "tbxFontName";
            this.tbxFontName.Size = new System.Drawing.Size(212, 25);
            this.tbxFontName.TabIndex = 8;
            // 
            // FontEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 463);
            this.Controls.Add(this.tbxFontName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontEditor";
            this.ShowInTaskbar = false;
            this.Text = "Edit font";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCharacters;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Button btnRemoveCharacter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxFontName;
    }
}