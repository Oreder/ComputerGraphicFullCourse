using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mynamespace
{
    class myClass
    {
        public int factor(int n)
        {
            int f = 1;
            if (n > 1)
            {
                for (int i = n; i > 1; i--)
                    f *= i;
            }
            return f;
        }
        public static void hello(string name)
        {
            MessageBox.Show("Hello, " + name + "!", "Just test");
        }
    }
}
