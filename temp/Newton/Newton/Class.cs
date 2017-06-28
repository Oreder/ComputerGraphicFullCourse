using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Red
{
    class IDE
    {
        public double Z(double x, double y)
        {
            return (2 * x * x - y * y);
        }

        public void findCo(int n, double[] x, double[] y, double[] a)
        {
            double[,] z = new double[n+1, n+1];

            for (int i = 0; i <= n; i++)
                z[0, i] = y[i];

            for (int i = 1; i <= n; i++)
                for (int j = 0; j <= n-i; j++)
                    z[i, j] = (z[i-1, j] - z[i-1, j+1]) / (x[0] - x[i]);

            for (int i = 0; i <= n; i++)
                a[i] = z[i, 0];
        }

        public double P(double X, int n, double[] x, double[] a)
        {
            double result = a[n];

            for (int i = n-1; i >= 0; i--)
                result = a[i] + (X - x[i]) * result;

            return result;
        }
    }
}
