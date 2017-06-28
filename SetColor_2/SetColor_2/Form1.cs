using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetColor_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap BMP;
        bool detc = true, Zag = true;

        private void SetSeedPixel(int x, int y)
        {
            myPoint a = new myPoint(x, y, false);
            Color color = BMP.GetPixel(x, y);

            if (color.A == 0)
            {
                BMP.SetPixel(x, y, Color.Green);
                listCh.Items.Add(a);
            }
            else
            {
                MessageBox.Show("Unable to enter the seed pixel in place of another seed pixel or border!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrLine(int xb, int yb, int xe, int ye, Color color)
        {
            if (xb == xe && yb == ye)
                BMP.SetPixel(xb, yb, Color.Black);

            double dx = xe - xb;
            double dy = ye - yb;
            
            int L = (int)Math.Abs(dy);
            if (Math.Abs(dx) > Math.Abs(dy))
                L = (int)Math.Abs(dx);

            int sx = Math.Sign(dx), sy = Math.Sign(dy);
            dx = dx / L; dy = dy / L;
            
            double x = xb, y = yb;
            for (int i = 1; i <= L + 1; i += 1)
            {
                if (x > 0 && y > 0 && x < view.Width && y < view.Height)
                    BMP.SetPixel((int)Math.Round(x), (int)Math.Round(y), color);
                x += dx;
                y += dy;
            }
        }

        private void ADraw(int x, int y, int k)
        {
            myPoint a = new myPoint(x, y, detc), b;
            view.Image = BMP;
            Color color = Color.Black;
            Graphics g = Graphics.FromImage(view.Image);
            if (k != 1 || detc)
            {
                if (detc)
                {
                    listP.Items.Add(a);
                    BMP.SetPixel(a.X, a.Y, color);
                    detc = false;
                }
                else
                {
                    b = (myPoint)listP.Items[listP.Items.Count - 1];
                    listP.Items.Add(a);
                    DrLine(b.X, b.Y, a.X, a.Y, color);
                }
            }
            Zag = true;
        }

        private void closeFigure(int xb, int yb, int xe, int ye)
        {
            if (Zag)
            {
                view.Image = BMP;
                DrLine(xb, yb, xe, ye, Color.Black);
                detc = true;
            }
            Zag = false;
        }

        private void SetPointDraw(int x, int y)
        {
            int i = listP.Items.Count - 1;
            int k = 0;
            if (i > 0)
            {
                myPoint a = (myPoint)listP.Items[i];
                while ((((myPoint)listP.Items[i]).det == false) && (i != 0))
                {
                    i--;
                }
                myPoint b = (myPoint)listP.Items[i];
                if (x != b.X || y != b.Y)
                    ADraw(x, y, k);
                else
                    closeFigure(a.X, a.Y, b.X, b.Y);
            }
            else
                ADraw(x, y, k);
        }

        private void endP_Click(object sender, EventArgs e)
        {
            int i = listP.Items.Count - 1;
            myPoint a = (myPoint)listP.Items[i];
            while ((((myPoint)listP.Items[i]).det == false) && (i != 0))
            {
                i--;
            }
            myPoint b = (myPoint)listP.Items[i];
            closeFigure(a.X, a.Y, b.X, b.Y);
        }

        private void handAdd_Click(object sender, EventArgs e)
        {
            int x, y;
            try
            {
                x = int.Parse(edtX.Text);
                y = int.Parse(edtY.Text);
            }
            catch
            {
                if (MessageBox.Show("Invalid input! Coordinates must be only integer values.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Close();
                return;
            }
            if (radConfig.Checked)
                SetPointDraw(x, y);
            if (radPO.Checked)
            {

                int i = listP.Items.Count - 1;
                if (i > 1)
                {
                    myPoint a = (myPoint)listP.Items[i];
                    while ((((myPoint)listP.Items[i]).det == false) && (i != 0))
                    {
                        i--;
                    }
                    myPoint b = (myPoint)listP.Items[i];
                    closeFigure(a.X, a.Y, b.X, b.Y);
                }

                SetSeedPixel(x, y);
            }
            view.Refresh(); 
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BMP = new Bitmap(view.Width, view.Height);
            view.Image = BMP; radConfig.Checked = true; 
            listP.Items.Clear();
            listCh.Items.Clear();
            detc = true; 
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            Color colorR = Color.Green, colorB = Color.Black, colorP = Color.FromArgb(0); 
            int x, y;
            int xLeft, xRight; 
            int i, n;
            bool det1, det2, det3; 
            
            Stack<myPoint> myStack = new Stack<myPoint>();
            myPoint a; 
            while (listCh.Items.Count != 0)
            {
                n = listCh.Items.Count; 
                myStack.Push((myPoint)listCh.Items[n-1]);
                listCh.Items.RemoveAt(n-1); 
            }
            
            while (myStack.Count != 0)
            {
                a = myStack.Pop();
                x = a.X;
                y = a.Y; 
                xLeft = x-1;
                det3 = false; 
                
                BMP.SetPixel(x, y, colorR); 
                
                while (BMP.GetPixel(xLeft, y).ToArgb() == colorP.ToArgb())
                {
                    det3 = false; 
                    BMP.SetPixel(xLeft, y, colorR);
                    xLeft--;  
                }
                
                xLeft++; 
                xRight = x+1;
                while (BMP.GetPixel(xRight, y).ToArgb() == colorP.ToArgb())
                {
                    det3 = false; 
                    BMP.SetPixel(xRight, y, colorR);
                    xRight++;
                }
                
                xRight--;
                
                if (det3)
                    continue; 
                
                det1 = true; det2 = true; 
                
                for (i = xLeft; i <= xRight; i++)
                {
                    if (det1 && (BMP.GetPixel(i, y - 1).ToArgb() == colorB.ToArgb() || BMP.GetPixel(i, y - 1).ToArgb() == colorR.ToArgb()))
                        det1 = false;
                    if (det2 && (BMP.GetPixel(i, y + 1).ToArgb() == colorB.ToArgb() || BMP.GetPixel(i, y + 1).ToArgb() == colorR.ToArgb()))
                        det2 = false;
                    if (BMP.GetPixel(i, y - 1).ToArgb() == colorP.ToArgb() && BMP.GetPixel(i - 1, y - 1).ToArgb() == colorB.ToArgb())
                    {
                        a = new myPoint(i, y - 1, false);
                        myStack.Push(a);
                        det1 = false; 
                    }
                    if (BMP.GetPixel(i, y - 1).ToArgb() == colorP.ToArgb() && BMP.GetPixel(i + 1, y - 1).ToArgb() == colorB.ToArgb())
                    {
                        a = new myPoint(i, y - 1, false);
                        myStack.Push(a);
                        det1 = false; 
                    }
                    if (BMP.GetPixel(i, y + 1).ToArgb() == colorP.ToArgb() && BMP.GetPixel(i - 1, y + 1).ToArgb() == colorB.ToArgb())
                    {
                        a = new myPoint(i, y + 1, false);
                        myStack.Push(a);
                        det2 = false; 
                    }
                    if (BMP.GetPixel(i, y + 1).ToArgb() == colorP.ToArgb() && BMP.GetPixel(i + 1, y + 1).ToArgb() == colorB.ToArgb())
                    {
                        a = new myPoint(i, y + 1, false);
                        myStack.Push(a);
                        det2 = false; 
                    }
                }
                
                if (det1)
                {
                    a = new myPoint(x, y - 1, false);
                    myStack.Push(a); 
                }
                
                if (det2)
                {
                    a = new myPoint(x, y + 1, false);
                    myStack.Push(a); 
                }

                view.Refresh(); 
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            Point p = view.PointToClient(System.Windows.Forms.Cursor.Position);
            if (radConfig.Checked)
                SetPointDraw(p.X, p.Y);
            if (radPO.Checked)
            {
                int i = listP.Items.Count - 1;
                if (i > 1)
                {
                    myPoint a = (myPoint)listP.Items[i];
                    while ((((myPoint)listP.Items[i]).det == false) && (i != 0))
                    {
                        i--;
                    }
                    myPoint b = (myPoint)listP.Items[i];
                    closeFigure(a.X, a.Y, b.X, b.Y);
                }

                SetSeedPixel(p.X, p.Y);
            }
            view.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BMP = new Bitmap(view.Width, view.Height);
            radConfig.Checked = true; 
        }
    }

    public class myPoint
    {
        public int X, Y;
        public bool det;

        public myPoint(int X, int Y, bool det)
        {
            this.det = det; 
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            if (det)
                return "#[" + X.ToString() + " : " + Y.ToString() + "]";
            return "(" + X.ToString() + " : " + Y.ToString() + ")"; 
        }
    }
}

