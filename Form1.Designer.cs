using System.Drawing;
using System.Windows.Forms;

namespace MusicApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        ///
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {

                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.songImage = new System.Windows.Forms.PictureBox();
            this.timeSlider = new System.Windows.Forms.TrackBar();
            this.songLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.totalTime = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(97, 455);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(205, 455);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(100, 28);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause/Start";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(313, 455);
            this.nextbutton.Margin = new System.Windows.Forms.Padding(4);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(100, 28);
            this.nextbutton.TabIndex = 2;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(179, 393);
            this.volumeSlider.Margin = new System.Windows.Forms.Padding(4);
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(149, 56);
            this.volumeSlider.TabIndex = 3;
            this.volumeSlider.Value = 50;
            this.volumeSlider.Scroll += new System.EventHandler(this.volumeSlider_Scroll);
            // 
            // songImage
            // 
            this.songImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.songImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songImage.BackgroundImage")));
            this.songImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("songImage.ErrorImage")));
            this.songImage.Image = ((System.Drawing.Image)(resources.GetObject("songImage.Image")));
            this.songImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("songImage.InitialImage")));
            this.songImage.Location = new System.Drawing.Point(123, 9);
            this.songImage.Margin = new System.Windows.Forms.Padding(0);
            this.songImage.Name = "songImage";
            this.songImage.Size = new System.Drawing.Size(256, 256);
            this.songImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songImage.TabIndex = 4;
            this.songImage.TabStop = false;
            // 
            // timeSlider
            // 
            this.timeSlider.Location = new System.Drawing.Point(149, 491);
            this.timeSlider.Margin = new System.Windows.Forms.Padding(4);
            this.timeSlider.Name = "timeSlider";
            this.volumeSlider.Minimum = 0;
            this.volumeSlider.Value = 0;
            this.timeSlider.Size = new System.Drawing.Size(191, 56);
            this.timeSlider.TabIndex = 5;
            this.timeSlider.Scroll += new System.EventHandler(this.timeSlider_Scroll);
            // 
            // songLabel
            // 
            this.songLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.songLabel.Location = new System.Drawing.Point(0, 545);
            this.songLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(499, 16);
            this.songLabel.TabIndex = 6;
            this.songLabel.Text = "Song Name";
            this.songLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // openButton
            // 
            this.openButton.Image = global::MusicApplication.Properties.Resources.Ekran_görüntüsü_2024_07_21_021455;
            this.openButton.Location = new System.Drawing.Point(445, 15);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(27, 28);
            this.openButton.TabIndex = 7;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(180, 268);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(160, 112);
            this.listBox.TabIndex = 8;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Location = new System.Drawing.Point(357, 491);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(69, 16);
            this.totalTime.TabIndex = 9;
            this.totalTime.Text = "TotalTime";
            this.totalTime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(50, 491);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(80, 16);
            this.currentTime.TabIndex = 10;
            this.currentTime.Text = "CurrentTime";
            this.currentTime.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 561);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.timeSlider);
            this.Controls.Add(this.songImage);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Music App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.PictureBox songImage;
        private System.Windows.Forms.TrackBar timeSlider;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox listBox;
        private Label totalTime;
        private Label currentTime;
    }
}

