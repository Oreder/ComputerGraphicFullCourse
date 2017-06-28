using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double z(double x, double y) { return Math.Pow(x, 2) + y; }

        private void genBtn_Click(object sender, EventArgs e)
        {
            int NC, NR;
            if (!int.TryParse(NCol.Text, out NC))
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!int.TryParse(NRow.Text, out NR))
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            tab.ColumnCount = NC;
            tab.RowCount = NR;
            
        }
    }
}
