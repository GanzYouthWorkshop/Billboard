using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lumino
{
    [Serializable]
    public class Character
    {
        public string CharacterValue { get; set; } = "";

        [XmlArrayItem("Column")]
        public List<byte> Glyph { get; set; } = new List<byte>() { 0, 0, 0, 0, 0, 0 };

        public Character()
        {
        }

        public void TidyUpDeserialization()
        {
            this.Glyph.RemoveRange(0, 6);
        }
    }
}
