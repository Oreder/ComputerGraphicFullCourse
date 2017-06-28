using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_overload
{
    class myClass
    {
        enum Names
        {
            Bob,
            Joe,
            Zedd,
        }

        enum other : byte
        {
            Bob = 1,
            Joe = 5,
            Zedd,
            Taylor = 8,
        }

        public void show()
        {
            MessageBox.Show(Names.Bob.ToString() + " vs " + other.Taylor.ToString());
            MessageBox.Show(Names.Bob.ToString() + " vs " + other.Taylor.GetHashCode().ToString());
        }

        public static void hello(string name)
        {
            MessageBox.Show("Hello, " + name + "!", "string");
        }
        
        public static void hello(int name)
        {
            MessageBox.Show(name.ToString(), "number");
        }
    }
}
