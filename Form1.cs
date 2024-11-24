﻿using System;
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
        string filePath = @"C:%userprofile%\AppData\Local\Temp\songlist.txt";

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        bool isPlaying = true;
        string[] songs = null;
        int currentSong = 0;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Çizim yüzeyi
            Graphics graphics = e.Graphics;

            // Gradyan fırça oluştur
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, // Gradyan alanı
                Color.GreenYellow,           // Başlangıç rengi
                Color.LimeGreen,            // Bitiş rengi
                LinearGradientMode.ForwardDiagonal)) // Yön: Yatay
            {
                // Gradyanı doldur
                graphics.FillRectangle(brush, this.ClientRectangle);
            }
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
                    File.WriteAllText(filePath, folderBrowserDialog.SelectedPath);
                    string selectedPath = folderBrowserDialog.SelectedPath;

                    // Klasördeki MP3 dosyalarını listele
                    songs = Directory.GetFiles(selectedPath, "*.mp3");

                    // ListBox'a ekle
                    listBox.Items.Clear();
                    
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
            }
            else
            {
                outputDevice.Stop();
            }
            isPlaying = !isPlaying;
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSong = listBox.SelectedIndex;
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

    }


}

