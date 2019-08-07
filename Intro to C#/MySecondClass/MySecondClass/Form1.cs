using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondClass
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
            BankAccount joe = new BankAccount("Joe", 588789, 100.0m);

            // Default ctor account: Second instance (object)
            BankAccount tim = new BankAccount();
            tim.Name = "Tim";
            tim.AccountNumber = 855669;
            tim.Balance = 367.92m;

            BankAccount[] accounts = { new BankAccount("Jim", 0001, 0.0m),
                new BankAccount("Dick", 0002, 0.0m),
                new BankAccount("Robert", 0003, 0.0m),
                new BankAccount("Kyle", 0004, 0.0m),
                new BankAccount("Jesus", 0005, 0.0m)};

            // tim.MyProperty = 100; Doesn't work because MyProperty's set value is private

            foreach(BankAccount acc in accounts)
            {
                richTextBox1.AppendText(acc.ToString());
            }
            richTextBox1.AppendText(tim.ToString());
            richTextBox1.AppendText("# of objects: " + BankAccount.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
