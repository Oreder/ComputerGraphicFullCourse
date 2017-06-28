using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amputation_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xp = 0, yp = 0, k = 0, k1 = 0, k2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            Bitmap myImage = new Bitmap(view.Width, view.Height);
            view.Image = myImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Point p = view.PointToClient(System.Windows.Forms.Cursor.Position);
            int x = p.X;
            int y = p.Y;
            drawningAll(x, y);
        }

        private void drawningAll(int x, int y)
        {
            if (radioButton1.Checked)
                drawCutter(x, y);
            if (radioButton2.Checked)
                drawLineSeg(x, y);
            view.Refresh();
        }

        private void drawCutter(int x, int y)
        {
            MyPoint tp;
            if (k1 == 0)
            {
                tp = new MyPoint(x, y, true);
                ConfigList.Items.Add(tp);
                k1++;
            }
            else
            {
                tp = new MyPoint(x, y, false);
                ConfigList.Items.Add(tp);
                view.Image = new Bitmap(view.Width, view.Height);
                Graphics g = Graphics.FromImage(view.Image);
                Pen myPen1 = new Pen(Color.Black, 2);
                Pen myPen2 = new Pen(Color.Blue, 2);
                int kk1 = RectList.Items.Count;
                int kk2 = ConfigList.Items.Count;
                int i;
                if (kk1 > 1)
                {
                    RectList.Items.Add(RectList.Items[0]);
                    for (i = 0; i < kk1; i++)
                        g.DrawLine(myPen1, ((MyPoint)RectList.Items[i]).x, ((MyPoint)RectList.Items[i]).y, ((MyPoint)RectList.Items[i + 1]).x, ((MyPoint)RectList.Items[i + 1]).y);
                    RectList.Items.RemoveAt(kk1);
                }
                if (kk2 > 1)
                {
                    ConfigList.Items.Add(ConfigList.Items[0]);
                    for (i = 0; i < kk2; i++)
                        g.DrawLine(myPen2, ((MyPoint)ConfigList.Items[i]).x, ((MyPoint)ConfigList.Items[i]).y, ((MyPoint)ConfigList.Items[i + 1]).x, ((MyPoint)ConfigList.Items[i + 1]).y);
                    ConfigList.Items.RemoveAt(kk2);
                }

                k1++;
            }
        }

        private void drawLineSeg(int x, int y)
        {
            MyPoint tp;
            if (k2 == 0)
            {
                tp = new MyPoint(x, y, true);
                RectList.Items.Add(tp);
                k2++;
            }
            else
            {
                tp = new MyPoint(x, y, false);
                RectList.Items.Add(tp);
                view.Image = new Bitmap(view.Width, view.Height);
                Graphics g = Graphics.FromImage(view.Image);
                Pen myPen1 = new Pen(Color.Black, 2);
                Pen myPen2 = new Pen(Color.Blue, 2);
                int kk1 = RectList.Items.Count;
                int kk2 = ConfigList.Items.Count;
                int i;
                if (kk1 > 1)
                {
                    RectList.Items.Add(RectList.Items[0]);
                    for (i = 0; i < kk1; i++)
                        g.DrawLine(myPen1, ((MyPoint)RectList.Items[i]).x, ((MyPoint)RectList.Items[i]).y, ((MyPoint)RectList.Items[i + 1]).x, ((MyPoint)RectList.Items[i + 1]).y);
                    RectList.Items.RemoveAt(kk1);
                }
                if (kk2 > 1)
                {
                    ConfigList.Items.Add(ConfigList.Items[0]);
                    for (i = 0; i < kk2; i++)
                        g.DrawLine(myPen2, ((MyPoint)ConfigList.Items[i]).x, ((MyPoint)ConfigList.Items[i]).y, ((MyPoint)ConfigList.Items[i + 1]).x, ((MyPoint)ConfigList.Items[i + 1]).y);
                    ConfigList.Items.RemoveAt(kk2);
                }
                k2++;
            }
        }

        private void clearA_Click(object sender, EventArgs e)
        {
            RectList.Items.Clear();
            radioButton2.Checked = true;
            Bitmap myImage = new Bitmap(view.Width, view.Height);
            view.Image = myImage;
            Graphics g = Graphics.FromImage(view.Image);
            Pen myPenLS = new Pen(Color.Blue, 2);
            MyPoint tp1, tp2;
            for (int i = 0; i < ConfigList.Items.Count - 1; i++)
            {
                tp1 = (MyPoint)ConfigList.Items[i];
                tp2 = (MyPoint)ConfigList.Items[i + 1];
                g.DrawLine(myPenLS, tp1.x, tp1.y, tp2.x, tp2.y);
            }
            if (ConfigList.Items.Count > 0)
            {
                tp1 = (MyPoint)ConfigList.Items[0];
                tp2 = (MyPoint)ConfigList.Items[ConfigList.Items.Count - 1];
                g.DrawLine(myPenLS, tp1.x, tp1.y, tp2.x, tp2.y);
            }
            k2 = 0;
        }

        private void clearC_Click(object sender, EventArgs e)
        {
            ConfigList.Items.Clear();
            radioButton1.Checked = true;
            Bitmap myImage = new Bitmap(view.Width, view.Height);
            view.Image = myImage;
            Graphics g = Graphics.FromImage(view.Image);
            Pen myPenLS = new Pen(Color.Black, 2);
            MyPoint tp1, tp2;
            for (int i = 0; i < RectList.Items.Count - 1; i++)
            {
                tp1 = (MyPoint)RectList.Items[i];
                tp2 = (MyPoint)RectList.Items[i + 1];
                g.DrawLine(myPenLS, tp1.x, tp1.y, tp2.x, tp2.y);
            }
            if (RectList.Items.Count > 0)
            {
                tp1 = (MyPoint)RectList.Items[0];
                tp2 = (MyPoint)RectList.Items[RectList.Items.Count - 1];
                g.DrawLine(myPenLS, tp1.x, tp1.y, tp2.x, tp2.y);
            }
            k1 = 0; 
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            int ka = RectList.Items.Count;
            int kc = ConfigList.Items.Count + 1;
            if (isNotConvex())
            {
                if (MessageBox.Show("Please input the convex configuration!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Retry)
                    clearC_Click(sender, e);
                else
                    Close();
                return;
            }
            if (ka < 3 || kc < 4)
            {
                MessageBox.Show("Configuration does not have enough points!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<MyPoint> a = new List<MyPoint>();
            List<MyPoint> b = new List<MyPoint>();
            List<MyPoint> c = new List<MyPoint>();
            int Nb = 1;
            foreach (MyPoint tmp in RectList.Items)
                a.Add(tmp);
            foreach (MyPoint tmp in ConfigList.Items)
                c.Add(tmp);
            c.Add((MyPoint)ConfigList.Items[0]);
            int i, j;
            MyPoint s, f, it;
            bool err;
            for (i = 0; i < kc - 1 && Nb != 0; i++)
            {
                Nb = 0;
                MyPointDouble vi = new MyPointDouble();
                MyPointDouble vi1 = new MyPointDouble();
                GetDirection(ref vi, c[i].x, c[i].y, c[i + 1].x, c[i + 1].y);
                int i2 = i + 2;
                if (i2 > kc - 1)
                    i2 = 1;
                GetDirection(ref vi1, c[i].x, c[i].y, c[i2].x, c[i2].y);
                MyPointDouble nvn = new MyPointDouble();
                nvn.y = 1;
                if (vi.x != 0)
                    nvn.x = -vi.y / vi.x;
                else
                {
                    nvn.y = 0;
                    nvn.x = 1;
                }
                if (ScalarPro(nvn, vi1) < 0)
                {
                    nvn.y *= -1;
                    nvn.x *= -1;
                }

                f = a[0];
                s = a[0];
                if (isVisible(s, c[i + 1], nvn))
                {
                    b.Add(s);
                    Nb++;
                }

                for (j = 1; j < ka; j++)
                {
                    it = new MyPoint();
                    err = findpoint(s, a[j], c[i], c[i + 1], ref it);
                    if (!err)
                    {
                        b.Add(it);
                        Nb++;
                    }
                    s = a[j];
                    if (isVisible(s, c[i + 1], nvn))
                    {
                        b.Add(s);
                        Nb++;
                    }
                }
                if (Nb == 0)
                    break;
                it = new MyPoint();
                err = findpoint(s, f, c[i], c[i + 1], ref it);
                if (!err)
                {
                    b.Add(it);
                    Nb++;
                }
                a.Clear();
                foreach (MyPoint tmp in b)
                    a.Add(tmp);
                ka = Nb;
                b.Clear();
            }
            //MessageBox.Show(ka.ToString()); 
            if (ka != 0)
            {
                //MessageBox.Show(a[0].x.ToString() + " " + a[0].y.ToString()); 
                a.Add(a[0]);
                Graphics g = Graphics.FromImage(view.Image);
                Pen myPen = new Pen(Color.Red, 2);
                for (i = 0; i < Nb; i++)
                {
                    g.DrawLine(myPen, a[i].x, a[i].y, a[i + 1].x, a[i + 1].y);
                }
            }
            view.Refresh();
        }

        private bool findpoint(MyPoint p1, MyPoint q1, MyPoint p2, MyPoint q2, ref MyPoint rez)
        {
            bool err = false;
            double t1;
            int x1 = p1.x;
            int y1 = p1.y;
            int a1 = q1.x;
            int b1 = q1.y;
            int x2 = p2.x;
            int y2 = p2.y;
            int a2 = q2.x;
            int b2 = q2.y;
            if ((x2 - a2) * (y1 - b1) - (x1 - a1) * (y2 - b2) != 0)
            {
                t1 = ((x2 - a2) * (y1 - y2) - (x1 - x2) * (y2 - b2)) / (double)((x2 - a2) * (y1 - b1) - (x1 - a1) * (y2 - b2));
                rez.x = (int)Math.Round(p1.x + (q1.x - p1.x) * t1);
                rez.y = (int)Math.Round(p1.y + (q1.y - p1.y) * t1);
                if (t1 < 0 || t1 > 1)
                    err = true;
            }
            else
                err = true;
            return err;
        }

        private void GetDirection(ref MyPointDouble v, double xb, double yb, double xe, double ye)
        {
            v.x = xe - xb;
            v.y = ye - yb;
        }

        private double ScalarPro(MyPointDouble u, MyPointDouble v)
        {
            return u.x * v.x + u.y * v.y;
        }

        private bool isVisible(MyPoint s, MyPoint ci, MyPointDouble ni)
        {
            MyPointDouble top = new MyPointDouble();
            GetDirection(ref top, ci.x, ci.y, s.x, s.y);
            if (ScalarPro(top, ni) >= 0)
                return true;
            return false;
        }

        private bool isNotConvex()
        {
            int i;
            int n = ConfigList.Items.Count;
            MyPoint __top_1 = new MyPoint();
            MyPoint __top_2 = new MyPoint();

            int[] mas = new int[n];
            int k1 = 0, k2 = 0, k3 = 0;
            for (i = 0; i < n; i++)
            {
                mas[i] = getVector(i);
                if (mas[i] > 0)
                    k1++;
                if (mas[i] == 0)
                    k2++;
                if (mas[i] < 0)
                    k3++;
            }

            if (k1 != 0 && k3 != 0 || k2 == n)
                return true;
            return false;
        }

        private int getVector(int i)
        {
            int n = ConfigList.Items.Count;
            int __top_1X, __top_2X, __top_1Y, __top_2Y;

            int i1 = i - 1, i2 = i + 1;
            if (i1 < 0) i1 = n - 1;
            if (i2 > n - 1) i2 = 0;

            __top_1X = ((MyPoint)ConfigList.Items[i2]).x - ((MyPoint)ConfigList.Items[i]).x;
            __top_1Y = ((MyPoint)ConfigList.Items[i2]).y - ((MyPoint)ConfigList.Items[i]).y;
            __top_2X = ((MyPoint)ConfigList.Items[i]).x - ((MyPoint)ConfigList.Items[i1]).x;
            __top_2Y = ((MyPoint)ConfigList.Items[i]).y - ((MyPoint)ConfigList.Items[i1]).y;

            return __top_1X * __top_2Y - __top_1Y * __top_2X;
        }
    }

    public class MyPoint
    {
        public bool det;
        public int x, y;

        public MyPoint()
        {
            this.det = false;
            this.x = 0;
            this.y = 0;
        }

        public MyPoint(int x, int y, bool det)
        {
            this.det = det;
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            if (det)
                return "#P(" + x.ToString() + ", " + y.ToString() + ")";
            return "(" + x.ToString() + ", " + y.ToString() + ")";
        }
    }

    public class MyPointDouble
    {
        public double x, y;

        public MyPointDouble()
        {
            this.x = 0;
            this.y = 0;
        }

        public MyPointDouble(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
