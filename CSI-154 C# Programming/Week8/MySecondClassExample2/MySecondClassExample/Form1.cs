using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondClassExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of BankAccount (object)
            BankAccount joe = new BankAccount("    ", 456789, 100.0m);
            // use the default ctor: 2nd instance (object)
            BankAccount tim = new BankAccount();
            tim.Name = "Tim Ruller";
            tim.AccountNumber = 888888;
            tim.Balance = 10000.0m;

            tim.MyProperty = 100;

            richTextBox1.AppendText(joe.ToString() + "\n");
        }
    }
}
