using Lumino.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumino.Forms
{
    public partial class FontCollectionEditor : Form
    {
        public FontCollectionEditor()
        {
            InitializeComponent();

            this.lbxFonts.DataSource = Globals.Fonts;
            this.lbxFonts.DisplayMember = "Name";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach(Font f in Globals.Fonts)
            {
                f.Save();
            }
        }

        private void btnAddFont_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text != "")
            {
                Globals.Fonts.Add(new Font(this.textBox1.Text));
            }                       
        }

        private void btnRemoveFont_Click(object sender, EventArgs e)
        {
            Globals.Fonts.Remove(this.lbxFonts.SelectedItem as Font);
        }

        private void btnEditFont_Click(object sender, EventArgs e)
        {
            new FontEditor(this.lbxFonts.SelectedItem as Font).ShowDialog();
        }
    }
}
