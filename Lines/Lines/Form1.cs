using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LineClass;

namespace Lines
{
    public partial class Form1 : Form
    {
        LINEC IDE = new LINEC();
        Graphics GPX;
        Bitmap bmp;
        Pen pen;

        int width, height;
        int mov_X, mov_Y;

        public Form1()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            
            width = view.Size.Width; height = view.Size.Height;
            bmp = new Bitmap(width, height);
            
            GPX = Graphics.FromImage(bmp);
            view.Image = bmp;

            mov_X = width / 2; mov_Y = height / 2;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2;
            
            if (!int.TryParse(XBP.Text, out x1) || !int.TryParse(XEP.Text, out x2) ||
                !int.TryParse(YBP.Text, out y1) || !int.TryParse(YEP.Text, out y2))
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                x1 = mov_X + x1; y1 = mov_Y - y1;
                x2 = mov_X + x2; y2 = mov_Y - y2;
                switch (comboBox.SelectedIndex)
                {
                    case 0: 
                        IDE.DDA(bmp, x1, y1, x2, y2, ColorPen.BackColor);
                        break;
                    case 1:
                        IDE.Bresenham_R(bmp, x1, y1, x2, y2, ColorPen.BackColor);
                        break;

                    case 2:
                        IDE.Bresenham_Z(bmp, x1, y1, x2, y2, ColorPen.BackColor);
                        break;

                    case 3:
                        IDE.Bresenham_E(bmp, x1, y1, x2, y2, ColorPen.BackColor, ColorBackground.BackColor);
                        break;
                    case 4:
                    default:
                        IDE.DDA(bmp, x1, y1, x2, y2, ColorPen.BackColor);
                        break;
                }
            
                view.Image = bmp;
            }
        }

        private void ColorPen_Click(object sender, EventArgs e)
        {
            DialogResult choose = colorDialog.ShowDialog();
            if (choose == DialogResult.OK)
            {
                ColorPen.BackColor = colorDialog.Color;
                pen = new Pen(ColorPen.BackColor);
            }
        }

        private void ColorBackground_Click(object sender, EventArgs e)
        {
            DialogResult choose = colorDialog.ShowDialog();
            if (choose == DialogResult.OK)
            {
                ColorBackground.BackColor = colorDialog.Color;
                view.BackColor = ColorBackground.BackColor;
            }
        }

        private void drC_Click(object sender, EventArgs e)
        {
            int x1, y1;
            double Rad, step;

            if (!int.TryParse(XBP.Text, out x1) || !int.TryParse(YBP.Text, out y1) ||
                !double.TryParse(radius.Text, out Rad)|| !double.TryParse(angle.Text, out step))
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Rad <= 0 || step == 0)
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                x1 = mov_X + x1; y1 = mov_Y - y1;
                int x2 = x1 + (int)Rad, y2 = y1;
                int tx = x2, ty = y2, k = (int)(360 / step);
                step = step * Math.PI / 180;
                for (int i = 0; i <= k; i++)
                {
                    switch (comboBox.SelectedIndex)
                    {
                        case 0:
                            IDE.DDA(bmp, x1, y1, x2, y2, ColorPen.BackColor);
                            break;
                        case 1:
                            IDE.Bresenham_R(bmp, x1, y1, x2, y2, ColorPen.BackColor);
                            break;

                        case 2:
                            IDE.Bresenham_Z(bmp, x1, y1, x2, y2, ColorPen.BackColor);
                            break;

                        case 3:
                            IDE.Bresenham_E(bmp, x1, y1, x2, y2, ColorPen.BackColor, ColorBackground.BackColor);
                            break;

                        default:
                            GPX.DrawLine(pen, x1, y1, x2, y2);
                            break;
                    }
                    
                    x2 = (int)(x1 + (tx - x1) * Math.Cos(step * i) + (ty - y1) * Math.Sin(step * i));
                    y2 = (int)(y1 - (tx - x1) * Math.Sin(step * i) + (ty - y1) * Math.Cos(step * i));
                }
            }

            view.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorBackground.BackColor = Color.White;
            ColorPen.BackColor = Color.Black;
        }

        private void axisBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < bmp.Size.Height; i++)
                bmp.SetPixel(bmp.Size.Width / 2, i, Color.CornflowerBlue);

            for (int i = 1; i < bmp.Size.Width; i++)
                bmp.SetPixel(i, bmp.Size.Height / 2, Color.CornflowerBlue);
            
            view.Image = bmp;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Size.Width; i++)
                for (int j = 0; j < bmp.Size.Height; j++)
                    bmp.SetPixel(i, j, ColorBackground.BackColor);
            view.Image = bmp;
        }
    }
}
