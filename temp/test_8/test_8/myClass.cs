using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace back
{
    class myClass
    {
        string myName;
        public myClass(string name)
        {
            myName = name;
        }

        public string Name
        {
            get { return myName; }
            set
            {
                if (value == "")
                    System.Windows.Forms.MessageBox.Show("You can't do it!");
            }
        }

        static Exception myExc = new Exception("Empty string!");
        public static void checkString(string name)
        {
            if (name == "") throw myExc;
        }       // throw exception (using static to set exception)
    }
}
