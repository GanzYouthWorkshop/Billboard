using GEV.API.Templating;
using Lumino.Store;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumino.Compiler
{
    public class ArduinoCompiler
    {
        private static Process exeProcess;

        public static event EventHandler<string> Message;
        public static event EventHandler<int> Finished;

        public static void CompileAndUploadProject(Billboard board, string port)
        {
            string firmwareTemplate = File.ReadAllText(@".\Firmware\firmware.ino");

            byte[] data = CreateByteArray(Globals.Fonts.First(f => f.Name == board.Font), board.Message);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "DisplayWidth", board.DisplayWidth },
                { "FrameWidth", board.FrameWidth },
                { "FrameDuration", board.FrameUpdateInterval },

                { "DataLength", data.Length },
                { "Data", String.Join(",", data) },
            };
            string fiwmrare = TextTemplate.FilOutTemplate(firmwareTemplate, parameters);



            string file = AppDomain.CurrentDomain.BaseDirectory + @"Compiler\board\board.ino";


            if (File.Exists(file))
            {
                File.Delete(file);
            }
            File.WriteAllText(file, fiwmrare);

            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = @".\Compiler\arduino_debug.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.Arguments = "--upload --board arduino:avr:uno --port "+port+" " + "\"" + file + "\"";

            exeProcess = new Process()
            {
                StartInfo = startInfo
            };

            exeProcess.EnableRaisingEvents = true;
            exeProcess.OutputDataReceived += ExeProcess_OutputDataReceived; ;
            exeProcess.Exited += ExeProcess_Exited;
            exeProcess.Start();
            exeProcess.BeginOutputReadLine();
        }

        private static void ExeProcess_Exited(object sender, EventArgs e)
        {
            Finished?.Invoke(null, exeProcess.ExitCode);
        }

        private static void ExeProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Message?.Invoke(null, e.Data);
        }

        private static byte[] CreateByteArray(Font font, string message, int spacing = 25)
        {
            List<byte> result = new List<byte>();

            for (int i = 0; i < spacing; i++)
            {
                result.Add(0);
            }

            foreach (char c in message)
            {
                Character glyph = font.Characters.FirstOrDefault(g => g.CharacterValue == c.ToString());

                if (glyph != null)
                {
                    foreach (byte b in glyph.Glyph)
                    {
                        result.Add(b);
                    }
                }
                else
                {
                    result.AddRange(new byte[] { 0, 0, 0, 0, 0, 0 });
                }
            }

            for (int i = 0; i < spacing; i++)
            {
                result.Add(0);
            }

            return result.ToArray();
        }
    }
}
