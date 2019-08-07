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
            // creare an object which represents an instance of the
            // coin class
            Coin c = new Coin();

            Coin c2 = new Coin("heads");

            c.Toss();

            richTextBox1.AppendText("Object setting: " + c2.Face
                + "\n");
        }
    }

    // You could add your class here
    // or define your class in a separate file
    // for better organization
}
