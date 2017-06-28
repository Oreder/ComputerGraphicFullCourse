using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace IDEClass
{
    class myClass
    {
        public PointF[] Pt = new PointF[100];
        public int count;
        
        public bool existCo(PointF z)
        {
            if (count > 0)
            {
                foreach (PointF a in Pt)
                {
                    if (a.X == z.X && a.Y == z.Y)
                        return true;
                }
            }

            return false;
        }

        public bool inline(PointF a, PointF b, PointF c)
        {
            if (a.X == c.X || a.Y == c.Y)
                return false;

            if ((a.X - b.X) * (a.Y - c.Y) == (a.X - c.X) * (a.Y - b.Y))
                return true;

            return false;
        }

        public double length(PointF a, PointF b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public double distance(PointF a, PointF b, PointF c)        // distance from A to (BC)
        {
            double k1 = Math.Abs(a.X * (c.Y - b.Y) - a.Y * (c.X - b.X) - b.X * c.Y + b.Y * c.X);
            double k2 = Math.Sqrt(Math.Pow(b.X - c.X, 2) + Math.Pow(b.Y - c.Y, 2));

            return k1 / k2;
        }

        public double maxHeights(PointF a, PointF b, PointF c)
        {
            if (inline(a, b, c))
                return 0;

            double h_a = distance(a, b, c);
            double h_b = distance(b, c, a);
            double h_c = distance(c, a, b);

            return Math.Max(Math.Max(h_a, h_b), h_c);
        }

        public bool removeCo(PointF M)
        {
            bool key = false;
            int i;
            for (i = 0; i < count; i++)
            {
                if (Pt[i].X == M.X && Pt[i].Y == M.Y)
                {
                    key = true;
                    break;
                }
            }

            if (key)
            {
                for (int j = i; j < count; j++)
                {
                    Pt[j] = Pt[j + 1];
                }

                Pt[count - 1].X = 0; Pt[count - 1].Y = 0;
                count--;
            }

            return key;
        }

        public PointF fix_size(PointF z, int x, int y, float tx, float ty)
        {
            double xt = tx * z.X + (1 - tx) * x;
            double yt = ty * z.Y + (1 - ty) * y;

            return new PointF((float)xt, (float)yt);
        }
    }
}
