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
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(73, 370);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(154, 370);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause/Start";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(235, 370);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(75, 23);
            this.nextbutton.TabIndex = 2;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(134, 319);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(112, 45);
            this.volumeSlider.TabIndex = 3;
            // 
            // songImage
            // 
            this.songImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.songImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songImage.BackgroundImage")));
            this.songImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("songImage.ErrorImage")));
            this.songImage.Image = ((System.Drawing.Image)(resources.GetObject("songImage.Image")));
            this.songImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("songImage.InitialImage")));
            this.songImage.Location = new System.Drawing.Point(92, 7);
            this.songImage.Margin = new System.Windows.Forms.Padding(0);
            this.songImage.Name = "songImage";
            this.songImage.Size = new System.Drawing.Size(192, 208);
            this.songImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songImage.TabIndex = 4;
            this.songImage.TabStop = false;
            // 
            // timeSlider
            // 
            this.timeSlider.Location = new System.Drawing.Point(112, 399);
            this.timeSlider.Name = "timeSlider";
            this.timeSlider.Size = new System.Drawing.Size(143, 45);
            this.timeSlider.TabIndex = 5;
            // 
            // songLabel
            // 
            this.songLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.songLabel.Location = new System.Drawing.Point(0, 443);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(374, 13);
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
            this.openButton.Location = new System.Drawing.Point(334, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(20, 23);
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
            this.listBox.Location = new System.Drawing.Point(135, 218);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 91);
            this.listBox.TabIndex = 8;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 456);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.timeSlider);
            this.Controls.Add(this.songImage);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

