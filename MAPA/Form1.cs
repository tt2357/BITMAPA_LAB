using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            filename = fd.FileName;
            pictureBox1.Image = Image.FromFile(filename);
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
