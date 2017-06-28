using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            List<int> number = new List<int>();
            for (int i = 0; i < 5; i++)
                number.Add((int) Math.Pow(i + 1, 2));

            foreach (int n in number)
                textBox1.Text += n.ToString() + " ";

            List<string> list = new List<string>();
            list.Add("Bob");
            list.Add("Lisa");
            list.Add("Mary"); // "Lisa", "Mary", "Jo", "Zedd""
            list.Add("Jo");
            list.Add("Zedd");

            foreach (string s in list)
                MessageBox.Show("Hello, " + s + "!", "Welcome to test");
        }
    }
}
