using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test_overload;

namespace test_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            myClass.hello("Jeny");
            myClass.hello(5);

            myClass mc = new myClass();
            mc.show();
        }
    }
}
