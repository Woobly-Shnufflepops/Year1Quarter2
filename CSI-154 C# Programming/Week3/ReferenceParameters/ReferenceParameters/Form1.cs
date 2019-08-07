using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = 600;
            int value2 = 400;
            int s, p, q, r;
            //Method1(ref value1, ref value2);
            MegaMethod(value1, value2, out s, out p,
                out q, out r);
            richTextBox1.AppendText(
                string.Format("{0}, {1}, {2}, {3}",
                s, p, q, r));
        }
        
        // method with 2 or more returns using
        // reference paramters
        private void Method1(ref int x, ref int y)
        {
            x++; // a change to x affects the argument
            y = 200; // same here
            richTextBox1.AppendText("x = " + x.ToString()
                + "\n");

            int z;
            Sum(200, 500, out z);
        }

        private bool Sum(int x, int y, out int result)
        {
            result = x + y;

            // if (int.TryParse(text, out var))
            return true;
        }

        // One arithmetic method:
        // calculates: sum, product, division, remainder
        // It should return 4 results/values besides
        // the boolean value
        private bool MegaMethod(int x, int y,
            out int sum,
            out int product,
            out int quotient,
            out int rem)
        {
            sum = x + y;
            product = x * y;
            quotient = x / y;
            rem = x % y;
            return true;
        }
    }
}
