using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MAPA
{
    public partial class Form1 : Form
    {
        OpenFileDialog fd = new OpenFileDialog();
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            string filename = fd.FileName;
            pictureBox1.Image = Bitmap.FromFile(filename);
        }

        private void green_Click(object sender, EventArgs e)
        {
            Bitmap green = new Bitmap(pictureBox1.Image);
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            for (int x = 0; x < green.Width; x++)
            {
                for (int y = 0; y < green.Height; y++)
                {
                    Color p = green.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    if ((g == 0 || g > 0 && r / g > 0.5) || b / g > 0.5)
                    {
                        Color np = Color.White;
                        green.SetPixel(x, y, np);
                    }
                }
            }
            pictureBox1.Image = green;
        }
        private void negative_Click(object sender, EventArgs e)
        {
            Bitmap negative = new Bitmap(pictureBox1.Image);

            for (int x = 0; x < negative.Width; x++)
            {
                for (int y = 0; y < negative.Height; y++)
                {
                    Color p = negative.GetPixel(x, y);

                    int a = p.A;
                    int r = 255 - p.R;
                    int g = 255 - p.G;
                    int b = 255 - p.B;


                    Color np = Color.FromArgb(a, r, g, b);
                    negative.SetPixel(x, y, np);

                }
            }
            pictureBox1.Image = negative;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = pictureBox1.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = pictureBox1.Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = pictureBox1.Image;
        }
    }
}
