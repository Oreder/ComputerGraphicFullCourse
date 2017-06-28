using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        Graphics drawArea;

        public Form1()
        {
            InitializeComponent();
            drawArea = drawingArea.CreateGraphics();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            bool check = true;

            try
            {
                double x = double.Parse(textBox1.Text);
            }
            catch
            {
                check = false;
                MessageBox.Show("Invalid input! Try again!", "notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (check == true)
            {
                double x = double.Parse(textBox1.Text);
                double y = Math.Pow(x, 3);
                textBox2.Text = y.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "notice", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void draw_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            //drawArea.DrawLine(blackPen, 0, 0, 500, 0);
            drawArea.DrawRectangle(blackPen, 0, 0, 480, 360);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
