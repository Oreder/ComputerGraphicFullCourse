using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message();
        }
        void message()      // public
        {
            MessageBox.Show("Good jobs!", "Title..");
        }

        int message_2(string mes, string title)
        {
            MessageBox.Show(mes, title);
            return -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good jobs!", "Title..");
            message_2("Michael Jackson", "Back to ..");
        }
    }
}
