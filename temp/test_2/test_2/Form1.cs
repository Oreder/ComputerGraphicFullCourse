using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("There is something wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Retry)
                Close();
        }

        private void clickBtn_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button!");
        }

        private void show_Click(object sender, EventArgs e)
        {
            //textBox1.MaxLength = 2;
            MessageBox.Show("Hi, " + textBox1.Text + "!", "Welcome to test");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (check.Checked)
                MessageBox.Show("Test was checked!");
            else
                check.Text = "Clear";
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            bool sat = true;

            try
            {
                double tmp = double.Parse(textBox1.Text);
            }
            catch
            {
                sat = false;
                if (MessageBox.Show("Fail to convert your input!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    textBox1.Clear();
                else
                    Close();
            }

            if (sat)
            {
                double res = double.Parse(textBox1.Text);
                MessageBox.Show(res.ToString(), "Result");
            }
        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            switch(textBox1.Text)
            {
                case "1":
                    check.Text = "Case #1";
                    break;
                case "2":
                    check.Text = "Case #2";
                    break;
                default:
                    check.ResetText();
                    break;
            }
        }

        private void arrBtn_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i = 0;
            while (MessageBox.Show("Time: #" + arr[i].ToString(), "Show", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
            {
                i++;
                if (i % 9 == 0)
                    i = 0;
            }
        }

        private void stringBtn_Click(object sender, EventArgs e)
        {
            string[] back = new string[5];
            back[0] = "AAAAAA";
            back[1] = "BBBBBB";
            back[2] = "CCCCCC";
            back[3] = "DDDDDD";
            back[4] = "EEEEEE";

            switch(textBox1.Text)
            {
                case "1":
                    MessageBox.Show(back[int.Parse(textBox1.Text)-1], "string");
                    break;
                default:
                    MessageBox.Show("Error!");
                    break;
            }
        }
    }
}
