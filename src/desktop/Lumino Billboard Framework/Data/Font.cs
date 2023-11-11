using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lumino
{
    [Serializable]
    public class Font
    {
        public string Name { get; set; }
        public BindingList<Character> Characters { get; set; }

        public Font(string name)
        {
            this.Name = name;
            this.Characters = new BindingList<Character>();
        }

        public Font()
        {

        }

        public void Save()
        {
            if(Directory.Exists(@".\Fonts"))
            {
                Directory.CreateDirectory(@".\Fonts");
            }

            XmlSerializer ser = new XmlSerializer(typeof(Font));
            StreamWriter stream = new StreamWriter(String.Format(@".\Fonts\{0}.xml", this.Name));
            ser.Serialize(stream, this);
            stream.Close();
        }

        public static Font Load(string file)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Font));
            StreamReader stream = new StreamReader(file);
            Font result =  (Font)ser.Deserialize(stream);
            stream.Close();

            return result;
        }
    }
}
