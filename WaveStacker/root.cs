using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using libJAudio.Loaders;
using libJAudio;
using Be.IO;
using JaiSeqXLJA.DSP;

namespace WaveStacker
{
    public static class root
    {


        public static JWaveSystem currentWSYS;
        public static JWaveGroup currentWGroup;
        public static JWaveDescriptor currentWave;
        public static Stream currentWSYSStream;

        public static int currentWaveIndex; 
        public static int currentGroupIndex;
        public static string WSYSDrectory;
        public static bool[] rebuildMask;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            JAIDSP.Init();
            /*
            var by = File.ReadAllBytes("3.wsy");
            var bReader = new BeBinaryReader(new MemoryStream(by));
            var WSYSLoader = new JA_WSYSLoader_V1();
            var wsy0 = WSYSLoader.loadWSYS(bReader,0x00000000);
            //var ref0 = JsonConvert.SerializeObject(wsy0,Formatting.Indented);
            //File.WriteAllText("yes.json", ref0);

            // Console.WriteLine($"{wsy0.id} -- {wsy0.Scenes[4].CDFData.Length} @ {wsy0.Groups[4].Waves.Length} ");

            var tarcdf = wsy0.Scenes[0].CDFData;
            for (int i=0; i < tarcdf.Length; i++)
            {
                var ccdf = tarcdf[i];
                var cw1 = ccdf.awid;
               //Console.WriteLine($"{cw1} -- {wsy0.Groups[cw1]}");

            }
            */

            //Console.WriteLine(wsy0.Groups[0].awFile);
            //Console.ReadLine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
