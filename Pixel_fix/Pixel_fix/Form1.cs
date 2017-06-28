using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PixelClass;

namespace Pixel_fix
{
    public partial class Pixel : Form
    {
        Pixels pc = new Pixels();
        Graphics g;
        
        public Pixel()
        {
            InitializeComponent();
            g = pBox.CreateGraphics();
        }

        private void line(PointF[] m, int n, Color c)
        {
            Pen pen = new Pen(c, 2);
            for (int i = 0; i < n - 1; i++)
                g.DrawLine(pen, m[i], m[i + 1]);
            g.DrawLine(pen, m[n - 1], m[0]);
            //MessageBox.Show("ok");
        }

        private void draw(Color c)
        {
            line(pc.face, 3600, c);
            line(pc.nose, 3, c);
            line(pc.mouth, 3, c);
            line(pc.eye_lf, 3600, c);
            line(pc.eye_rt, 3600, c);
        }

        private void defaultBtn_Click(object sender, EventArgs e)
        {
            int xdef = (int)float.Parse(Xdef.Text), ydef = (int)float.Parse(Ydef.Text);
            int r = (int)float.Parse(Rdef.Text);

            pc.init(xdef, ydef, r);
            g.Clear(Color.WhiteSmoke);
            draw(Color.Black);
        }

        private void pBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Xdef.Text = e.X.ToString();
                Ydef.Text = e.Y.ToString();
                g.Clear(Color.WhiteSmoke);
                g.DrawEllipse(new Pen(Color.Green, 2), e.X - 1, e.Y - 1, 2, 2);
            }

            if (e.Button == MouseButtons.Left)
            {
                CX.Text = e.X.ToString();
                CY.Text = e.Y.ToString();
                g.DrawEllipse(new Pen(Color.LimeGreen, 2), e.X - 1, e.Y - 1, 2, 2);
            }
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            int dx = (int)float.Parse(DX.Text), dy = (int)float.Parse(DY.Text);
            int x0 = (int)float.Parse(Xdef.Text), y0 = (int)float.Parse(Ydef.Text);
            
            g.Clear(Color.WhiteSmoke);
            draw(Color.Gray);

            pc.move(dx, dy);
            draw(Color.Black);

            g.DrawLine(new Pen(Color.OrangeRed, 1), x0, y0, x0 + dx, y0 + dy);

            Pen blue = new Pen(Color.Blue, 2);
            g.DrawEllipse(blue, x0 - 1, y0 - 1, 2, 2);
            g.DrawEllipse(blue, x0 + dx - 1, y0 + dy - 1, 2, 2);

            Xdef.Text = (x0 + dx).ToString(); Ydef.Text = (y0 + dy).ToString();
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            int xc = (int)float.Parse(CX.Text), yc = (int)float.Parse(CY.Text);
            int x0 = (int)float.Parse(Xdef.Text), y0 = (int)float.Parse(Ydef.Text);
            int angle = (int)float.Parse(Angle.Text);

            g.Clear(Color.WhiteSmoke);
            draw(Color.Gray);

            pc.rotate(xc, yc, angle);
            draw(Color.Black);

            Pen orange = new Pen(Color.OrangeRed, 1);
            PointF Rt = new PointF(x0, y0);
            g.DrawLine(orange, xc, yc, x0 , y0);
            Rt = pc.rotate_point(Rt, xc, yc, angle);
            g.DrawLine(orange, xc, yc, Rt.X, Rt.Y);

            g.DrawEllipse(new Pen(Color.Blue, 2), xc - 1, yc - 1, 2, 2);
            Xdef.Text = Rt.X.ToString(); Ydef.Text = Rt.Y.ToString();
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            float tx = float.Parse(timeX.Text), ty = float.Parse(timeY.Text);

            int xc = (int)float.Parse(CX.Text), yc = (int)float.Parse(CY.Text);
            int x0 = (int)float.Parse(Xdef.Text), y0 = (int)float.Parse(Ydef.Text);

            g.Clear(Color.WhiteSmoke);
            draw(Color.Gray);

            pc.resize(xc, yc, tx, ty);
            draw(Color.Black);

            Pen orange = new Pen(Color.OrangeRed, 1);
            PointF Rt = new PointF(x0, y0);
            g.DrawLine(orange, xc, yc, x0, y0);
            Rt = pc.fix_size(Rt, xc, yc, tx, ty);
            g.DrawLine(orange, xc, yc, Rt.X, Rt.Y);

            Pen blue = new Pen(Color.Blue, 2);
            g.DrawEllipse(blue, xc - 1, yc - 1, 2, 2);
            g.DrawEllipse(blue, x0 - 1, y0 - 1, 2, 2);
            g.DrawEllipse(blue, Rt.X - 1, Rt.Y - 1, 2, 2);

            Xdef.Text = Rt.X.ToString(); Ydef.Text = Rt.Y.ToString();
                
            float R = float.Parse(Rdef.Text);
            Rdef.Text = (R * tx).ToString();
        }
    }
}
