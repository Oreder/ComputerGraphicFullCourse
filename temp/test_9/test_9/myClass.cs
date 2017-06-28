using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace
{
    class firstClass
    {
        private string name = "Jenny";      // private vs public
        public int age = 10;
        protected string job = "student";
        protected void message()        // public vs protected
        {
            System.Windows.Forms.MessageBox.Show(name);
        }

        public void show(string mes)
        {
            System.Windows.Forms.MessageBox.Show(mes);
        }

        public virtual void say(string mes)
        {
            System.Windows.Forms.MessageBox.Show(mes);
        }
    }

    class secondClass : firstClass
    {
        public static string color = "Green";
        
        public void specialMessage()
        {
            System.Windows.Forms.MessageBox.Show(base.age.ToString());
            base.message();         // can use in protected
            System.Windows.Forms.MessageBox.Show(base.job);
        }

        public new void show(string mes)
        {
            System.Windows.Forms.MessageBox.Show(mes + " $$$", "no title");
        }

        public override void say(string mes)
        {
            System.Windows.Forms.MessageBox.Show(mes, "Fantastic!");
        }
    }
}
