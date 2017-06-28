using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3DF;

namespace _3Dtest
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        //protected delegate double function(double x, double z);

        public Form1()
        {
            InitializeComponent();
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(XminEdt.Text),
                   Xmax = double.Parse(XmaxEdt.Text),
                   Zmin = double.Parse(ZminEdt.Text),
                   Zmax = double.Parse(ZmaxEdt.Text),
                   dX = double.Parse(dXedt.Text),
                   dZ = double.Parse(dZedt.Text);

            double AGX = (double)angleX.Value * Math.PI / 180,
                   AGY = (double)angleY.Value * Math.PI / 180,
                   AGZ = (double)angleZ.Value * Math.PI / 180;

            Graphics.FromImage(bmp).FillRectangle(Brushes.White, 0, 0, view.Width, view.Height);

            Horizont(Xmin, Xmax, dX, Zmin, Zmax, dZ, AGX, AGY, AGZ);

            view.Image = bmp;
        }

        private void Horizont(double Xmin, double Xmax, double dX,
                              double Zmin, double Zmax, double dZ,
                              double Agx, double Agy, double Agz)
        {
            double k = view.Width / (Xmax - Xmin), X, Y_Min = -view.Height / (2 * k);
            double __X__right__1, __Y__right__1 = 0,
                   __X__right__2, __Y__right__2 = 0;

            Boolean Prev, Now;

            __X__right__1 = Rotate(Xmin, Zmin, Agx, Agy, Agz, ref __Y__right__1);
            X = Xmin + dX;

            for (int i = 1; X <= Xmax + dX; i++, X += dX)
            {
                __X__right__2 = Rotate(X, Zmin, Agx, Agy, Agz, ref __Y__right__2);
                Draw(k * (__X__right__1 - Xmin), k * (__Y__right__1 - Y_Min),
                     k * (__X__right__2 - Xmin), k * (__Y__right__2 - Y_Min), 0);

                __X__right__1 = __X__right__2;
                __Y__right__1 = __Y__right__2;
            }

            Zmin += dZ;

            while (Zmin <= Zmax + dZ)
            {
                __X__right__1 = Rotate(Xmin, Zmin, Agx, Agy, Agz, ref __Y__right__1);

                Prev = Check_Visibility(k * (__X__right__1 - Xmin), k * (__Y__right__1 - Y_Min));

                X = Xmin + dX;
                for (int i = 1; X <= Xmax + dX; i++)
                {
                    __X__right__2 = Rotate(X, Zmin, Agx, Agy, Agz, ref __Y__right__2);

                    Now = Check_Visibility(k * (__X__right__2 - Xmin), k * (__Y__right__2 - Y_Min));

                    if (Prev == true)
                    {
                        if (Now == true)
                            Draw(k * (__X__right__1 - Xmin), k * (__Y__right__1 - Y_Min),
                                 k * (__X__right__2 - Xmin), k * (__Y__right__2 - Y_Min), 0);
                        else
                            Draw(k * (__X__right__1 - Xmin), k * (__Y__right__1 - Y_Min),
                                 k * (__X__right__2 - Xmin), k * (__Y__right__2 - Y_Min), -1);
                    }
                    else
                        if (Now == true)
                            Draw(k * (__X__right__1 - Xmin), k * (__Y__right__1 - Y_Min),
                                 k * (__X__right__2 - Xmin), k * (__Y__right__2 - Y_Min), 1);

                    __X__right__1 = __X__right__2;
                    __Y__right__1 = __Y__right__2;
                    Prev = Now; X += dX;
                }

                Zmin += dZ;
            }
        }

        private double Rotate(double X, double Z, double Agx, double Agy, double Agz, ref double Y_Res)
        {
            double Y = new _3DF.FuncClass().f(X, Z, funcList.SelectedIndex);

            Y_Res = (Math.Sin(Agz) * Math.Cos(Agx) +
                     Math.Cos(Agz) * Math.Sin(Agy) * Math.Sin(Agx)) * X +
                    (Math.Cos(Agz) * Math.Cos(Agx) - Math.Sin(Agz) * Math.Sin(Agy) * Math.Sin(Agx)) * Y -
                     Math.Cos(Agy) * Math.Sin(Agx) * Z;

            return Math.Cos(Agz) * Math.Cos(Agy) * X - Math.Sin(Agz) * Math.Cos(Agy) * Y + Math.Sin(Agy) * Z;
        }


        private Boolean Check_Visibility(double X, double Y)
        {
            Color C = Color.FromArgb(255, 255, 255);
            int x = Convert.ToInt32(X), y = Convert.ToInt32(Y), t;
            if (x < 0 || x > view.Width - 1 || y < 0 || y > view.Height - 1)
                return false;
            for (t = 0; t < y && bmp.GetPixel(x, t) == C; t++) ;
            if (t == y)
                return true;
            for (t = view.Height - 1; t > y && bmp.GetPixel(x, t) == C; t--) ;
            if (t == y)
                return true;

            return false;
        }

        private void Draw(double X1, double Y1, double X2, double Y2, int Chose)
        {
            Pen P = new Pen(Color.Black, 1);
            Color C = Color.White;// FromArgb(255, 255, 255);

            if (Chose == 0)
                Graphics.FromImage(bmp).DrawLine(P, Convert.ToInt32(X1), Convert.ToInt32(Y1),
                                            Convert.ToInt32(X2), Convert.ToInt32(Y2));

            if (Chose == -1)
            {
                double dx = X2 - X1, dy = Y2 - Y1, l;

                if (Math.Abs(dx) > Math.Abs(dy))
                    l = Math.Abs(dx);
                else
                    l = Math.Abs(dy);
                dx /= l; dy /= l;
                X1 += dx; Y1 += dy;
                for (int i = 1; i < l + 1 && X1 > 0 && Y1 > 0 && X1 < view.Width - 1 && Y1 < view.Height - 1 
                                          && bmp.GetPixel(Convert.ToInt32(X1), Convert.ToInt32(Y1)) == C; i++)
                {
                    bmp.SetPixel(Convert.ToInt32(X1), Convert.ToInt32(Y1), Color.Black);
                    X1 += dx; Y1 += dy;
                }

                return;
            }

            if (Chose == 1)
            {
                double dx = X1 - X2, dy = Y1 - Y2, l;
                X1 = X2; Y1 = Y2;

                if (Math.Abs(dx) > Math.Abs(dy))
                    l = Math.Abs(dx);
                else
                    l = Math.Abs(dy);
                dx /= l; dy /= l;
                X1 += dx; Y1 += dy;
                for (int i = 1; i < l + 1 && X1 > 0 && Y1 > 0 && X1 < view.Width - 1 && Y1 < view.Height - 1 
                                          && bmp.GetPixel(Convert.ToInt32(X1), Convert.ToInt32(Y1)) == C; i++)
                {
                    bmp.SetPixel(Convert.ToInt32(X1), Convert.ToInt32(Y1), Color.Black);
                    X1 += dx; Y1 += dy;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(view.Width, view.Height);
            funcList.SelectedIndex = 0;
        }

        private void angleX_ValueChanged(object sender, EventArgs e)
        {
            drawBtn_Click(sender, e);
        }

        private void angleY_ValueChanged(object sender, EventArgs e)
        {
            drawBtn_Click(sender, e);
        }

        private void angleZ_ValueChanged(object sender, EventArgs e)
        {
            drawBtn_Click(sender, e);
        }
    }
}
