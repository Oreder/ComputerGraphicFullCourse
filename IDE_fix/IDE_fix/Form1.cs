using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IDE_fix_class;

namespace IDE_fix
{
    public partial class IDE : Form
    {
        Graphics g;
        Class   IE = new Class();
        
        Pen blueCo = new Pen(Color.Blue, 2);
        Pen  redCo = new Pen(Color.Red, 2);
        Point[] S = new Point[4];
        int dX, dY;
        float n = 1;

        public IDE()
        {
            InitializeComponent();
            g = view.CreateGraphics();
        }

        private bool exist()
        {
            for (int i = 0; i < tab.RowCount; i++)
                if ((editX.Text == (string) tab[0, i].Value) && (editY.Text == (string) tab[1, i].Value))
                    return true;
            return false;
        }   // check point existed or not

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool Err = false;       // check input errors
            try
            {
                float zx = float.Parse(editX.Text);
                float zy = float.Parse(editY.Text);
            }
            catch
            {
                Err = true;
                if (MessageBox.Show("Invalid input. Try again!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Close();
            }

            if (!Err)
            {
                if (exist())
                    MessageBox.Show("Same point was added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    tab.Rows.Add(editX.Text, editY.Text);
                    editX.Clear(); editY.Clear(); editX.Focus();
                    tab.CurrentCell = tab.Rows[tab.RowCount - 1].Cells[0];
                    draw();
                }
            }
        }   // add points

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (tab.RowCount > 0)
            {
                bool Err = false;        // check errors of removed point
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
                    if (!exist())
                        MessageBox.Show("Point does not match! Try again..", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    else
                    {
                        int i;
                        for (i = 0; i < tab.RowCount; i++)
                        {
                            if ((editX.Text == (string)tab[0, i].Value) && (editY.Text == (string)tab[1, i].Value))
                                break;
                        }
                        tab.Rows.RemoveAt(i);
                        editX.Clear(); editY.Clear();
                        draw();
                    }
                }
            }
            else
                MessageBox.Show("No point was found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
        }   // remove points
        
        private double draw()
        {
            double k = 1;
            g.Clear(Color.WhiteSmoke);
            if (tab.RowCount == 0)
                MessageBox.Show("Notice: No point now!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int i;
                Point[] P = new Point[tab.RowCount];
                for (i = 0; i < tab.RowCount; i++)
                {
                    P[i].X = (int)double.Parse((string)tab[0, i].Value);
                    P[i].Y = (int)double.Parse((string)tab[1, i].Value);
                }
                
                double minX = P[0].X, minY = P[0].Y, maxX = minX, maxY = minY;
                for (i = 1; i < tab.RowCount; i++)
                {
                    minX = Math.Min(P[i].X, minX);
                    maxX = Math.Max(P[i].X, maxX);
                    minY = Math.Min(P[i].Y, minY);
                    maxY = Math.Max(P[i].Y, maxY);
                }

                dX = view.Size.Width / 2 - (int)(maxX + minX) / 2;
                dY = view.Size.Height / 2 - (int)(maxY + minY) / 2;
                
                for (i = 0; i < tab.RowCount; i++)
                {
                    P[i].X += dX; P[i].Y += dY;
                }

                Point C = new Point(view.Size.Width / 2, view.Size.Height / 2);
                double dmax = IE.distance(C, P[0]);
                Point Pmax = P[0];
                for (i = 1; i < tab.RowCount; i++)
                {
                    if (IE.distance(C, P[i])  > dmax)
                    {
                        dmax = IE.distance(C, P[i]);
                        Pmax = P[i];
                    }
                }

                Point O = new Point(0, 0), E = new Point(view.Size.Width, view.Size.Height);
                
                if (!IE.in_range(Pmax, O, E))
                    k = Math.Abs(C.X / dmax) * 0.9;

                for (i = 0; i < tab.RowCount; i++)
                {
                    P[i].X = (int) (C.X + k * (P[i].X - C.X));
                    P[i].Y = (int) (C.Y + k * (P[i].Y - C.Y));

                    g.DrawEllipse(blueCo, P[i].X - 1, P[i].Y - 1, 2, 2);
                }
            }
            
            return k;
        }   // draw all points (only)

        private void tab_MouseClick(object sender, MouseEventArgs e)
        {
            int i = tab.CurrentRow.Index;
            editX.Text = (string) tab[0, i].Value;
            editY.Text = (string) tab[1, i].Value;
            
            double k = draw();
            Point z = new Point();
            z.X = (int)(k * (double.Parse(editX.Text) + dX - view.Size.Width / 2) + view.Size.Width / 2);
            z.Y = (int)(k * (double.Parse(editY.Text) + dY - view.Size.Height / 2) + view.Size.Height / 2);
            g.DrawEllipse(redCo, z.X - 1, z.Y - 1, 2, 2);
        }   // select rows

        private void drawTriangle(Point A, Point B, Point C, PointF H, double tmp)
        {
            A.X = (int)(tmp * (A.X + dX - view.Size.Width / 2) + view.Size.Width / 2);
            A.Y = (int)(tmp * (A.Y + dY - view.Size.Height / 2) + view.Size.Height / 2);

            B.X = (int)(tmp * (B.X + dX - view.Size.Width / 2) + view.Size.Width / 2);
            B.Y = (int)(tmp * (B.Y + dY - view.Size.Height / 2) + view.Size.Height / 2);

            C.X = (int)(tmp * (C.X + dX - view.Size.Width / 2) + view.Size.Width / 2);
            C.Y = (int)(tmp * (C.Y + dY - view.Size.Height / 2) + view.Size.Height / 2);

            H.X = (int)(tmp * (H.X + dX - view.Size.Width / 2) + view.Size.Width / 2);
            H.Y = (int)(tmp * (H.Y + dY - view.Size.Height / 2) + view.Size.Height / 2);

            S[0] = A; S[1] = B; S[2] = C; S[3].X = (int)H.X; S[3].Y = (int)H.Y;

            Pen side = new Pen(Color.Green, 2);

            g.DrawLine(new Pen(Color.YellowGreen), B, H);
            g.DrawLine(new Pen(Color.Red, 1.5F), A, H);
            g.DrawLine(side, A, B);
            g.DrawLine(side, B, C);
            g.DrawLine(side, C, A);      // draw sides
            
            Pen top = new Pen(Color.OrangeRed, 2);

            g.DrawEllipse(top, A.X - 1, A.Y - 1, 2, 2);
            g.DrawEllipse(top, B.X - 1, B.Y - 1, 2, 2);
            g.DrawEllipse(top, C.X - 1, C.Y - 1, 2, 2);
            g.DrawEllipse(new Pen(Color.Purple, 2), H.X - 1, H.Y - 1, 2, 2);
            
            Font let = new System.Drawing.Font(new FontFamily("Microsoft Sans Serif"), 10);
            g.DrawString("A", let, new SolidBrush(Color.SteelBlue), A);
            g.DrawString("B", let, new SolidBrush(Color.SteelBlue), B);
            g.DrawString("C", let, new SolidBrush(Color.SteelBlue), C);
            g.DrawString("H", let, new SolidBrush(Color.SteelBlue), H);
            //g.DrawString("H" + hX.ToString("F2") + "; " + hY.ToString("F2") + ")", let, new SolidBrush(Color.SteelBlue), H);
        }   // draw triangle (solve)

        private PointF identify(Point A, Point B, Point C)
        {
            float X = ((B.X * C.Y - B.Y * C.X) * (C.Y - B.Y) + (C.X - B.X) * (A.X * (C.X - B.X)
                    + A.Y * (C.Y - B.Y))) / ((C.Y - B.Y) * (C.Y - B.Y) + (C.X - B.X) * (C.X - B.X));

            float Y = ((B.X * C.Y - B.Y * C.X) * (B.X - C.X) + (C.Y - B.Y) * (A.X * (C.X - B.X)
                    + A.Y * (C.Y - B.Y))) / ((C.Y - B.Y) * (C.Y - B.Y) + (C.X - B.X) * (C.X - B.X));
            
            return (new PointF(X, Y));
        }   // identify coordinates of H

        private void solveBtn_Click(object sender, EventArgs e)
        {
            if (tab.RowCount < 3)
                MessageBox.Show("No solution found! Given points was not enough, add more points and try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int i, j, k;
                double minH = 0;

                Point[] P = new Point[tab.RowCount];
                for (i = 0; i < tab.RowCount; i++)
                {
                    P[i].X = (int)double.Parse((string)tab[0, i].Value);
                    P[i].Y = (int)double.Parse((string)tab[1, i].Value);
                }

                for (i = 2; i < tab.RowCount; i++)
                {
                    minH = IE.maxHeights(P[0], P[1], P[i]);
                    if (minH > 0)
                        break;
                }

                if (minH == 0)
                    MessageBox.Show("Solution is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int[] setMin = new int[3];
                    setMin[0] = 0; setMin[1] = 1; setMin[2] = i;
                    double tmp;

                    for (i = 0; i < tab.RowCount; i++)
                        for (j = i + 1; j < tab.RowCount; j++)
                            for (k = j + 1; k < tab.RowCount; k++)
                            {
                                tmp = IE.maxHeights(P[i], P[j], P[k]);
                                
                                if ((tmp < minH) && (tmp > 0))
                                {
                                    minH = tmp;
                                    setMin[0] = i; setMin[1] = j; setMin[2] = k;
                                }
                            }

                    i = setMin[0]; j = setMin[1]; k = setMin[2];

                    double h_a = IE.distance(P[i], P[j], P[k]),
                           h_b = IE.distance(P[j], P[k], P[i]),
                           h_c = IE.distance(P[k], P[i], P[j]);

                    double max = Math.Max(Math.Max(h_a, h_b), h_c);
                    if (h_b == max)
                    {
                        Point tp = P[j]; P[j] = P[i]; P[i] = tp;
                    }

                    if (h_c == max)
                    {
                        Point tp = P[k]; P[k] = P[i]; P[i] = tp;
                    }

                    PointF H = identify(P[i], P[j], P[k]);

                    MessageBox.Show("FOUND: Min(max heights) = " + minH.ToString() + "\n\nTriangle: "
                                    + "A(" + P[i].X.ToString() + ", " + P[i].Y.ToString() + "); "
                                    + "B(" + P[j].X.ToString() + ", " + P[j].Y.ToString() + "); "
                                    + "C(" + P[k].X.ToString() + ", " + P[k].Y.ToString() + ") "
                                    + "and point H(" + H.X.ToString() + ", " + H.Y.ToString() + ")."
                                    , "Solution");

                    tmp = draw();
                    drawTriangle(P[i], P[j], P[k], H, tmp);
                }
            }
        }   // solution

        private void format()
        {
            int minX = Math.Min(Math.Min(S[0].X, S[1].X), S[2].X),
                minY = Math.Min(Math.Min(S[0].Y, S[1].Y), S[2].Y),
                maxX = Math.Max(Math.Max(S[0].X, S[1].X), S[2].X),
                maxY = Math.Max(Math.Max(S[0].Y, S[1].Y), S[2].Y);

            int dx = view.Size.Width / 2 - (maxX + minX) / 2,
                dy = view.Size.Height / 2 - (maxY + minY) / 2;

            for (int i = 0; i < 3; i++)
            {
                S[i].X += dx; S[i].Y += dy;
            }
        }   // move triangle into center

        private void draw_triangle()
        {
            Pen side = new Pen(Color.Green, 2);

            g.DrawLine(new Pen(Color.YellowGreen), S[0], S[3]);
            g.DrawLine(new Pen(Color.Red, 1.5F), S[1], S[3]);
            g.DrawLine(side, S[0], S[1]);
            g.DrawLine(side, S[1], S[2]);
            g.DrawLine(side, S[2], S[0]);      // draw sides

            Pen top = new Pen(Color.OrangeRed, 2);

            g.DrawEllipse(top, S[0].X - 1, S[0].Y - 1, 2, 2);
            g.DrawEllipse(top, S[1].X - 1, S[1].Y - 1, 2, 2);
            g.DrawEllipse(top, S[2].X - 1, S[2].Y - 1, 2, 2);
            g.DrawEllipse(new Pen(Color.Purple, 2), S[3].X - 1, S[3].Y - 1, 2, 2);

            Font let = new System.Drawing.Font(new FontFamily("Microsoft Sans Serif"), 10);
            g.DrawString("A", let, new SolidBrush(Color.SteelBlue), S[0]);
            g.DrawString("B", let, new SolidBrush(Color.SteelBlue), S[1]);
            g.DrawString("C", let, new SolidBrush(Color.SteelBlue), S[2]);
            g.DrawString("H", let, new SolidBrush(Color.SteelBlue), S[3]);
        }   // draw triangle (zoom)

        private void zoomBtn_Click(object sender, EventArgs e)
        {
            n = 1.5F;
            g.Clear(Color.WhiteSmoke);
            format();
            PointF tmp = identify(S[0], S[1], S[2]);
            S[3].X = (int)tmp.X; S[3].Y = (int)tmp.Y;
            for (int i = 0; i < 4; i++)
            {
                S[i].X = view.Size.Width / 2 + (int)(n * (S[i].X - view.Size.Width / 2));
                S[i].Y = view.Size.Height / 2 + (int)(n * (S[i].Y - view.Size.Height / 2));
            }

            draw_triangle();
        }   // zoom triangle

        private void unZoomBtn_Click(object sender, EventArgs e)
        {
            n = 0.75F;
            g.Clear(Color.WhiteSmoke);
            format();

            for (int i = 0; i < 4; i++)
            {
                S[i].X = view.Size.Width / 2 + (int)(n * (S[i].X - view.Size.Width / 2) / (n + 0.5));
                S[i].Y = view.Size.Height / 2 + (int)(n * (S[i].Y - view.Size.Height / 2) / (n + 0.5));
            }

            draw_triangle();
        }   // unzoom triangle

        private void proBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program: Find triangle, satisfying that it's maximum height is " +
                            "the MINIMUM value of all triangles, which were created by given points.", 
                            "About");
        }   // show problem

        private void resetBtn_Click(object sender, EventArgs e)
        {
            draw();
        }   // reset point

        private void editX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                editY.Focus();
        } 

        private void editY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addBtn_Click(sender, e);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to clear all?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tab.RowCount = 0; g.Clear(Color.WhiteSmoke); editY.Clear(); editX.Focus();
            }
        }

        private void tab_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tab.Focus(); draw();
        }
    }
}
