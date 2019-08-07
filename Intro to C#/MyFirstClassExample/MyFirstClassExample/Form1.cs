using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstClassExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create an object which represents an instance of the coin class
            Coin c = new Coin();

            Coin c2 = new Coin("Heads");

            c.Toss();
            richTextBox1.AppendText(c2.Face + "\n");
        }
    }
    // You could add your class here or define your class in a seperate file for beter organization
}
