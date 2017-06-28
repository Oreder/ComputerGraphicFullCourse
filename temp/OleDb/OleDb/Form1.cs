using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OleDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdg = new OpenFileDialog();
            if (ofdg.ShowDialog() == DialogResult.OK)
            {
                linkedt.Text = ofdg.FileName;
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            string stringconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + linkedt.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(stringconn);
            if (linkedt.Text != "")
            {
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [" + sheet.Text + "$]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("ER");
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Position: " + dataGridView1.CurrentCell.RowIndex.ToString() + " : " + dataGridView1.CurrentCell.ColumnIndex.ToString(), "Index");
        }
    
        /* --------- ERROR --------- */
        private void Resize_Click(object sender, EventArgs e)
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[dataGridView1.Columns.Count];
            foreach (DataGridViewColumn c in columns)
                c.Width = 60;
            DataGridViewColumn head = dataGridView1.Columns[0];
            head.Width = 25;
        }
    }
}
