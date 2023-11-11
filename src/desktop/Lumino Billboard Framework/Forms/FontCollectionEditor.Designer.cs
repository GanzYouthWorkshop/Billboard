namespace Lumino.Forms
{
    partial class FontCollectionEditor
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
            this.gbxFonts = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbxFonts = new System.Windows.Forms.ListBox();
            this.btnAddFont = new System.Windows.Forms.Button();
            this.btnRemoveFont = new System.Windows.Forms.Button();
            this.btnEditFont = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxFonts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFonts
            // 
            this.gbxFonts.Controls.Add(this.textBox1);
            this.gbxFonts.Controls.Add(this.lbxFonts);
            this.gbxFonts.Controls.Add(this.btnAddFont);
            this.gbxFonts.Controls.Add(this.btnRemoveFont);
            this.gbxFonts.Controls.Add(this.btnEditFont);
            this.gbxFonts.Location = new System.Drawing.Point(10, 13);
            this.gbxFonts.Name = "gbxFonts";
            this.gbxFonts.Size = new System.Drawing.Size(233, 400);
            this.gbxFonts.TabIndex = 9;
            this.gbxFonts.TabStop = false;
            this.gbxFonts.Text = "Fonts";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 21);
            this.textBox1.TabIndex = 5;
            // 
            // lbxFonts
            // 
            this.lbxFonts.FormattingEnabled = true;
            this.lbxFonts.ItemHeight = 12;
            this.lbxFonts.Location = new System.Drawing.Point(5, 26);
            this.lbxFonts.Name = "lbxFonts";
            this.lbxFonts.Size = new System.Drawing.Size(220, 292);
            this.lbxFonts.TabIndex = 0;
            // 
            // btnAddFont
            // 
            this.btnAddFont.Location = new System.Drawing.Point(7, 356);
            this.btnAddFont.Name = "btnAddFont";
            this.btnAddFont.Size = new System.Drawing.Size(71, 37);
            this.btnAddFont.TabIndex = 1;
            this.btnAddFont.Text = "Add";
            this.btnAddFont.UseVisualStyleBackColor = true;
            this.btnAddFont.Click += new System.EventHandler(this.btnAddFont_Click);
            // 
            // btnRemoveFont
            // 
            this.btnRemoveFont.Location = new System.Drawing.Point(156, 356);
            this.btnRemoveFont.Name = "btnRemoveFont";
            this.btnRemoveFont.Size = new System.Drawing.Size(69, 37);
            this.btnRemoveFont.TabIndex = 2;
            this.btnRemoveFont.Text = "Remove";
            this.btnRemoveFont.UseVisualStyleBackColor = true;
            this.btnRemoveFont.Click += new System.EventHandler(this.btnRemoveFont_Click);
            // 
            // btnEditFont
            // 
            this.btnEditFont.Location = new System.Drawing.Point(84, 356);
            this.btnEditFont.Name = "btnEditFont";
            this.btnEditFont.Size = new System.Drawing.Size(69, 37);
            this.btnEditFont.TabIndex = 4;
            this.btnEditFont.Text = "Edit";
            this.btnEditFont.UseVisualStyleBackColor = true;
            this.btnEditFont.Click += new System.EventHandler(this.btnEditFont_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(174, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 37);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FontCollectionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 471);
            this.Controls.Add(this.gbxFonts);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontCollectionEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Fonts";
            this.gbxFonts.ResumeLayout(false);
            this.gbxFonts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFonts;
        private System.Windows.Forms.ListBox lbxFonts;
        private System.Windows.Forms.Button btnAddFont;
        private System.Windows.Forms.Button btnRemoveFont;
        private System.Windows.Forms.Button btnEditFont;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
    }
}