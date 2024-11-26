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
        private string content = "";
        private string filePath = Path.GetTempPath()+@"\songlist.txt";
        
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private bool isPlaying = true;
        private string[] songs = null;
        private int currentSong = 0;
        private string[] lines = new string[2];
        private Timer timer;
        public Form1()
        {
        
            // If temp file does not exist creates temp file
            if (!System.IO.File.Exists(filePath))
            {
                File.Create(filePath);
            }
            
            // Checks if file is not empty
            if (File.ReadAllLines(filePath).Length>0)
            {   
                // Gets the info that app used previously
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

                // Gets mp3 files in the destinated folder
                songs = Directory.GetFiles(lines[0], "*.mp3");
                   
            }

            else
            {   
                // If temp file is empty writes the temp file
                lines = new string[2];
                lines[0] = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                lines[1] = 0+"";
                currentSong = 0;
                File.WriteAllLines(filePath, lines);
                songs = Directory.GetFiles(lines[0], "*.mp3");

            }

            // Initializes audio input
            try
            {
                audioFile = new AudioFileReader(songs[currentSong]);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Volume = (float)1 / 2;
                
                outputDevice.Volume = (float)1/2 ;
            }
            catch (Exception ex)
            {
            }
            

            // Initializes the components and timer
            InitializeComponent();
            listBox.Items.Clear();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            try
            {
                
            }
            catch(Exception e)
            {
                timeSlider.Maximum = 100;
            }
            

            // Adds songs to the listbox
            foreach (var songPath in songs)
            {
                if (songPath != null)
                {
                    listBox.Items.Add(Path.GetFileName(songPath)); // Sadece dosya adını al
                }
            }
           
        }
   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Selects a file and adds all mp3 files in the selected file to the songs array
        private void openButton_Click(object sender, EventArgs e)
        {
            
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Choose a folder to open music files!";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    listBox.Items.Clear();

                    songLabel.Text = lines.Length + "";

                    lines[0] = folderBrowserDialog.SelectedPath;
                    lines[1] = 0 + "";
                    currentSong = 0;

                    File.WriteAllLines(filePath, lines);
                    songs = Directory.GetFiles(lines[0], "*.mp3");

                    foreach (var filePath in songs)
                    {
                        listBox.Items.Add(Path.GetFileName(filePath)); 
                    }


                }

            }


        }

        // Pauses or plays the song
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

        // Calls next song 
        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (currentSong != songs.Length-1)
            {
                currentSong++;
                listBox.SelectedIndex = currentSong;
                lines[1] = currentSong + "";
                File.WriteAllLines(filePath, lines, Encoding.UTF8);
                Play();
                isPlaying = !isPlaying ;
                isPlaying = !isPlaying;

            }
            else
            {
                songLabel.Text = "Cannot go next from the last row of the list!";
                timeSlider.Maximum = (int)audioFile.TotalTime.TotalSeconds;
            }
            
        }

        // Calls previous song 
        private void backButton_Click(object sender, EventArgs e)
        {
            if (currentSong != 0)
            {
                currentSong--;
                listBox.SelectedIndex = currentSong;
                lines[1] = currentSong + "";
                File.WriteAllLines(filePath, lines, Encoding.UTF8);
                Play();
                isPlaying = !isPlaying;
            }
            else
            {
                songLabel.Text = "Cannot go back from the first row of the list!";
            }

            

        }

        // When listbox index changed changes the current song
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lines[1] = listBox.SelectedIndex + "";
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
            
            currentSong = Int32.Parse(lines[1]);
            timeSlider.Maximum = (int)audioFile.TotalTime.TotalSeconds;
            Play();

        }

        // Change song algorithm
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

        // When volume slider value changed, changes the audio volume
        private void volumeSlider_Scroll(object sender, EventArgs e)
        {
            outputDevice.Volume = (float)volumeSlider.Value/100; 
        }

        // Timer method
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan current = audioFile.CurrentTime;
            TimeSpan total = audioFile.TotalTime;

            currentTime.Text = $"Current time: {current.Minutes}:{current.Seconds}";
            totalTime.Text = $"Total Time: {total.Minutes}:{total.Seconds}";
            timeSlider.Value = (int)audioFile.CurrentTime.TotalSeconds;
        }


        // When time slider value is changed changes the current time on the timer
        private void timeSlider_Scroll(object sender, EventArgs e)
        {
            audioFile.CurrentTime = TimeSpan.FromSeconds(timeSlider.Value);
        }
    }


}

