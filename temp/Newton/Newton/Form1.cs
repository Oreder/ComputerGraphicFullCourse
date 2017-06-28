using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Red;

namespace Newton
{
    public partial class Form1 : Form
    {
        IDE GUI = new IDE();
        int NC, NR;
        double[,] z, ZN;
        public Form1()
        {
            InitializeComponent();
        }

        private void setTAB_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Ncol.Text, out NC) || !int.TryParse(Nrow.Text, out NR))
                MessageBox.Show("Invalid sizes of table!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((NC < 1) || (NR < 1))
                MessageBox.Show("Can not initialize table with given sizes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tab.ColumnCount = NC + 1;
                tab.RowCount = NR + 1;

                for (int i = 1; i <= NC; i++)
                    tab[i, 0].Value = i.ToString();

                for (int i = 1; i <= NR; i++)
                    tab[0, i].Value = (i-2).ToString();

                z = new double[NR, NC];
                tab[0, 0].Value = "X / Y";
                for (int i = 1; i <= NR; i++)
                    for (int j = 1; j <= NC; j++)
                    {
                        z[i-1, j-1] = GUI.Z(double.Parse((string)tab[j, 0].Value), double.Parse((string)tab[0, i].Value));
                        tab[j, i].Value = z[i-1, j-1].ToString();
                    }
            }
        }

        private int choose(double x0, double y0, int nx, int ny)
        {
            int i;

            for (i = 0; i < NC; i++)
                if (x0 > z[0, i])
                    break;
            if (i == 0 || i == NC + 1)
            {
                MessageBox.Show("Input X was out of range!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return -1;
            }
            else
            {
                int ilef = i - 1, irig = i;

                for (i = 0; i < NC; i++)
                    if (x0 > z[0, i])
                        break;
                if (i == 0 || i == NR + 1)
                {
                    MessageBox.Show("Input Y was out of range!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return -1;
                }
                else
                {
                    int jlef = i-1, jrig = i;
                    int i0 = (nx + 1) / 2, j0 = (ny + 1) / 2;

                    ZN = new double[nx + 1, ny + 1];
                    //for (int )
                }
                
            }
            
            
            
            i = 0;
            while (y0 > z[i, 0])
                i++;
            jlef = i-1; 

        }

        private void cal_Click(object sender, EventArgs e)
        {
            int Nx = 0, Ny = 0;
            double x0, y0;
            if (!int.TryParse(NX.Text, out Nx) || !int.TryParse(NY.Text, out Ny) ||
                !double.TryParse(edtX.Text, out x0) || !double.TryParse(edtY.Text, out y0))
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (Nx < 0 || Nx > NC || Ny < 0 || Ny > NR)
                MessageBox.Show("Given degree of polynomial is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                
            }
        }
    }
}
