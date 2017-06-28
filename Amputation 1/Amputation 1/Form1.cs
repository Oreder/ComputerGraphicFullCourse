using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amputation;

namespace Amputation_1
{
    public partial class Form1 : Form
    {
        AMP PET = new AMP();
        Graphics g;
        bool Isclicked = false;
        Point P1, P2;
        Pen org = new Pen(Color.Red, 2), gre = new Pen(Color.ForestGreen, 2);

        public Form1()
        {
            InitializeComponent();
            g = view.CreateGraphics();
        }

        private void Rect(Point A, Point C)
        {
            PET.left = Math.Min(A.X, C.X); PET.right = Math.Max(A.X, C.X);
            PET.up = Math.Max(A.Y, C.Y); PET.down = Math.Min(A.Y, C.Y);

            Pen p = new Pen(Color.Black, 4);
            Point B = new Point(C.X, A.Y),
                  D = new Point(A.X, C.Y);

            g.DrawLine(p, A, B); g.DrawLine(p, B, C);
            g.DrawLine(p, C, D); g.DrawLine(p, D, A);
        }

        private void SetIN(Point A, Point B)
        {
            g.DrawLine(org, A, B);
        }

        private void SetOUT(Point A, Point B)
        {
            g.DrawLine(gre, A, B);
        }

        private Point OneCr(Point A, Point B)
        {
            int x = PET.crHori(A, B, PET.down);
            if (x > 0) return new Point(x, PET.down);
            
            x = PET.crHori(A, B, PET.up);
            if (x > 0) return new Point(x, PET.up);

            int y = PET.crVert(A, B, PET.left);
            if (y > 0) return new Point(PET.left, y);
            
            return new Point(PET.right, PET.crVert(A, B, PET.right));
        }

        private void SetLine()
        {
            int S1 = PET.S(P1.X, P1.Y),
                S2 = PET.S(P2.X, P2.Y);
            
            if ((S1 == 0) && (S2 == 0))
                SetIN(P1, P2);
            else
            {
                int P = PET.P(P1.X, P1.Y, P2.X, P2.Y);
                if (P != 0)
                    SetOUT(P1, P2);
                else
                {
                    if (S1 == 0)    // CASE: P1 is inside
                    {
                        Point R = OneCr(P1, P2);
                        SetIN(P1, R); SetOUT(R, P2);
                    }
                    else if (S2 == 0)    // CASE: P2 is inside
                    {
                        Point R = OneCr(P2, P1);
                        SetIN(P2, R); SetOUT(R, P1);
                    }
                    else    // CASE: 2 points are all outside
                    {
                        int x_down = PET.crHori(P1, P2, PET.down),
                            x_up = PET.crHori(P1, P2, PET.up),
                            y_left = PET.crVert(P1, P2, PET.left),
                            y_right = PET.crVert(P1, P2, PET.right);

                        if (x_down + x_up + y_left + y_right == 0) // CASE: Absolute no cross
                        {
                            SetOUT(P1, P2);
                            return ;
                        }

                        Point R, V;
                        if (x_up > 0)
                        {
                            R = new Point(x_up, PET.up);
                            if (x_down > 0)
                                V = new Point(x_down, PET.down);
                            else if (y_left > 0)
                                V = new Point(PET.left, y_left);
                            else
                                V = new Point(PET.right, y_right);
                        }
                        else
                        {
                            if (x_down > 0)
                            {
                                R = new Point(x_down, PET.down);
                                if (y_left > 0)
                                    V = new Point(PET.left, y_left);
                                else 
                                    V = new Point(PET.right, y_right);
                            }
                            else
                            {
                                R = new Point(PET.left, y_left);
                                V = new Point(PET.right, y_right);
                            }
                        }

                        if (PET.isMid(P1, R, V))
                        {
                            SetOUT(P1, R); SetOUT(V, P2); SetIN(R, V);
                        }
                        else
                        {
                            SetOUT(P2, R); SetOUT(V, P1); SetIN(R, V);
                        }
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            g.Clear(view.BackColor);
            Isclicked = false;
            Rect(new Point(-4, -4), new Point(view.Width + 4, view.Height + 4));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            choi.SelectedIndex = 0;
        }

        private void view_MouseClick(object sender, MouseEventArgs e)
        {
            if (Isclicked == false)
            {
                Isclicked = true;
                P1 = new Point(e.X, e.Y);
                g.DrawEllipse(new Pen(Color.Gray, 2), P1.X - 1, P1.Y - 1, 2, 2);
            }
            else
            {
                Isclicked = false;
                if (horizontalToolStripMenuItem.Checked)
                    P2 = new Point(e.X, P1.Y);
                else if (verticalToolStripMenuItem.Checked)
                    P2 = new Point(P1.X, e.Y);
                else
                    P2 = new Point(e.X, e.Y);

                g.DrawEllipse(new Pen(Color.Gray, 2), P2.X - 1, P2.Y - 1, 2, 2);
            }

            if (Isclicked == false)
            {
                if (choi.SelectedIndex == 0)
                    Rect(P1, P2); 
                
                if (choi.SelectedIndex == 1)
                    SetLine();
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (horizontalToolStripMenuItem.Checked)
                horizontalToolStripMenuItem.Checked = false;
            else
                horizontalToolStripMenuItem.Checked = true;

            if (verticalToolStripMenuItem.Checked)
                verticalToolStripMenuItem.Checked = false;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verticalToolStripMenuItem.Checked)
                verticalToolStripMenuItem.Checked = false;
            else
                verticalToolStripMenuItem.Checked = true;

            if (horizontalToolStripMenuItem.Checked)
                horizontalToolStripMenuItem.Checked = false;
        }
    }
}
