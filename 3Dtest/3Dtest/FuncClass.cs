using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DF
{
    class FuncClass
    {
        public double f(double x, double z, int index)
        {
            double res = 0.0;

            switch (index)
            {
                case 0:
                    res = Math.Cos(x) * Math.Cos(z);
                    break;
                case 1:
                    res = Math.Sin(x) * z / 2; 
                    break;
                case 2:
                    res = Math.Cos(x + z);
                    break;
                case 3:
                    res = Math.Cos(x) + Math.Sin(z) * z;
                    break;
                case 4:
                    res = Math.Sin(x) * Math.Cos(z) * x;
                    break;
                default:
                    break;
            }

            return res;
        }
    }
}
