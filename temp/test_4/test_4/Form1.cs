using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] name = new string[2]; // 2 elements 0, 1
                string s = name[int.Parse(textBox1.Text)];
            }
            catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Catch in exception", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    Close();
            }
            finally
            {
                MessageBox.Show("Your code is done!", "Finally");
            }
        }
    }
}
