using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amputation_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xp = 0, yp = 0, k = 0, k1 = 0;

        private void view_Click(object sender, EventArgs e)
        {
            Point p = view.PointToClient(System.Windows.Forms.Cursor.Position);
            int x = p.X, y = p.Y;
            drawAll(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radConfig.Checked = true;
            Bitmap myImage = new Bitmap(view.Width, view.Height);
            view.Image = myImage;
        }

        private void drawAll(int x, int y)
        {
            if (radConfig.Checked) drawCutter(x, y);
            if (radLine.Checked) drawSegment(x, y);
            view.Refresh();
        }

        private void drawCutter(int x, int y)
        {
            MyPoint tmp;
            if (k1 == 0)
            {
                tmp = new MyPoint(x, y, true);
                ConfigList.Items.Add(tmp);
                k1++;
            }
            else
            {
                tmp = new MyPoint(x, y, false);
                ConfigList.Items.Add(tmp);

                Graphics g = Graphics.FromImage(view.Image);
                Pen penB = new Pen(Color.OliveDrab, 2),
                    PenDel = new Pen(Color.White, 2),
                    PenLS = new Pen(Color.Black, 2);

                MyPoint tmp_0 = (MyPoint)ConfigList.Items[0],
                        tmp_1 = (MyPoint)ConfigList.Items[ConfigList.Items.Count - 2];

                if (k1 != 2)
                    g.DrawLine(PenDel, tmp_0.x, tmp_0.y, tmp_1.x, tmp_1.y);

                g.DrawLine(penB, tmp_0.x, tmp_0.y, tmp.x, tmp.y);
                g.DrawLine(penB, tmp_1.x, tmp_1.y, tmp.x, tmp.y);

                foreach (MyLineSeg seg in LineBox.Items)
                    g.DrawLine(PenLS, seg.xb, seg.yb, seg.xe, seg.ye);
                k1++;
            }
        }

        private void drawSegment(int x, int y)
        {
            if (k == 0)
            {
                xp = x;
                yp = y;
                k++;
            }
            else
            {
                MyLineSeg line = new MyLineSeg(xp, yp, x, y);
                LineBox.Items.Add(line);
                Graphics g = Graphics.FromImage(view.Image);
                Pen penB = new Pen(Color.Black, 2);
                g.DrawLine(penB, line.xb, line.yb, line.xe, line.ye);
                k = 0;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            LineBox.Items.Clear();
            ConfigList.Items.Clear();
            radConfig.Checked = true;
            Bitmap myImage = new Bitmap(view.Width, view.Height);
            view.Image = myImage;
            k1 = 0;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (ConfigList.Items.Count < 3)
            {
                MessageBox.Show("Configuration does not have enough points!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isNotConvex())
            {
                if (MessageBox.Show("Please input the convex configuration!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Retry)
                    clear_Click(sender, e);
                else
                    Close();
                return;
            }

            int n = ConfigList.Items.Count;
            foreach (MyLineSeg LineSeg in LineBox.Items)
            {
                MyPointDouble d = new MyPointDouble();
                GetDirection(ref d, LineSeg.xb, LineSeg.yb, LineSeg.xe, LineSeg.ye);

                bool q = true;
                double tn = 0, tv = 1, t;

                for (int i = 0; i < n; i++)
                {
                    int i1 = (i + 1) % n, i2 = (i + 2) % n;

                    MyPoint _pi = (MyPoint)ConfigList.Items[i],
                            _p1 = (MyPoint)ConfigList.Items[i1],
                            _p2 = (MyPoint)ConfigList.Items[i2];


                    MyPointDouble P0 = new MyPointDouble(_pi.x, _pi.y),
                                  P1 = new MyPointDouble(_p1.x, _p1.y),
                                  P2 = new MyPointDouble(_p2.x, _p2.y);

                    MyPointDouble _top = new MyPointDouble(),
                                  _top_1 = new MyPointDouble();

                    GetDirection(ref _top, P0.x, P0.y, P1.x, P1.y);
                    GetDirection(ref _top_1, P0.x, P0.y, P2.x, P2.y);

                    MyPointDouble normal = new MyPointDouble();

                    normal.y = 1;

                    if (_top.x != 0)
                        normal.x = -_top.y / _top.x;
                    else
                    {
                        normal.y = 0;
                        normal.x = 1;
                    }

                    if (ScalarPro(normal, _top_1) < 0)
                    {
                        normal.y *= -1;
                        normal.x *= -1;
                    }

                    MyPointDouble Wi = new MyPointDouble();
                    GetDirection(ref Wi, P0.x, P0.y, LineSeg.xb, LineSeg.yb);

                    double DS = ScalarPro(d, normal),
                           WS = ScalarPro(Wi, normal);

                    if (DS == 0)
                    {
                        if (WS < 0)
                        {
                            q = false; break;
                        }
                    }

                    t = -WS / DS;

                    if (DS > 0)
                    {
                        if (t <= 1)
                            tn = Math.Max(tn, t);
                        else
                        {
                            q = false; break;
                        }
                    }
                    else
                    {
                        if (t >= 0)
                            tv = Math.Min(tv, t);
                        else
                        {
                            q = false; break;
                        }
                    }
                }

                if (q && tn <= tv)
                {
                    MyLineSeg LSeg = new MyLineSeg(LineSeg.xb, LineSeg.yb, LineSeg.xe, LineSeg.ye);
                    LSeg.xb = (int)Math.Round(LineSeg.xb + tn * (LineSeg.xe - LineSeg.xb));
                    LSeg.yb = (int)Math.Round(LineSeg.yb + tn * (LineSeg.ye - LineSeg.yb));
                    LSeg.xe = (int)Math.Round(LineSeg.xb + tv * (LineSeg.xe - LineSeg.xb));
                    LSeg.ye = (int)Math.Round(LineSeg.yb + tv * (LineSeg.ye - LineSeg.yb));

                    Pen penB0 = new Pen(Color.Red, 2),
                        penB1 = new Pen(Color.White, 2),
                        penB2 = new Pen(Color.Black, 2);

                    Graphics g = Graphics.FromImage(view.Image);

                    g.DrawLine(penB1, LineSeg.xb, LineSeg.yb, LineSeg.xe, LineSeg.ye);
                    g.DrawLine(penB2, LineSeg.xb, LineSeg.yb, LSeg.xb, LSeg.yb);
                    g.DrawLine(penB0, LSeg.xb, LSeg.yb, LSeg.xe, LSeg.ye);
                    g.DrawLine(penB2, LSeg.xe, LSeg.ye, LineSeg.xe, LineSeg.ye);
                }
            }

            view.Refresh();
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

    public class MyLineSeg
    {
        public int xb, yb;
        public int xe, ye;

        public MyLineSeg(int xb, int yb, int xe, int ye)
        {
            this.xb = xb;
            this.yb = yb;
            this.xe = xe;
            this.ye = ye;
        }

        public override string ToString()
        {
            return "(" + xb.ToString() + ";" + yb.ToString() + ")" + " - " +
                   "(" + xe.ToString() + ";" + ye.ToString() + ")";
        }
    }
}
