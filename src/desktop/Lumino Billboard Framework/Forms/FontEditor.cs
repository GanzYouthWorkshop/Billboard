using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumino
{
    public partial class FontEditor : Form
    {
        public Font EditedFont { get; set; }
        public FontEditor(Font font)
        {
            this.EditedFont = font;

            InitializeComponent();

            this.lbxCharacters.DataSource = this.EditedFont.Characters;
            this.lbxCharacters.DisplayMember = "CharacterValue";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CharacterEditor editor = new CharacterEditor(this.lbxCharacters.SelectedItem as Character);

            if (editor.ShowDialog() == DialogResult.OK)
            {
                this.lbxCharacters.SelectedItem = editor.ResultCharacter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Character chara = new Character();
            this.EditedFont.Characters.Add(chara);
            CharacterEditor editor = new CharacterEditor(chara);

            if(editor.ShowDialog() == DialogResult.OK)
            {
                chara = editor.ResultCharacter;
            }
            else
            {
                this.EditedFont.Characters.Remove(chara);
            }
        }

        private void btnRemoveCharacter_Click(object sender, EventArgs e)
        {
            this.EditedFont.Characters.Remove(this.lbxCharacters.SelectedItem as Character);
        }
    }
}
