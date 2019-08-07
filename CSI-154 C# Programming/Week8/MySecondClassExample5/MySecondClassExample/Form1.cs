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
            //// Create an instance of BankAccount (object)
            //BankAccount joe = new BankAccount("    ", 456789, 100.0m);
            //// use the default ctor: 2nd instance (object)
            //BankAccount tim = new BankAccount();
            //tim.Name = "Tim Ruller";
            //tim.AccountNumber = 888888;
            //tim.Balance = 10000.0m;

            BankAccount[] accounts =
            {
                // 5 objects
                new BankAccount("customer1", 11111, 100.00m),
                new BankAccount("Customer2", 22222, 200.00m),
                new BankAccount("Customer3", 33333, 300.00m),
                new BankAccount("Customer4", 44444, 400.00m),
                new BankAccount("Customer5", 55555, 500.00m)
            };
            
            foreach (BankAccount acc in accounts)
            {
                richTextBox1.AppendText(acc.ToString() + "\n");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
