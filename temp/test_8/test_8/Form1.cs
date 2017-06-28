using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using back;

namespace test_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myClass mc = new myClass("David");
            //mc.Name = "";         // error when private set
            mc.Name = "Bill";
            MessageBox.Show(mc.Name);

            myClass.checkString("Go");

            try
            {
                myClass.checkString("");
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message);
                //MessageBox.Show(myExc.ToString());
            }
        }
    }
}
