using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amputation_2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen black = new Pen(Color.Black, 4),
            gre = new Pen(Color.ForestGreen, 2),
            red = new Pen(Color.Red, 2),
            org = new Pen(Color.Yellow, 2);

        private List<Point> A;
        private Point P1, P2;
        private bool flag = false;

        private struct Vector
        {
            public int a, b;
        }

        private Vector U(Point A, Point B)
        {
            Vector AB;
            AB.a = B.X - A.X;
            AB.b = B.Y - A.Y;
            return AB;
        }

        private int Pro(Vector A, Vector B)
        {
            return A.a * B.a + A.b * B.b;
        }

        private Vector N(Point A, Point B, Point M)
        {
            Vector AB = U(A, B), AM = U(A, M), tmp;
            tmp.a = -AB.b;
            tmp.b = AB.a;

            if (Pro(tmp, AM) > 0)
                return tmp;

            tmp.a = -tmp.a;
            tmp.b = -tmp.b;
            return tmp;
        }
        
        public Form1()
        {
            InitializeComponent();
            g = view.CreateGraphics();
            A = new List<Point>();
        }

        private void SetColor(Point A, Point B, Pen p)
        {
            g.DrawLine(p, A, B);
        }

        public bool isMid(System.Drawing.Point P, System.Drawing.Point R, System.Drawing.Point V)
        {
            if ((R.X - P.X) * (R.X - V.X) + (R.Y - P.Y) * (R.Y - V.Y) < 0)
                return true;
            return false;
        }

        private void SetLine()
        {
            int n = A.Count;
            Vector D = U(P1, P2);

            double t0 = 0, t1 = 1;
            for (int i = 0; i <= n; i++)
            {
                Vector Ni = N(A[i % n], A[(i + 1) % n], A[(i + 2) % n]),
                       Wi = U(A[i % n], P1);

                int d = Pro(D, Ni), w = Pro(Wi, Ni);
                if (d == 0)
                {
                    if (w < 0)     // OUT
                    {
                        SetColor(P1, P2, gre);
                        return;
                    }
                }
                else
                {
                    double t = -w / d;
                    if (d > 0)
                    {
                        if (t > t0)
                            t0 = t;
                    }
                    else
                    {
                        if (t < t1)
                            t1 = t;
                    }
                }
            }

            if (t0 > t1)
                SetColor(P1, P2, gre);
            else
            {
                Point M = new Point((int)(P1.X + t0 * D.a), (int)(P1.Y + t0 * D.b)),
                      N = new Point((int)(P1.X + t1 * D.a), (int)(P1.Y + t1 * D.b));

                SetColor(P1, M, gre); SetColor(M, N, red); SetColor(N, P2, gre);
            }
        }

        private void Figure()
        {
            g.Clear(Color.White);

            if (A.Count == 2)
                g.DrawLine(black, A[0], A[1]);

            if (A.Count > 2)
            {
                for (int i = 0; i < A.Count - 1; i++)
                    g.DrawLine(black, A[i], A[i + 1]);
                g.DrawLine(black, A[A.Count - 1], A[0]);
            }

            for (int i = 0; i < A.Count; i++)
                g.DrawEllipse(org, A[i].X - 1, A[i].Y - 1, 2, 2);
        }

        private void view_MouseClick(object sender, MouseEventArgs e)
        {
            if (choi.SelectedIndex == 0)
            {
                A.Add(new Point(e.X, e.Y));
                Figure();
            }
            else
            {
                Point M = new Point(e.X, e.Y);
                g.DrawEllipse(org, M.X - 1, M.Y - 1, 2, 2);
                
                if (flag == false)
                {
                    P1 = M; flag = true;
                }
                else
                {
                    P2 = M; flag = false;
                }

                if (flag == false)
                    SetLine();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            choi.SelectedIndex = 0;
        }
    }
}
