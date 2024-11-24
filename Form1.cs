using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApplication
{
    public partial class Form1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
