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
            this.backButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.songImage = new System.Windows.Forms.PictureBox();
            this.timeSlider = new System.Windows.Forms.TrackBar();
            this.songLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(67, 366);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(148, 366);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause/Start";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(229, 366);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(75, 23);
            this.nextbutton.TabIndex = 2;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(126, 315);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(112, 45);
            this.volumeSlider.TabIndex = 3;
            // 
            // songImage
            // 
            this.songImage.Location = new System.Drawing.Point(102, 42);
            this.songImage.Name = "songImage";
            this.songImage.Size = new System.Drawing.Size(169, 145);
            this.songImage.TabIndex = 4;
            this.songImage.TabStop = false;
            // 
            // timeSlider
            // 
            this.timeSlider.Location = new System.Drawing.Point(116, 395);
            this.timeSlider.Name = "timeSlider";
            this.timeSlider.Size = new System.Drawing.Size(143, 45);
            this.timeSlider.TabIndex = 5;
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(158, 226);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(60, 13);
            this.songLabel.TabIndex = 6;
            this.songLabel.Text = "SongName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 452);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.timeSlider);
            this.Controls.Add(this.songImage);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

