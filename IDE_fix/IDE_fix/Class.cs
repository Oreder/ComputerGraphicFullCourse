using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IDE_fix_class
{
    class Class
    {
        public double distance(Point a, Point b)        // distance between 2 points
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y)); 
        }

        public bool in_range(Point z, Point a, Point b)     // check point in view range or not
        {
            if (z.X < a.X || z.X > b.X || z.Y < a.Y || z.Y > b.Y)
                return false;
            return true;
        }

        public bool inline(Point a, Point b, Point c)   // check points in 1 line
        {
            if ((a.X == c.X && a.X == b.X) || (a.Y == c.Y && a.Y == b.Y))
                return true;
            
            if ((a.X - b.X) * (a.Y - c.Y) == (a.X - c.X) * (a.Y - b.Y))
                return true;

            return false;
        }

        public double distance(Point a, Point b, Point c)        // distance from A to (BC)
        {
            double k1 = Math.Abs(a.X * (c.Y - b.Y) - a.Y * (c.X - b.X) - b.X * c.Y + b.Y * c.X);
            double k2 = Math.Sqrt(Math.Pow(b.X - c.X, 2) + Math.Pow(b.Y - c.Y, 2));

            return k1 / k2;
        }

        public double maxHeights(Point a, Point b, Point c)     // max heights of triangle
        {
            if (inline(a, b, c))
                return 0;

            double h_a = distance(a, b, c);
            double h_b = distance(b, c, a);
            double h_c = distance(c, a, b);

            return Math.Max(Math.Max(h_a, h_b), h_c);
        }
    }
}
