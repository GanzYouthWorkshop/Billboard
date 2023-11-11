using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumino
{
    public partial class CharacterEditor : Form
    {
        public Character ResultCharacter { get; set; }

        public CharacterEditor(Character chara)
        {
            InitializeComponent();

            this.ResultCharacter = chara;
            this.nudCharacterWidth.Value = this.ResultCharacter.Glyph.Count;
            this.tbxCharacterName.Text = this.ResultCharacter.CharacterValue;
            for(int i = 0; i < this.ResultCharacter.Glyph.Count; i++)
            {
                (this.pnlDisplay.Controls[i] as ColumnEditor).Values = this.ResultCharacter.Glyph[i];
            }
        }

        private void nudCharacterWidth_ValueChanged(object sender, EventArgs e)
        {       
            for(int i = 0; i < this.pnlDisplay.Controls.Count; i++)
            {
                bool en = (i < this.nudCharacterWidth.Value);
                this.pnlDisplay.Controls[i].Enabled = en;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ResultCharacter.CharacterValue = this.tbxCharacterName.Text;
            this.ResultCharacter.Glyph = new List<byte>();
            for(int i = 0; i < this.nudCharacterWidth.Value; i++)
            {
                this.ResultCharacter.Glyph.Add((this.pnlDisplay.Controls[i] as ColumnEditor).Values);
            }
        }
    }
}
