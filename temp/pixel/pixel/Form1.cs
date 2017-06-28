using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pixel
{
    public partial class Form1 : Form
    {
        Graphics myGraphics;

        public Form1()
        {
            InitializeComponent();
            myGraphics = pictureBox1.CreateGraphics();
        }
        
        void PutPixel(Graphics g, int x, int y, Color c)
        {
            Bitmap bm = new Bitmap(1, 1);
            bm.SetPixel(0, 0, Color.Black);
            g.DrawImageUnscaled(bm, x, y);
        }
        Pen black = new Pen(Color.Black, 2);
        Point[] f = new Point[360];

        private void button1_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(Color.White);
            
            double radius = 30;
            
            for (double i = 0.0; i < 360.0; i += 1)
            {
                double angle = i * System.Math.PI / 180;
                int x = (int)(200 + 2* radius * System.Math.Cos(angle));
                int y = (int)(150 + 3* radius * System.Math.Sin(angle));
                f[(int)i].X = x; f[(int)i].Y = y;
//                PutPixel(myGraphics, x, y, Color.Black);
                //System.Threading.Thread.Sleep(1); // If you want to draw circle very slowly.
            }
            //for (int i = 0; i < 360; i++)
            myGraphics.DrawLines(black, f);
            myGraphics.DrawLine(black, f[359], f[0]);

            //    myGraphics.Dispose();
        }
    }
}
