using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;                        /// STREAM 
using System.Text.RegularExpressions;   /// REGEX.SPLIT

namespace Stream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arr;

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            var fileStream = new FileStream(@"E:\C Sharp\Stream\Stream\dat.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    // process the line
                    string input = line;
                    // Split on one or more non-digit characters.
                    string[] numbers = Regex.Split(input, @"\D+");
                    foreach (string value in numbers)
                    {
                        if (!string.IsNullOrEmpty(value))
                        {
                            int i = int.Parse(value);
                            list.Add(i);
                        }
                    }
                }
            }
            fileStream.Close();
            nBox.Text = list.Count.ToString();
            arr = list.ToArray();
            foreach (int item in arr)
            {
                listBox.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            nBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            listBox.Items.Clear();
            foreach (int i in arr)
            {
                listBox.Items.Add(i);
            }
        }
    }
}
