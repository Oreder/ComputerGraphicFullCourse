using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace LineClass
{
    class LINEC
    {
        /// <summary>
        ///     Check point is inside range of bitmap or not
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
        ///     Check beginning and end points
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        private bool check(Bitmap bmp, int x1, int y1, int x2, int y2, Color color)
        {
            if (x1 == x2 && y1 == y2)
            {
                bmp.SetPixel(x1, y1, color);
                MessageBox.Show("One pixel (" + (x1 - bmp.Size.Width/2).ToString() + ", " + (-y1 + bmp.Size.Height/2).ToString() + ") was set to "
                                + color.ToString(), "GPX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        ///     Algorithm Digital differential analyzer
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="color"></param>
        public void DDA(Bitmap bmp, int x1, int y1, int x2, int y2, Color color)
        {
            if (check(bmp, x1, y1, x2, y2, color))
            {
                double xt = x1, yt = y1,
                       dx = x2 - x1,
                       dy = y2 - y1,
                       L = Math.Max(Math.Abs(dx), Math.Abs(dy));

                dx /= L; dy /= L;

                for (int i = 1; i < L + 1; i++)
                {
                    if (inside(bmp,(int)xt, (int)yt))
                        bmp.SetPixel((int)xt, (int)yt, color);
                    else
                        break;

                    xt += dx; yt += dy;
                }
            }
        }

        /// <summary>
        ///     Draw line when dx = 0
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x"></param>
        /// <param name="y1"></param>
        /// <param name="y2"></param>
        /// <param name="color"></param>
        public void Bresenham_Zero(Bitmap bmp, int x, int y1, int y2, Color color)
        {
            if (y1 > y2)
            {
                int tmp = y1; y1 = y2; y2 = tmp;
            }

            while (y2 >= y1)
            {
                if (inside(bmp, x, y1))
                    bmp.SetPixel(x, y1, color);
                else
                    break;
                y1++;
            }
        }

        /// <summary>
        ///     Algorithm Bresenham with real correcting error
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="color"></param>
        public void Bresenham_R(Bitmap bmp, int x1, int y1, int x2, int y2, Color color)
        {
            if (check(bmp, x1, y1, x2, y2, color))
            {
                int dx = x2 - x1, dy = y2 - y1,
                    sx = Math.Sign(dx), sy = Math.Sign(dy);

                dx *= sx; dy *= sy;

                if (dx > 0)         // CASE dx > 0 (normal)
                {
                    bool swap = false;
                    if (dx < dy)
                    {
                        swap = true;
                        int t = dx; dx = dy; dy = t;
                    }

                    double m = (double)dy / dx, e = m - 0.5;

                    int xt = x1, yt = y1;

                    while (Math.Abs(x2 - xt) > 0)
                    {
                        if (inside(bmp, xt, yt))
                            bmp.SetPixel(xt, yt, color);
                        else
                            break;

                        if (e >= 0)
                        {
                            if (!swap)
                                yt += sy;
                            else
                                xt += sx;
                            e = e - 1;
                        }
                        else
                        {
                            if (!swap)
                                xt += sx;
                            else
                                yt += sy;
                            e = e + m;
                        }
                    }
                }
                else
                {
                    Bresenham_Zero(bmp, x1, y1, y2, color);     // CASE dx = 0
                }
            }
        }

        /// <summary>
        ///     Algorithm Bresenham with integer correcting error
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="color"></param>
        public void Bresenham_Z(Bitmap bmp, int x1, int y1, int x2, int y2, Color color)
        {
            if (check(bmp, x1, y1, x2, y2, color))
            {
                int dx = x2 - x1, dy = y2 - y1,
                    sx = Math.Sign(dx), sy = Math.Sign(dy);

                dx *= sx; dy *= sy;

                if (dx > 0)         // CASE dx > 0 (normal)
                {
                    bool swap = false;
                    if (dx < dy)
                    {
                        swap = true;
                        int t = dx; dx = dy; dy = t;
                    }

                    int E = 2 * dy - dx;

                    int xt = x1, yt = y1;

                    while (Math.Abs(x2 - xt) > 0)
                    {
                        if (inside(bmp, xt, yt))
                            bmp.SetPixel(xt, yt, color);
                        else
                            break;

                        if (E >= 0)
                        {
                            if (!swap)
                                yt += sy;
                            else
                                xt += sx;
                            E = E - 2 * dx;
                        }
                        else
                        {
                            if (!swap)
                                xt += sx;
                            else
                                yt += sy;
                            E = E + 2 * dy;
                        }
                    }
                }
                else
                {
                    Bresenham_Zero(bmp, x1, y1, y2, color);     // CASE dx = 0
                }
            }
        }

        /// <summary>
        ///     Algorithm Bresenham with intensity
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="colorPen"></param>
        /// <param name="background"></param>
        public void Bresenham_E(Bitmap bmp, int x1, int y1, int x2, int y2, Color colorPen, Color background)
        {
            if (check(bmp, x1, y1, x2, y2, colorPen))
            {
                int dx = x2 - x1, dy = y2 - y1,                 // RANGE
                    sx = Math.Sign(dx), sy = Math.Sign(dy);     // SIGN

                dx *= sx; dy *= sy;     // ABSOLUTE RANGE VALUE
                if (dx > 0)
                {
                    bool swap = false;      // swapping key
                    if (dx < dy)
                    {
                        swap = true;
                        int t = dx; dx = dy; dy = t;
                    }

                    double I = 256.0,         // default levels of intensity
                           e = I / 2,         // error
                           m = I * (double)dy / dx,  // correct error
                           W = I - m;         // const - MAX intensity

                    int xt = x1, yt = y1;
                    int r, g, b;                // RED, GREEN, BLUE
                    Color argb;

                    while (Math.Abs(x2 - xt) > 0)
                    {
                        double C = e / I;
                        r = (int)(colorPen.R + C * (background.R - colorPen.R));    // red
                        g = (int)(colorPen.G + C * (background.G - colorPen.G));    // green
                        b = (int)(colorPen.B + C * (background.B - colorPen.B));    // blue

                        argb = Color.FromArgb(r, g, b);     // set intensity

                        if (inside(bmp, xt, yt))
                            bmp.SetPixel(xt, yt, argb);     // color pixel
                        else
                            break;

                        if (e <= W)
                        {
                            if (!swap)
                                xt += sx;
                            else
                                yt += sy;
                            e = e + m;
                        }
                        else
                        {
                            xt += sx;
                            yt += sy;
                            e = e - W;
                        }
                    }
                }
                else
                {
                    Bresenham_Zero(bmp, x1, y1, y2, colorPen);     // CASE dx = 0
                }
            }
        }
    }
}
