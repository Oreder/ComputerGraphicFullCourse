using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Code_PG;

namespace SetColor_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BMP = new Bitmap(view.Width, view.Height);
        }

        Bitmap BMP;
        bool last = true, Zag = true;

        private void DrawLine(int Xb, int Yb, int Xe, int Ye, Color color)
        {
            double a, b;
            BMP.SetPixel(Xb, Yb, color);
            BMP.SetPixel(Xe, Ye, color);
            
            if (Yb == Ye)
                return;
            else
            {
                a = (Xe - Xb) / (double)(Ye - Yb);
                b = Xe - a * Ye;
            }

            int dx = Xe - Xb, dy = Ye - Yb;
            int sx = Math.Sign(dx), sy = Math.Sign(dy);
            
            int y = Yb + sy;
            while (y != Ye)
            {
                int x = (int)Math.Round(a * y + b);
                while (BMP.GetPixel(x, y).A == 255)
                    x -= sx;
             
                BMP.SetPixel(x, y, color);
                y += sy;
            }
        }

        private void LineTo(int Xb, int Yb, int Xe, int Ye, Color color)
        {
            if (Xb == Xe && Yb == Ye)
                BMP.SetPixel(Xb, Yb, Color.Black);
            
            double dx = Xe - Xb, dy = Ye - Yb;
            
            int L = (int)Math.Abs(dy);
            if (Math.Abs(dx) > Math.Abs(dy))
                L = (int)Math.Abs(dx);
            
            dx = dx / L; dy = dy / L;
            double x = Xb, y = Yb;
            for (int i = 1; i <= L + 1; i++)
            {
                if (x > 0 && y > 0 && x < view.Width && y < view.Height)
                    BMP.SetPixel((int)Math.Round(x), (int)Math.Round(y), color);
                
                x += dx; y += dy;
            }
        }

        // Draw absolute pixel
        private void AbsDraw(int x, int y)
        {
            myPoint A = new myPoint(x, y, last), B;
            
            view.Image = BMP;
            Color color = Color.Black;
            
            if (last)
            {
                listP.Items.Add(A);
                BMP.SetPixel(A.X, A.Y, color);
                last = false;
            }
            else
            {
                B = (myPoint)listP.Items[listP.Items.Count - 1];
                listP.Items.Add(A);
                LineTo(B.X, B.Y, A.X, A.Y, color);
            }

            Zag = true;
        }

        // Addition points by hand
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

            int i = listP.Items.Count - 1;
            if (i > 1)
            {
                myPoint a = (myPoint)listP.Items[i];
                while ((((myPoint)listP.Items[i]).det == false) && (i != 0))
                {
                    i--;
                }
                myPoint b = (myPoint)listP.Items[i];
                if (x != b.X || y != b.Y)
                    AbsDraw(x, y);
                else
                    closeFigure(a.X, a.Y, b.X, b.Y);
            }
            else
                AbsDraw(x, y);
        }

        // Close configuration
        private void closeFigure(int Xb, int Yb, int Xe, int Ye)
        {
            if (Zag)
            {
                view.Image = BMP;
                LineTo(Xb, Yb, Xe, Ye, Color.Black);
                last = true;
            }

            Zag = false;
        }

        private void endP_Click(object sender, EventArgs e)
        {
            int i = listP.Items.Count - 1;
            
            myPoint A = (myPoint)listP.Items[i];
            
            while ((((myPoint)listP.Items[i]).det == false) && (i != 0))
                i--;
            
            myPoint B = (myPoint)listP.Items[i];
            
            closeFigure(A.X, A.Y, B.X, B.Y);
        }

        private void view_MouseClick(object sender, EventArgs e)
        {
            Point p = view.PointToClient(Cursor.Position);
            
            int i = listP.Items.Count - 1;
            
            if (i > 2)
            {
                myPoint A = (myPoint)listP.Items[i];
                
                while ((((myPoint)listP.Items[i]).det == false) && (i != 0))
                    i--;
        
                myPoint B = (myPoint)listP.Items[i];
                
                if (p.X != B.X || p.Y != B.Y)
                    AbsDraw(p.X, p.Y);
                else
                    closeFigure(A.X, A.Y, B.X, B.Y);
            }
            else
                AbsDraw(p.X, p.Y);
        }

        // MAIN
        private void Fill_Click(object sender, EventArgs e)
        {
            BMP = new Bitmap(view.Width, view.Height);
            view.Image = BMP;
            
            int X0 = 0, Y0 = 0, N0 = listP.Items.Count;
            
            for (int i = 0; i < listP.Items.Count - 1; i++)
            {
                if (((myPoint)listP.Items[i + 1]).det != true)
                {
                    DrawLine(((myPoint)listP.Items[i]).X, ((myPoint)listP.Items[i]).Y, ((myPoint)listP.Items[i + 1]).X, ((myPoint)listP.Items[i + 1]).Y, Color.Black);
                }
                else
                {
                    DrawLine(((myPoint)listP.Items[i]).X, ((myPoint)listP.Items[i]).Y, X0, Y0, Color.Black);
                }
                
                if (((myPoint)listP.Items[i]).det)
                {
                    X0 = ((myPoint)listP.Items[i]).X;
                    Y0 = ((myPoint)listP.Items[i]).Y;
                }
            }
            
            DrawLine(((myPoint)listP.Items[N0 - 1]).X, ((myPoint)listP.Items[N0 - 1]).Y, X0, Y0, Color.Black);

            List<int> SavedY = new List<int>();
            view.Image = BMP;
            
            // Side Working
            for (int i = 0; i <= listP.Items.Count - 1; i++)
            {
                myPoint a, b, c;
                
                if (((myPoint)listP.Items[i]).det)
                {
                    int k = i + 1;
                    while ((k != listP.Items.Count - 1) && (((myPoint)listP.Items[k + 1]).det == false))
                        k++;
                    a = (myPoint)listP.Items[k];
                }
                else
                    a = (myPoint)listP.Items[i - 1];
                
                b = (myPoint)listP.Items[i];
                
                if (i == listP.Items.Count - 1 || ((myPoint)listP.Items[i + 1]).det)
                {
                    int k = i - 1;
                    while ((((myPoint)listP.Items[k]).det == false) && (k != 0))
                        k--;
                    
                    c = (myPoint)listP.Items[k];
                }
                else
                    c = (myPoint)listP.Items[i + 1];
                
                if ((b.Y > a.Y && b.Y > c.Y) || (b.Y < a.Y && b.Y < c.Y))
                {
                    if (BMP.GetPixel(b.X + 1, b.Y).A == BMP.GetPixel(b.X - 1, b.Y).A)
                        BMP.SetPixel(b.X + 1, b.Y, Color.Black);
                }
                else if (b.Y == a.Y || b.Y == c.Y)
                {
                    SavedY.Add(b.Y);
                }
            }
            
            // Float fill
            Color color;

            for (int i = 0; i < BMP.Height - 1; i++)
            {
                if (SavedY.Contains(i))
                {
                    for (int j = 0; j < BMP.Width - 1; j++)
                    {
                        color = BMP.GetPixel(j, i - 1);
                        BMP.SetPixel(j, i, color);
                    }
                }
                else
                {
                    bool flag = false;
                    
                    for (int j = 0; j < BMP.Width - 1; j++)
                    {
                        color = BMP.GetPixel(j, i);
                        if (color.A == 255)
                        {
                            flag = !flag;
                        }
                       
                        if (flag == true)
                        {
                            BMP.SetPixel(j, i, Color.OrangeRed);
                        }
                        else
                        {
                            BMP.SetPixel(j, i, Color.White);
                        }
                    }
                    view.Refresh();
                    System.Threading.Thread.Sleep(5);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BMP = new Bitmap(view.Width, view.Height);
            view.Image = BMP;
            listP.Items.Clear();
            last = true;
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
                return "[" + X.ToString() + " : " + Y.ToString() + "]";
            return "(" + X.ToString() + " : " + Y.ToString() + ")"; 
        }
    }
}