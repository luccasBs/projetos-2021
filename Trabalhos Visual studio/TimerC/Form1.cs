using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerC
{
    public partial class Form1 : Form
    {
        int num = 0;
        int px;
        int py;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            px = pictureBox1.Location.X;
            py = pictureBox1.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnparar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void btnlargada_Click(object sender, EventArgs e)
        {
            timer_carro.Start();
        }

        private void btnparada_Click(object sender, EventArgs e)
        {
            timer_carro.Stop();
        }

        private void timer_carro_Tick(object sender, EventArgs e)
        {
            px += 10;
            if (px >= 600)
                {
                    px= 12;
                }
            pictureBox1.Location = new Point(px, py);
            px= pictureBox1.Location.X;
        }
    }
}
