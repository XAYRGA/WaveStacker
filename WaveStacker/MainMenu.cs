using Be.IO;
using JaiSeqXLJA.DSP;
using libJAudio.Loaders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveStacker
{
  
    public partial class MainMenu : Form
    {
        public Dictionary<int, Dictionary<int, byte[]>> rebuildData;
        public MainMenu()
        {
            InitializeComponent();
            bxWaveGroups.Enabled = true;
            lbSoundID.Visible = false;
            lbSampleRate.Visible = false;
            lbLoopEnd.Visible = false;
            lbLoopStart.Visible = false;
            cbIsLoop.Visible = false;
            nuLoopEnd.Visible = false;
            nuLoopStart.Visible = false;
            btnReplace.Visible = false;
            btnPlay.Visible = false;
        }

        private void rebuildGroupList()
        {
            bxWaveGroups.Items.Clear(); // clear UI. 
            for (int i=0; i < root.currentWSYS.Groups.Length; i++)
            {
                bxWaveGroups.Items.Add($"Group {i} ({root.currentWSYS.Groups[i].awFile})");
            }
            bxWaveGroups.Enabled = true;
            lbSoundID.Visible = false;
            lbSampleRate.Visible= false;
            lbLoopEnd.Visible = false;
            lbLoopStart.Visible = false;
            nuLoopEnd.Visible = false;
            nuLoopStart.Visible = false;
            btnReplace.Visible = false;
            btnPlay.Visible = false;
        }


        private void rebuildWavesList()
        {
            bxWaveGroups.Enabled = true;
            lbSoundID.Visible = false;
            lbSampleRate.Visible = false;
            lbLoopEnd.Visible = false;
            lbLoopStart.Visible = false;
            nuLoopEnd.Visible = false;
            nuLoopStart.Visible = false;
            btnReplace.Visible = false;
            btnPlay.Visible = false;

            var grp = root.currentWSYS.Groups[root.currentGroupIndex];
            var scne = root.currentWSYS.Scenes[root.currentGroupIndex];
            wavesList.Items.Clear();
            for (int i = 0; i < grp.Waves.Length; i++)
            {
                wavesList.Items.Add($"Wave id={scne.CDFData[i].waveid},ws={scne.CDFData[i].awid}");
            }

        }

        private void openWSYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (root.currentWSYS != null)
            {
                if (MessageBox.Show("You currently have an open WSYS\nPress OK to continue, or Cancel to stop.", "Warning", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                root.currentWSYSStream.Close();
            }

            var ofd = new OpenFileDialog();
            ofd.Filter = "WaveSystem files(*.wsy;*.wsys;*.ws)|*.wsy;*.wsys;*.ws";
            var res = ofd.ShowDialog();
            if (res != DialogResult.OK)
                return;
            Console.WriteLine("Open WSYS....");
            var fHnd = File.Open(ofd.FileName,FileMode.Open,FileAccess.ReadWrite);
            Console.WriteLine("Handle created.");
            var binReader = new BeBinaryReader(fHnd);

            var wsys = new JA_WSYSLoader_V1().loadWSYS(binReader, 0x00000000);
            Console.WriteLine("WSYS parse successful!");
            root.currentWSYS = wsys;
            rebuildGroupList();
            wavesList.Items.Clear();
            root.rebuildMask = new bool[wsys.Groups.Length]; // all initialize to false
            root.currentWSYSStream = fHnd;
            rebuildData = new Dictionary<int, Dictionary<int, byte[]>>();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void updateWaveProperties()
        {
            var cidx = wavesList.SelectedIndex;
            if (cidx > root.currentWGroup.Waves.Length)
                return;
            lbSoundID.Visible = true;
            lbSampleRate.Visible = true;
            lbLoopEnd.Visible = true;
            lbLoopStart.Visible = true;
            nuLoopEnd.Visible = true;
            nuLoopStart.Visible = true;
            btnReplace.Visible = true;
            btnPlay.Visible = true;
            cbIsLoop.Visible = true;

  
            var cwave = root.currentWGroup.Waves[cidx];

            root.currentWave = cwave;
            root.currentWaveIndex = cidx;

            lbSoundID.Text = $"ID: {root.currentWSYS.Scenes[root.currentGroupIndex].CDFData[cidx].waveid}"; // sorry
            lbSampleRate.Text = $"SampleRate: {cwave.sampleRate}";
            cbIsLoop.Checked = cwave.loop;
            nuLoopStart.Value = cwave.loop_start;
            nuLoopEnd.Value = cwave.loop_end;
        }

        private void wavesList_SelectedIndexChanged(object sender, EventArgs e)
        {

            updateWaveProperties();
        }

        private void bxWaveGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bxWaveGroups.SelectedIndex > root.currentWSYS.Groups.Length)
                return;
            root.currentWGroup = root.currentWSYS.Groups[bxWaveGroups.SelectedIndex];
            root.currentGroupIndex = bxWaveGroups.SelectedIndex;
            rebuildWavesList();
        }

        private unsafe void btnReplace_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Wave Files files(*.wav)|*.wav";
            var res = ofd.ShowDialog();
            if (res != DialogResult.OK)
                return;
            var chn = 0;
            var bit = 0;
            var rate = 0;
            var sc = 0; 

            var wavFilePre = WAV.LoadWAVFromFileEX(ofd.FileName, out chn, out bit, out rate, out sc);
            if (rate > 32000)
            {
                MessageBox.Show("Sample Rate cannot exceed 32000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            root.currentWave.sampleRate = rate;
            root.currentWave.sampleCount = sc;

            byte[] adpcm_final = new byte[(sc / 9) * 16];
            var adp_f_pos = 0;
            
            // Yep, you're reading this right. I'm doing this in the UI thread. 
            fixed (byte* wavSamples = wavFilePre)
            {
                var hist0 = 0;
                var hist1 = 0;

                short* wavFP = (short*)wavSamples;
                Console.WriteLine($"Samples: {sc}");
                for (int i = 0; i < sc; i+=16)
                {
                    short[] wavIn = new short[16];
                    byte[] adpcmOut = new byte[9];
                    for (int k = 0; k < 16; k++)
                    {
                        wavIn[k] = wavFP[i + k];
                    }
                    flaaf.flaf_adpcm.Pcm16toAdpcm4(wavIn, adpcmOut, ref hist0, ref hist1);
                    for (int k = 0; k < 9; k++)
                    {
                        adpcm_final[adp_f_pos] = adpcmOut[k];
                        adp_f_pos++;
                    }
                }
            }

            updateWaveProperties();
            Console.WriteLine($"{sc},{rate}");
            if (!rebuildData.ContainsKey(root.currentGroupIndex))
                rebuildData[root.currentGroupIndex] = new Dictionary<int, byte[]>();
            rebuildData[root.currentGroupIndex][root.currentWaveIndex] = adpcm_final;
            //Console.WriteLine($"Sample Count is {sc}");
           
            root.rebuildMask[root.currentGroupIndex] = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var awFile = root.currentWGroup;
            var wavDesc = root.currentWave;
            Stream fStrm = null;
            try
            {
                fStrm = File.OpenRead(awFile.awFile);
            } catch
            {
                MessageBox.Show($"Failed to open '{awFile.awFile}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            byte[] tf = new byte[wavDesc.wsys_size];
            fStrm.Position = wavDesc.wsys_start;
            fStrm.Read(tf, 0, wavDesc.wsys_size);
            var ADP = ADPCM.ADPCMToPCM16(tf, ADPCM.ADPCMFormat.FOUR_BIT);
            var w = JAIDSP.SetupSoundBuffer(ADP, 1, (int)wavDesc.sampleRate, 0);
            var b = new JAIDSPVoice(ref w);
            b.play();
            fStrm.Close();
        }


        private void rebuildAw(int num)
        {
            var awTemp = File.OpenWrite("awBuild.temp");
            var grp = root.currentWSYS.Groups[num];
            var grpFile = grp.awFile;
            var awOriginal = File.OpenRead(grpFile);
            var wss = root.currentWSYSStream;
            var wsysWrite = new BeBinaryWriter(wss);
            var awWrite = new BeBinaryWriter(awTemp);
            var awRead = new BeBinaryReader(awOriginal);
            var awOffset = 0; 

            if (!rebuildData.ContainsKey(num))
                return;
            Console.WriteLine("Rebuild request found.");

            var rbdWaves = rebuildData[num];
            for (int i = 0; i < grp.Waves.Length; i++)
            {
                var originalWave = grp.Waves[i];
                byte[] awBuff;
                if (rbdWaves.ContainsKey(i))
                {
                    awBuff = rbdWaves[i];
                    Console.WriteLine("Injecting custom wave...");
                } else
                {                    
                    awRead.BaseStream.Position = originalWave.wsys_start;
                    awBuff = awRead.ReadBytes(originalWave.wsys_size);
                }
                awTemp.Write(awBuff, 0, awBuff.Length);
                wsysWrite.BaseStream.Position = originalWave.mOffset;
                wsysWrite.Seek(0x08, SeekOrigin.Current);
                wsysWrite.Write(awOffset);
                wsysWrite.Write(awBuff.Length);
                originalWave.wsys_start = awOffset; // update in-memory copies
                originalWave.wsys_size = awBuff.Length; // update in-memory copies
                awOffset += awBuff.Length;
                wsysWrite.Flush();
                awTemp.Flush();
            }
            Console.WriteLine($"Rebuilt {grpFile}");
            awTemp.Close();
            awRead.Close();
            awOriginal.Close();
            File.Delete(grpFile);
            File.Move("awBuild.temp", grpFile);            

        }
        private void rebuildWSYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < root.rebuildMask.Length; i++)
            {
                if (root.rebuildMask[i]!=false)
                {
                    Console.WriteLine("REBUILD AW. " + i);
                    rebuildAw(i);
                }
            }
            MessageBox.Show("Successfully rebuilt WSYS.");
        }
    }
}
