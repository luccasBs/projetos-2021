using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoinho2
{
    public partial class Zoinho : Form
    {
        string[] anima = {
            "ANIMATAC 001.ICO","ANIMATAC 002.ICO",
            "ANIMATAC 003.ICO","ANIMATAC 004.ICO",
            "ANIMATAC 005.ICO","ANIMATAC 006.ICO",
            "ANIMATAC 007.ICO","ANIMATAC 008.ICO",
            "ANIMATAC 009.ICO","ANIMATAC 010.ICO",
            "ANIMATAC 011.ICO"
        };
        
        int i = 0;

        string ExtractPath(string FileName)
        {
            int i;
            for (i = FileName.Length - 1; i >= 0; i--)
            {
                if (FileName[i].CompareTo((char)92) == 0)
                    break;
            }
            return FileName.Substring(0, i) + (char)92;

        }



        public Zoinho()
        {
            InitializeComponent();
        }

        private Point ChangeAxis(Point pOrigin, Point pRes)
        {
            pRes.X = pRes.X - pOrigin.X;
            pRes.Y = pRes.Y - pOrigin.Y;
            return pRes;
        }


        private double pointsToAngle(Point p)
        {
            double h, seno, alfa;
            h = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            
            if (h != 0) seno = p.Y / h; else seno = 0;
            
            alfa = Math.Asin(seno);
           
            alfa = 360 * alfa / (2 * Math.PI);
            
            if (p.X < 0 && p.Y > 0) alfa = 180 - Math.Abs(alfa);
            if (p.X < 0 && p.Y < 0) alfa = Math.Abs(alfa) + 180;
            if (p.X > 0 && p.Y < 0) alfa = 360 - Math.Abs(alfa);
            return alfa;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p1, p2;
            
            int i;
            double alfa;

            p1 = System.Windows.Forms.Cursor.Position;
            label2.Text = "X =" + System.Windows.Forms.Cursor.Position.X.ToString("0.00") +
            "Y =" + System.Windows.Forms.Cursor.Position.Y.ToString("0.00");
            p2 = new Point(Left + pictureBox1.Left + pictureBox1.Width / 2,
            Top + pictureBox1.Top + (Height - ClientSize.Height) + pictureBox1.Height / 2);
            p1 = ChangeAxis(p2, p1);
            alfa = pointsToAngle(p1);
            i = 1;
            
            if ((alfa > 337.5) || (alfa < 22.5)) i = 1;
            else if ((alfa >= 22.5) && (alfa < 67.7)) i = 2;
            else if ((alfa >= 67.5) && (alfa < 112.5)) i = 3;
            else if ((alfa >= 112.5) && (alfa < 157.5)) i = 4;
            else if ((alfa >= 157.5) && (alfa < 202.5)) i = 5;
            else if ((alfa >= 202.5) && (alfa < 247.5)) i = 6;
            else if ((alfa >= 247.5) && (alfa < 292.5)) i = 7;
            else if ((alfa >= 292.5) && (alfa < 337.5)) i = 8;

            pictureBox1.Image = imageList1.Images[i];

            label2.Text = "X = " + p1.X.ToString("0.00") +
            " Y = " + p1.Y.ToString("0.00");

            label6.Text = alfa.ToString("0.00");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[9];
            pictureBox1.Update();
            Thread.Sleep(750);
            pictureBox1.Image = imageList1.Images[10];
            pictureBox1.Update();
            Thread.Sleep(750);
            Close();
        }
    }
}
