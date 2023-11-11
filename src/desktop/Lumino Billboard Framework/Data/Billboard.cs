using Lumino.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumino
{
    [Serializable]
    public class Billboard
    {
        public string Message { get; set; }
        public string Font { get; set; }

        public int DisplayWidth { get; set; }
        public int FrameWidth { get; set; }
        public int FrameUpdateInterval { get; set; }

        public byte[] CompileBillboard()
        {
            List<byte> result = new List<byte>();

            foreach (char c in this.Message)
            {
                Character glyph = Globals.Fonts.First(f => f.Name == this.Font).Characters.FirstOrDefault(g => g.CharacterValue == c.ToString());

                if (glyph != null)
                {
                    result.AddRange(glyph.Glyph);
                }
                else
                {
                    result.AddRange(new byte[] { 0, 0, 0, 0, 0, 0 });
                }
            }
            return result.ToArray();
        }
    }
}
