using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CClass;

namespace Circle
{
    public partial class Form1 : Form
    {
        CircleClass ICE = new CircleClass();
        Graphics GPX;
        Bitmap bmp;
        Color color;
        
        int XC, YC, R, A, B;
        int width, height;

        public Form1()
        {
            InitializeComponent();
            width  = view.Size.Width;
            height = view.Size.Height;

            bmp = new Bitmap(width, height);
            GPX = Graphics.FromImage(bmp);

            GPX = view.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CX.Text = (view.Size.Width / 2).ToString();
            CY.Text = (view.Size.Height / 2).ToString();
            RA.Text = "100";
            Color1_Click(sender, e);
            Cbox1.SelectedIndex = 0;
            radioC.Checked = true;
            radioE_CheckedChanged(sender, e);
        }

        private int check_input(object sender)
        {
            int tmp;
            
            if (!int.TryParse(CX.Text, out tmp) || tmp < 0 || tmp > width)
                return -1;
            
            if (!int.TryParse(CY.Text, out tmp) || tmp < 0 || tmp > height)
                return -1;
            
            if (radioC.Checked)
            {
                if (!int.TryParse(RA.Text, out tmp) || tmp <= 0)
                    return -1;
            }
            
            if (radioE.Checked)
            {
                if (!int.TryParse(Aedt.Text, out tmp) || tmp <= 0)
                    return -1;

                if (!int.TryParse(Bedt.Text, out tmp) || tmp <= 0)
                    return -1;
            }

            return 0;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            if (check_input(sender) == -1)
                MessageBox.Show("Invalid input! Try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                XC = int.Parse(CX.Text); YC = int.Parse(CY.Text);
                
                if (radioC.Checked)
                {
                    R = int.Parse(RA.Text);

                    switch (Cbox1.SelectedIndex)
                    {
                        case 0:
                            ICE.Cano(bmp, XC, YC, R, R, color);
                            view.Image = bmp;
                            break;
                        case 1:
                            ICE.Para(bmp, XC, YC, R, R, color);
                            view.Image = bmp;
                            break;
                        case 2:
                            ICE.Bresenham(bmp, XC, YC, R, R, color);
                            view.Image = bmp;
                            break;
                        case 3:
                            ICE.Midpoint(bmp, XC, YC, R, R, color);
                            view.Image = bmp;
                            break;
                        case 4:
                        default:
                            view.CreateGraphics().DrawEllipse(new Pen(color), XC - R, YC - R, 2 * R, 2 * R);
                            break;
                    }
                }

                if (radioE.Checked)
                {
                    A = int.Parse(Aedt.Text); B = int.Parse(Bedt.Text);

                    switch (Cbox1.SelectedIndex)
                    {
                        case 0:
                            ICE.Cano(bmp, XC, YC, A, B, color);
                            view.Image = bmp;
                            break;
                        case 1:
                            ICE.Para(bmp, XC, YC, A, B, color);
                            view.Image = bmp;
                            break;
                        case 2:
                            ICE.Bresenham(bmp, XC, YC, A, B, color);
                            view.Image = bmp;
                            break;
                        case 3:
                            ICE.Midpoint(bmp, XC, YC, A, B, color);
                            view.Image = bmp;
                            break;
                        case 4:
                        default:
                            view.CreateGraphics().DrawEllipse(new Pen(color), XC - A, YC - B, 2 * A, 2 * B);
                            break;
                    }
                }
            }
        }

       private void clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Size.Width; i++)
                for (int j = 0; j < bmp.Size.Height; j++)
                    bmp.SetPixel(i, j, Color.White);
            view.Image = bmp;
        }

        private void axisBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < bmp.Size.Height; i++)
                bmp.SetPixel(bmp.Size.Width / 2, i, Color.CornflowerBlue);

            for (int i = 1; i < bmp.Size.Width; i++)
                bmp.SetPixel(i, bmp.Size.Height / 2, Color.CornflowerBlue);

            view.Image = bmp;
        }

        private void radioE_CheckedChanged(object sender, EventArgs e)
        {
            if (radioE.Checked)
            {
                radius.Hide(); drawBtn.Text = "Draw Ellipse";
                Aedt.Show(); Bedt.Show();
                label4.Show(); label5.Show();
            }
            else
            {
                radius.Show(); drawBtn.Text = "Draw Circle";
                Aedt.Hide(); Bedt.Hide();
                label4.Hide(); label5.Hide();
            }
        }

        private void Color1_Click(object sender, EventArgs e)
        {
            color = Color.Black;
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label6.Font = new Font(label6.Font, FontStyle.Regular);
        }

        private void Color2_Click(object sender, EventArgs e)
        {
            color = Color.White;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            label1.Font = new Font(label1.Font, FontStyle.Regular);
        }

        private void RingBtn_Click(object sender, EventArgs e)
        {
            int r = (int)double.Parse(Redt.Text);
            
            if (r <= 0)
                MessageBox.Show("Invalid input! Radius can NOT be smaller than ZERO. Try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //clear_Click(sender, e); Color1_Click(sender, e);
                // color = ... /// CHANGE HERE
                XC = view.Size.Width / 2; YC = view.Size.Height / 2;

                int step = (int)stepbox.Value;
                if (radioC.Checked)
                {
                    for (int Rk = r; Rk > 0; Rk = Rk - step)
                    {
                        switch (Cbox1.SelectedIndex)
                        {
                            case 1:
                                ICE.Para(bmp, XC, YC, Rk, Rk, color);
                                view.Image = bmp;
                                break;
                            case 2:
                                ICE.Bresenham(bmp, XC, YC, Rk, Rk, color);
                                view.Image = bmp;
                                break;

                            case 3:
                                ICE.Midpoint(bmp, XC, YC, Rk, Rk, color);
                                view.Image = bmp;
                                break;
                            case 0:
                            default:
                                ICE.Cano(bmp, XC, YC, Rk, Rk, color);
                                view.Image = bmp;
                                break;
                        }
                    }
                }

                if (radioE.Checked)
                {
                    A = int.Parse(Aedt.Text); B = int.Parse(Bedt.Text);

                    for (int Rx = A, Ry = B; Rx > 0 && Ry > 0; )
                    {
                        switch (Cbox1.SelectedIndex)
                        {
                            case 1:
                                ICE.Para(bmp, XC, YC, Rx, Ry, color);
                                view.Image = bmp;
                                break;
                            case 2:
                                ICE.Bresenham(bmp, XC, YC, Rx, Ry, color);
                                view.Image = bmp;
                                break;

                            case 3:
                                ICE.Midpoint(bmp, XC, YC, Rx, Ry, color);
                                view.Image = bmp;
                                break;
                            case 0:
                            default:
                                ICE.Cano(bmp, XC, YC, Rx, Ry, color);
                                view.Image = bmp;
                                break;
                        }
                        Rx -= step; Ry -= (int)(B / A * step);
                    }
                }
            }
        }
    }
}
