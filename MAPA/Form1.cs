﻿using System;
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
            pictureBox1.Image = Image.FromFile(filename);
        }
    }
}
