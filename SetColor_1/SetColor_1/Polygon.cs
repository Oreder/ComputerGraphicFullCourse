using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Code_PG
{
    

        //private void setColor(Bitmap bmp, int x, int y, Color c1, Color c2)
        //{
        //    Color c0 = bmp.GetPixel(x + 1, y);

        //    if (c0.ToArgb() == c1.ToArgb())
        //        bmp.SetPixel(x, y, c2);
        //    else
        //        bmp.SetPixel(x, y, c1);
        //}

        //private void Vertical(Bitmap bmp, Point P1, Point P2, int rightBorder, Color c1, Color c2)
        //{
        //    int y1 = P1.Y, y2 = P2.Y;
        //    if (y1 > y2)
        //    {
        //        int tmp = y1; y1 = y2; y2 = tmp;
        //    }
            
        //    while (y1 <= y2)
        //    {
        //        for (int x = P1.X; x <= rightBorder; x++)
        //            setColor(bmp, x, y1, c1, c2);
        //        y1++;
        //    }
        //}

        //private void Horizontal(Bitmap bmp, Point P1, Point P2, int rightBorder, Color c1, Color c2)
        //{
        //    int x = Math.Min(P1.X, P2.X);

        //    while (x <= rightBorder)
        //    {
        //        setColor(bmp, x, P1.Y, c1, c2);
        //        x++;
        //    }
        //}

        //private void Normal(Bitmap bmp, Point P1, Point P2, int rightBorder, Color c1, Color c2)
        //{
        //    int y_up = P1.Y, y_down = P2.Y;
            
        //    if (y_down < y_up)
        //    {
        //        int tmp = y_up; y_up = y_down; y_down = tmp;
        //    }

        //    double k = (P2.X - P1.X) / (P2.Y - P1.Y);
        //    while (y_up <= y_down)
        //    {
        //        int x = (int)(P1.X + (y_up - P1.Y) * k);
        //        Color color = bmp.GetPixel(x + 1, y_up);

        //        while (x <= rightBorder)
        //        {
        //            if (color == c1)
        //                bmp.SetPixel(x, y_up, c2);
        //            else
        //                bmp.SetPixel(x, y_up, c1);
        //        }

        //        y_up++;
        //    }
        //}


        //private void Fill(Bitmap bmp, Point P1, Point P2, int rightBorder, Color c1, Color c2)
        //{
        //    if (P1.X == P2.X)
        //    {
        //        Vertical(bmp, P1, P2, rightBorder, c1, c2);
        //    }
            
        //    if (P1.Y == P2.Y)
        //    {
        //        Horizontal(bmp, P1, P2, rightBorder, c1, c2);
        //    }
        //    else
        //    {
        //        Normal(bmp, P1, P2, rightBorder, c1, c2);
        //    }
        //}

        //public void fill_polygon(Bitmap bmp, Color clfont, Color clfill, List<Point> p)
        //{
        //    int RB = p[0].X;
        //    for (int i = 1; i < p.Count; i++)
        //        RB = Math.Max(RB, p[i].X);

        //    MessageBox.Show(p.Count.ToString());
        //    for (int i = 0; i < p.Count - 1; i++)
        //        Fill(bmp, p[i], p[i + 1], RB, clfont, clfill);

        //    Fill(bmp, p[p.Count - 1], p[0], RB, clfont, clfill);
        //}
    //}
}
