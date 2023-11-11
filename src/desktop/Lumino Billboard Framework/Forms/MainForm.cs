using Lumino.Compiler;
using Lumino.Forms;
using Lumino.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Lumino
{
    public partial class MainForm : Form
    {
        public BindingList<Font> Fonts { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.Fonts = new BindingList<Font>();

            if(Directory.Exists(@".\Fonts\"))
            {
                string[] files = Directory.GetFiles(@".\Fonts\", "*.xml");
                foreach(string file in files)
                {
                    try
                    {
                        Font f = Lumino.Font.Load(file);
                        Globals.Fonts.Add(f);
                        foreach(Character c in f.Characters)
                        {
                            c.TidyUpDeserialization();
                        }
                    }
                    catch { }
                }
            }
            else
            {
                Directory.CreateDirectory(@".\Fonts\");
            }

            this.cbxDisplayWidth.SelectedIndex = 0;

            this.cbxProgrammingPort.DataSource = SerialPort.GetPortNames();
            this.cbxProgrammingPort.Refresh();

            this.cbxFont.DataSource = Globals.Fonts;
            this.cbxFont.DisplayMember = "Name";

            ArduinoCompiler.Message += ArduinoCompiler_Message;
            ArduinoCompiler.Finished += ArduinoCompiler_Finished;
        }

        private void ArduinoCompiler_Finished(object sender, int e)
        {
            this.Invoke(new Action(() =>
            {
                this.button2.Enabled = true;
                MessageBox.Show(this, e == 0 ? "Billboard succesfully updated!" : String.Format("Something went wrong! Error code {0}", e));
            }));
        }

        private void ArduinoCompiler_Message(object sender, string e)
        {
            this.rtbLog.BeginInvoke(new Action(() => { if (e != null) this.rtbLog.AppendText(e + "\n"); }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int colCounter = 0;
            
            Font currentFont = this.cbxFont.SelectedItem as Font;

            List<byte> data = new List<byte>();
            foreach(char c in this.tbxMessage.Text)
            {
                Character glyph = currentFont.Characters.FirstOrDefault(g => g.CharacterValue == c.ToString());
                if(glyph != null)
                {
                    data.AddRange(glyph.Glyph);
                }
                else
                {
                    data.AddRange(new byte[]{0, 0, 0, 0, 0, 0 });
                }
            }

            Bitmap bmp = new Bitmap(data.Count * 10, 7 * 10);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int x = 0; x < data.Count; x++)
                {
                    for (int y = 0; y < 7; y++)
                    {
                        byte mask = (byte)(1 << (6 - y));
                        Brush color = (mask & data[x]) > 0 ? Brushes.Red : Brushes.Black;
                        g.FillRectangle(color, new Rectangle(x * 10, y * 10, 10, 10));
                    }
                }
            }

            this.pictureBox1.Image = bmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(BindingList<Font>));
            ser.Serialize(new StreamWriter("Fonts.xml"), this.Fonts);
        }

        private void betűkészletkezelőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FontCollectionEditor().ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Billboard board = new Billboard()
            {
                DisplayWidth = int.Parse(cbxDisplayWidth.SelectedItem.ToString()),
                Font = (this.cbxFont.SelectedItem as Font).Name,
                Message = this.tbxMessage.Text,
                FrameUpdateInterval = (int)nudFrameDuration.Value,
                FrameWidth = (int)nudFrameWidth.Value
            };
            ArduinoCompiler.CompileAndUploadProject(board, this.cbxProgrammingPort.SelectedItem.ToString());
            this.button2.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchPorts_Click(object sender, EventArgs e)
        {
            this.cbxProgrammingPort.DataSource = SerialPort.GetPortNames();
            this.cbxProgrammingPort.Refresh();
        }
    }
}
