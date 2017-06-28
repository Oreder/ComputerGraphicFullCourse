using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace CClass
{
    class CircleClass
    {
        /// <summary>
        ///     CHECK POINT IN RANGE OF BITMAP OR NOT
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="xt"></param>
        /// <param name="yt"></param>
        /// <returns></returns>
        private bool inside(Bitmap bmp, int xt, int yt)
        {
            if (xt >= bmp.Size.Width || xt <= 0 || yt >= bmp.Size.Height || yt <= 0)
                return false;
            return true;
        }

        /// <summary>
        ///     MOVE POINTS INTO NEW POSITION
        /// </summary>
        /// <param name="M"></param>
        /// <param name="N"></param>
        /// <param name="dX"></param>
        /// <param name="dY"></param>
        private void Move(Point[] M, int N, int dX, int dY)
        {
            for (int i = 0; i < N; i++)
            {
                M[i].X = M[i].X + dX;
                M[i].Y = M[i].Y + dY;
            }
        }

        /// <summary>
        ///     DRAW BITMAP
        /// </summary>
        /// <param name="M"></param>
        /// <param name="N"></param>
        /// <param name="dX"></param>
        /// <param name="dY"></param>
        private void Draw(Bitmap bmp, Point[] M, int N, Color color)
        {
            int x, y;
            for (int i = 0; i < N; i++)
            {
                x = M[i].X; y = M[i].Y;

                if (inside(bmp, x, y))              /// FIRST REGION
                    bmp.SetPixel(x, y, color);
                   
                if (inside(bmp, bmp.Size.Width - x, y))     /// SECOND REGION
                    bmp.SetPixel(bmp.Size.Width - x, y, color);

                if (inside(bmp, x, bmp.Size.Height - y))             /// THIRD REGION
                    bmp.SetPixel(x, bmp.Size.Height - y, color);

                if (inside(bmp, bmp.Size.Width - x, bmp.Size.Height - y))       /// FOURTH REGION
                    bmp.SetPixel(bmp.Size.Width - x, bmp.Size.Height - y, color);
            }
        }

        /// <summary>
        ///     DRAW ELLIPSE USING CANONICAL FORM
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="Rx"></param>
        /// <param name="Ry"></param>
        /// <param name="color"></param>
        public void Cano(Bitmap bmp, int x0 , int y0, int Rx, int Ry, Color color)
        {
            List<Point> P = new List<Point>();
            int x = 0, y = Ry, E = Rx * Rx, Eb = Ry * Ry;
            double a_b = (double)E / Eb, b_a = (double)Eb / E;
            int n = (int)Math.Round(E / Math.Sqrt(E + Eb), 0);

            for (; x < n; x++)
            {
                y = (int)Math.Round(Math.Sqrt(Eb - x * x * b_a), 0);
                P.Add(new Point(x, y));
            }

            for (; y >= 0; y--)
            {
                x = (int)Math.Round(Math.Sqrt(E - y * y * a_b), 0);
                P.Add(new Point(x, y));
            }

            int N = P.Count;
            Point[] M = new Point[N];

            for (int k = 0; k < N; k++)
                M[k] = P[k];

            P.Clear();

            Move(M, N, x0, y0);
            Draw(bmp, M, N, color);
        }

        /// <summary>
        ///     DRAW ELLIPSE USING PARAMETRIC FORM
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="Rx"></param>
        /// <param name="Ry"></param>
        /// <param name="color"></param>
        public void Para(Bitmap bmp, int x0, int y0, int Rx, int Ry, Color color)
        {
            List<Point> P = new List<Point>();
            int x = 0, y = Ry;
            double d_angle = Math.PI / (4 * Math.Max(Rx, Ry));

            for (double angle = Math.PI / 2; angle >= 0; angle -= d_angle)
            {
                x = (int)Math.Round(Rx * Math.Cos(angle), 0);
                y = (int)Math.Round(Ry * Math.Sin(angle), 0);
                P.Add(new Point(x, y));
            }

            int N = P.Count;
            Point[] M = new Point[N];

            for (int k = 0; k < N; k++)
                M[k] = P[k];

            P.Clear();

            Move(M, N, x0, y0);
            Draw(bmp, M, N, color);
        }

        /// <summary>
        ///     DRAW ELLIPSE USING BRESENHAM'S ALGORITHM
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="color"></param>
        
        public void Bresenham(Bitmap bmp, int x0, int y0, int a, int b, Color color)
        {
            List<Point> P = new List<Point>();
            int x = 0, y = b;
            int E = a * a, Eb = b * b;
            double d = E + Eb - 2 * E * b, delta = Eb; 
            
            while (y >= 0)
            {
                P.Add(new Point(x, y));
                if (d < 0)
                {
                    delta = Math.Abs(Eb * (x + 1) * (x + 1) + E * y * y - E * Eb) - Math.Abs(d);
                    if (delta <= 0)
                    {
                        x++;
                        d += (Eb * (2 * x + 1));
                    }
                    else
                    {
                        x++; y--;
                        d += (Eb * (2 * x + 1) - E * (2 * y - 1));
                    }
                }
                else
                {
                    if (d == 0)
                    {
                        x++; y--;
                        d += (Eb * (2 * x + 1) - E * (2 * y - 1));
                    }
                    else
                        if (d > 0)
                        {
                            delta = Math.Abs(d) - Math.Abs(Eb * x * x + E * (y - 1) * (y - 1) - E * Eb);
                            if (delta >= 0)
                            {
                                y--;
                                d += (E * (1 - 2 * y));
                            }
                            else
                            {
                                x++; y--;
                                d += (Eb * (2 * x + 1) - E * (2 * y - 1));
                            }
                        }
                }
            }
            
            int N = P.Count;
            Point[] M = new Point[N];

            for (int k = 0; k < N; k++)
                M[k] = P[k];

            P.Clear();

            Move(M, N, x0, y0);
            Draw(bmp, M, N, color);
        }

        /// <summary>
        ///     DRAW ELLIPSE USING "MIDPOINT" ALGORITHM
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="color"></param>
        public void Midpoint(Bitmap bmp, int x0, int y0, int a, int b, Color color)
        {
            List<Point> P = new List<Point>();
            int x = 0, y = b;
            int EA_2 = 2 * a * a, Eb_2 = 2 * b * b, E = a * a, Eb = b * b,
                    chr = (int)Math.Round(E / Math.Sqrt(E + Eb), 0),
                    f = (int)(Eb - E * b + E / 4);

            for (; x <= chr; )
            {
                P.Add(new Point(x, y));
                x++; f += (Eb_2 * x - Eb);
                if (f >= 0)
                {
                    y--;
                    f -= EA_2 * y;
                }
            }
            x = a ; y = 0; chr = (int)Math.Round(Eb / Math.Sqrt(E + Eb), 0);
            f = (E - Eb * a + Eb / 4);
            for (; y<=chr; )
            {
                P.Add(new Point(x, y));
                y++;
                f += (EA_2 * y-E);
                if (f >= 0)
                { 
                    x--; 
                    f -= Eb_2 * x;
                }
            }
            
            y = -1;
            f += 3 * (E - Eb) / 4 - E * y + Eb * x;
            for (; y >= 0; )
            {
                P.Add(new Point(x, y));
                y--;
                f -= (EA_2 * y + E);
                if (f < 0)
                {
                    x++;
                    f += Eb_2 * x;
                }
            }

            int N = P.Count;
            Point[] M = new Point[N];
            
            for (int k = 0; k < N; k++)
                M[k] = P[k];

            P.Clear();

            Move(M, N, x0, y0);
            Draw(bmp, M, N, color);
        }
    }
}
