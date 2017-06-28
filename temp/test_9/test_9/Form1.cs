using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myNamespace;

namespace test_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secondClass sc = new secondClass();
            
            sc.specialMessage();

            //firstClass fc = new firstClass();

            //fc.message();     // error in protected

            MessageBox.Show(secondClass.color);

            sc.show("Wow");

            sc.say(secondClass.color);
        }
    }
}
