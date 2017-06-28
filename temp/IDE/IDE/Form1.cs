using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IDEClass;

namespace IDE
{
    public partial class Form1 : Form
    {
        Graphics gp;

        myClass mc = new myClass();

        Pen redCo = new Pen(Color.Blue, 2);

        PointF[] Tg = new PointF[4];      // triangle with height
        
        float n = 1;

        int Xb, Yb, Xe, Ye;

        public Form1()
        {
            InitializeComponent();
            gp = pictureBox1.CreateGraphics();
            Xb = 5; Yb = 5;
            Xe = pictureBox1.Size.Width; Ye = pictureBox1.Size.Height;
        }

        private void drawCo()
        {
            gp.Clear(Color.White);
            for (int i = 0; i < mc.count; i++)
                gp.DrawEllipse(redCo, mc.Pt[i].X - 1, mc.Pt[i].Y - 1, 2, 2);
        }

        public void draw_from_tab()
        {
            gp.Clear(Color.White);
            if (mc.count == 0)
                MessageBox.Show("No points were added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (mc.count == 1)
                gp.DrawEllipse(redCo, Xe / 2 - 1, Ye / 2 - 1, 2, 2);

            if (mc.count > 1)
            {
                float Xmin = mc.Pt[0].X, Ymin = mc.Pt[0].Y, Xmax = Xmin, Ymax = Ymin;

                for (int i = 1; i < mc.count; i++)
                {
                    if (mc.Pt[i].X < Xmin)      // find minimum value of X-coordinates
                        Xmin = mc.Pt[i].X;
                    if (mc.Pt[i].X > Xmax)
                        Xmax = mc.Pt[i].X;      // find maximum value of X-coordinates

                    if (mc.Pt[i].Y < Ymin)
                        Ymin = mc.Pt[i].Y;      // find minimum value of Y-coordinates
                    if (mc.Pt[i].Y > Ymax)
                        Ymax = mc.Pt[i].Y;      // find minimum value of Y-coordinates
                }

                float dx = (Xmax - Xmin) / Xe, dy = (Ymax - Ymin) / Ye;

                PointF[] E = new PointF[mc.count];
                for (int i = 0; i < mc.count; i++)
                {
                    E[i] = mc.fix_size(mc.Pt[i], (int)pictureBox1.Width / 2, (int)pictureBox1.Height / 2, dx, dy);
                    gp.DrawEllipse(redCo, E[i].X - 1, E[i].Y - 1, 2, 2);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool Err = false;
            try
            {
                double zx = double.Parse(editX.Text);
                double zy = double.Parse(editY.Text);
            }
            catch
            {
                Err = true;
                if (MessageBox.Show("Invalid input. Try again!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Close();
            }

            if (!Err)
            {
                PointF M = new PointF();
                M.X = float.Parse(editX.Text);
                M.Y = float.Parse(editY.Text);

                //if (M.X < 0 || M.X > pictureBox1.Width || M.Y < 0 || M.Y > pictureBox1.Height)
                    //MessageBox.Show("Invalid point! Given point is out of allowed range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else
                {
                    if (mc.existCo(M))
                    {
                        MessageBox.Show("Same point was added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        mc.Pt[mc.count++] = M;
                        tab.Rows.Add(editX.Text, editY.Text);
                        gp.DrawEllipse(redCo, M.X - 1, M.Y - 1, 2, 2);
                        editX.Clear(); editY.Clear();
                    }
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (mc.count > 0)
            {
                bool Err = false;
                try
                {
                    double zx = double.Parse(editX.Text);
                    double zy = double.Parse(editY.Text);
                }
                catch
                {
                    Err = true;
                    if (MessageBox.Show("Invalid input. Try again!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                        Close();
                }

                if (!Err)
                {
                    PointF M = new PointF();
                    M.X = float.Parse(editX.Text);
                    M.Y = float.Parse(editY.Text);

                    if (mc.removeCo(M) == false)
                        MessageBox.Show("Point does not match! Try again..", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    else
                    {
                        for (int i = 0; i < mc.count; i++ )
                        {
                            tab.Rows[i].Cells[0].Value = mc.Pt[i].X.ToString();
                            tab.Rows[i].Cells[1].Value = mc.Pt[i].Y.ToString();
                        }
                        
                        tab.RowCount--;

                        editX.Clear(); editY.Clear();
                        drawCo();
                    }
                }
            }
            else
                MessageBox.Show("No point was found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            resetBtn_Click(sender, e);
            gp.DrawEllipse(redCo, e.X - 1, e.Y - 1, 2, 2);
            
            PointF M = new PointF();
            M.X = e.X;
            M.Y = e.Y;

            mc.Pt[mc.count++] = M;

            tab.Rows.Add(e.X.ToString(), e.Y.ToString());
        }

        private void tab_MouseClick(object sender, MouseEventArgs e)
        {
            int i = tab.CurrentRow.Index;
            editX.Text = tab.Rows[i].Cells[0].Value.ToString();
            editY.Text = tab.Rows[i].Cells[1].Value.ToString();
            
            drawCo();
            gp.DrawEllipse(new Pen(Color.Red, 2), float.Parse(editX.Text) - 1, float.Parse(editY.Text) - 1, 2, 2);
        }

        private void drawTriangle(PointF[] Tg, PointF H)
        {
            // draw MAX height here
            Pen side = new Pen(Color.Green, 2);

            gp.DrawLine(new Pen(Color.YellowGreen), Tg[1], Tg[3]);
            gp.DrawLine(new Pen(Color.Red, 1.5F), Tg[0], Tg[3]);
            gp.DrawLine(side, Tg[0], Tg[1]);
            gp.DrawLine(side, Tg[1], Tg[2]);
            gp.DrawLine(side, Tg[2], Tg[0]);      // draw sides
            
            Pen top = new Pen(Color.OrangeRed, 2);

            gp.DrawEllipse(top, Tg[0].X - 1, Tg[0].Y - 1, 2, 2);
            gp.DrawEllipse(top, Tg[1].X - 1, Tg[1].Y - 1, 2, 2);
            gp.DrawEllipse(top, Tg[2].X - 1, Tg[2].Y - 1, 2, 2);
            gp.DrawEllipse(new Pen(Color.Purple, 2), Tg[3].X - 1, Tg[3].Y - 1, 2, 2);
            
            Font let = new System.Drawing.Font(new FontFamily("Microsoft Sans Serif"), 10 * n);
            gp.DrawString("A", let, new SolidBrush(Color.SteelBlue), Tg[0]);
            gp.DrawString("B", let, new SolidBrush(Color.SteelBlue), Tg[1]);
            gp.DrawString("C", let, new SolidBrush(Color.SteelBlue), Tg[2]);
            gp.DrawString("H(" + H.X.ToString("F2") + "; " + H.Y.ToString("F2") + ")", let, new SolidBrush(Color.SteelBlue), Tg[3]);
        }

        private void solutionBtn_Click(object sender, EventArgs e)
        {
            n = 1;
            if (mc.count < 3)
                MessageBox.Show("No solution found! Given points was not enough, add more points and try again!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int i, j, k;
                double minH = 0;

                for (i = 2; i < mc.count; i++)
                {
                    minH = mc.maxHeights(mc.Pt[0], mc.Pt[1], mc.Pt[i]);
                    if (minH > 0)
                        break;
                }

                if (minH == 0)
                    MessageBox.Show("Solution is not found!", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int[] setMin = new int[3];

                    setMin[0] = 0; setMin[1] = 1; setMin[2] = 2;

                    double tmp;

                    for (i = 0; i < mc.count; i++)
                        for (j = i + 1; j < mc.count; j++)
                            for (k = j + 1; k < mc.count; k++)
                            {
                                tmp = mc.maxHeights(mc.Pt[i], mc.Pt[j], mc.Pt[k]);

                                if ((tmp < minH) && (tmp > 0))
                                {
                                    minH = tmp;
                                    setMin[0] = i; setMin[1] = j; setMin[2] = k;
                                }
                            }

                    Tg[0] = mc.Pt[setMin[0]]; Tg[1] = mc.Pt[setMin[1]]; Tg[2] = mc.Pt[setMin[2]];
                    double h_a = mc.distance(Tg[0], Tg[1], Tg[2]);
                    double h_b = mc.distance(Tg[1], Tg[2], Tg[0]);
                    double h_c = mc.distance(Tg[2], Tg[0], Tg[1]);
                    double max = Math.Max(Math.Max(h_a, h_b), h_c);

                    PointF tz = new PointF();
                    if (h_b == max)
                    {
                        tz = Tg[1]; Tg[1] = Tg[0]; Tg[1] = tz;
                    }

                    if (h_c == max)
                    {
                        tz = Tg[2]; Tg[2] = Tg[0]; Tg[0] = tz;
                    }

                    Tg[3].X = ((Tg[1].X * Tg[2].Y - Tg[1].Y * Tg[2].X) * (Tg[2].Y - Tg[1].Y) + (Tg[2].X - Tg[1].X) * (Tg[0].X * (Tg[2].X - Tg[1].X)
                            + Tg[0].Y * (Tg[2].Y - Tg[1].Y))) / ((Tg[2].Y - Tg[1].Y) * (Tg[2].Y - Tg[1].Y) + (Tg[2].X - Tg[1].X) * (Tg[2].X - Tg[1].X));

                    Tg[3].Y = ((Tg[1].X * Tg[2].Y - Tg[1].Y * Tg[2].X) * (Tg[1].X - Tg[2].X) + (Tg[2].Y - Tg[1].Y) * (Tg[0].X * (Tg[2].X - Tg[1].X)
                            + Tg[0].Y * (Tg[2].Y - Tg[1].Y))) / ((Tg[2].Y - Tg[1].Y) * (Tg[2].Y - Tg[1].Y) + (Tg[2].X - Tg[1].X) * (Tg[2].X - Tg[1].X));

                    drawCo();
                    drawTriangle(Tg, Tg[3]);

                    MessageBox.Show("FOUND: Min(max heights) = " + minH.ToString() + "\n\nTriangle: "
                                    + "A(" + Tg[0].X.ToString() + ", " + Tg[0].Y.ToString() + "); "
                                    + "B(" + Tg[1].X.ToString() + ", " + Tg[1].Y.ToString() + "); "
                                    + "C(" + Tg[2].X.ToString() + ", " + Tg[2].Y.ToString() + ")."
                                    , "Solution");
                }
            }
        }

        private void proBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program: Find triangle, satisfying that it's maximum height is the MINIMUM value of all triangles, which were created by given points.\n\n"
                            + "Notice:\n\t(1) Max size: " + pictureBox1.Width.ToString() + "x" + pictureBox1.Height.ToString() + "\n"
                            + "\t(2) Given coordinates of points can not be same!", "About");
        }

        private void editX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                editY.Focus();
        }

        private void zoomBtn_Click(object sender, EventArgs e)
        {
            n += 0.5F;
            
            PointF G = new PointF(), H = Tg[3];
            G.X = (Tg[0].X + Tg[1].X + Tg[2].X) / 3;
            G.Y = (Tg[0].Y + Tg[1].Y + Tg[2].Y) / 3;
            
            float dx = pictureBox1.Width/2 - G.X, dy = pictureBox1.Height/2 - G.Y;
            
            G.X = pictureBox1.Width / 2; G.Y = pictureBox1.Height / 2;
            
            Tg[0].X += dx; Tg[0].Y += dy;
            Tg[1].X += dx; Tg[1].Y += dy;
            Tg[2].X += dx; Tg[2].Y += dy;
            Tg[3].X += dx; Tg[3].Y += dy;

            for (int i = 0; i < 4; i++)
            {
                Tg[i].X = G.X + (Tg[i].X - G.X) * n;
                Tg[i].Y = G.Y + (Tg[i].Y - G.Y) * n;
            }

            gp.Clear(Color.White);
            drawTriangle(Tg, H);
        }

        private void unzBtn_Click(object sender, EventArgs e)
        {
            n = 1;
            solutionBtn_Click(sender, e);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            n = 1;
            drawCo();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tab.RowCount = 0;
            gp.Clear(Color.White);
            for (int i = mc.count - 1; i >= 0; i--)
            {
                mc.removeCo(mc.Pt[i]);
            }
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            draw_from_tab();
        }
    }
}
