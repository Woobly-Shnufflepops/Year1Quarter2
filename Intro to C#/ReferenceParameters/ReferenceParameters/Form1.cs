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
    public partial class refParam : Form
    {
        public refParam()
        {
            InitializeComponent();
        }

        private void runApp_Click(object sender, EventArgs e)
        {
            int value1 = 600;
            int value2 = 400;
            int s, p, q, r;
            // Method1(ref value1, ref value2);
            // Arguments are the values/variables passed to a called method
            MegaMethod(value1, value2, out s, out p, out q, out r);
            txtBoxRefParam.AppendText(string.Format("{0}, {1}, {2}, {3}", s, p, q, r));
        }

        // method with 2+ returns using reference parameters
        // Parameters are the variables that accept values from a call to the method

        private void Method1(ref int x, ref int y)
        {
            x++; // A change to x affects the argument
            y = 200; // A change to y also affects the argument
            txtBoxRefParam.AppendText("x = " + x.ToString() + "\n" + "y = " + y.ToString() + "\n");

            int z;
            Sum(200, 500, out z);
        }

        private bool Sum(int x, int y, out int result)
        {
            result = x + y;

            //if (int.TryParse(Text, out var))
            return true;
        }

        // one arithmetic method:
        // Calculates: Sum, product, division, and remainder
        // It should return 4 results/values besides the boolean value
        private bool MegaMethod(int x, int y, out int sum, out int product, out int quotient, out int remainder)
        {
            sum = x + y;
            product = x * y;
            quotient = x / y;
            remainder = x % y;
            return true;
        }
    }
}
