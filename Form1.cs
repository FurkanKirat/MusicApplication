using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace MusicApplication
{
    public partial class Form1 : Form
    {
        string content = "";
        string filePath = Path.GetTempPath()+@"\songlist.txt";
        
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        bool isPlaying = true;
        string[] songs = null;
        int currentSong = 0;
        string[] lines = new string[2];
        private Timer timer;
        public Form1()
        {   

            if (!System.IO.File.Exists(filePath))
            {
                File.Create(filePath);
            }
            
            if (File.ReadAllLines(filePath).Length>0)
            {
                lines = File.ReadAllLines(filePath);
                if (lines[1] != null)
                {
                    currentSong = Int32.Parse(lines[1]);
                }
                else
                {
                    currentSong = 0;
                    lines[1] = 0+"";
                }

                songs = Directory.GetFiles(lines[0], "*.mp3");
                   
            }

            else
            {
                lines = new string[2];
                lines[0] = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                lines[1] = 0+"";
                currentSong = 0;
                File.WriteAllLines(filePath, lines);
                songs = Directory.GetFiles(lines[0], "*.mp3");

            }
            try
            {
                audioFile = new AudioFileReader(songs[currentSong]);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Volume = (float)1 / 2;
            }
            catch (Exception ex)
            {
            }
            


            InitializeComponent();
            listBox.Items.Clear();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            foreach (var songPath in songs)
            {
                if (songPath != null)
                {
                    listBox.Items.Add(Path.GetFileName(songPath)); // Sadece dosya adını al
                }
            }
           
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            //// Çizim yüzeyi
            //Graphics graphics = e.Graphics;

            //// Gradyan fırça oluştur
            //using (LinearGradientBrush brush = new LinearGradientBrush(
            //    this.ClientRectangle, // Gradyan alanı
            //    Color.GreenYellow,           // Başlangıç rengi
            //    Color.LimeGreen,            // Bitiş rengi
            //    LinearGradientMode.ForwardDiagonal)) // Yön: Yatay
            //{
            //    // Gradyanı doldur
            //    graphics.FillRectangle(brush, this.ClientRectangle);
            //}
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }



        private void openButton_Click(object sender, EventArgs e)
        {
            
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Bir klasör seçin";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    listBox.Items.Clear();

                    songLabel.Text = lines.Length + "";
                    // Klasördeki MP3 dosyalarını listele

                    lines[0] = folderBrowserDialog.SelectedPath;
                    lines[1] = 0 + "";
                    currentSong = 0;

                    File.WriteAllLines(filePath, lines);
                    songs = Directory.GetFiles(lines[0], "*.mp3");

                    // ListBox'a ekle
                   
                    
                    foreach (var filePath in songs)
                    {
                        listBox.Items.Add(Path.GetFileName(filePath)); // Sadece dosya adını al
                    }


                }

            }


        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                outputDevice.Play();
                timer.Start();
            }
            else
            {
                outputDevice.Stop();
                timer.Stop();
            }
            isPlaying = !isPlaying;
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (currentSong != songs.Length-1)
            {
                currentSong++;
                listBox.SelectedIndex = currentSong;
                lines[1] = currentSong + "";
                File.WriteAllLines(filePath, lines, Encoding.UTF8);
                Play();
            }
            else
            {
                songLabel.Text = "Cannot go next from the last row of the list!";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (currentSong != 0)
            {
                currentSong--;
                listBox.SelectedIndex = currentSong;
                lines[1] = currentSong + "";
                File.WriteAllLines(filePath, lines, Encoding.UTF8);
                Play();
            }
            else
            {
                songLabel.Text = "Cannot go back from the first row of the list!";
            }
            
            
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lines[1] = listBox.SelectedIndex + "";
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
            
            currentSong = Int32.Parse(lines[1]);
            Play();

        }
        public void Play()
        {

            if (outputDevice != null)
            {
                outputDevice.Dispose();
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
            }

            audioFile = new AudioFileReader(songs[currentSong]);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);

            songLabel.Text = $"Playing: {songs[currentSong].Substring(songs[currentSong].LastIndexOf(@"\")+1)}";
        }

        private void volumeSlider_Scroll(object sender, EventArgs e)
        {
            outputDevice.Volume = (float)volumeSlider.Value/100; 
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan current = audioFile.CurrentTime;
            TimeSpan total = audioFile.TotalTime;

            currentTime.Text = $"Anlık süre: {current.Minutes}:{current.Seconds}";
            totalTime.Text = $"Toplam süre: {total.Minutes}:{total.Seconds}";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }


}

