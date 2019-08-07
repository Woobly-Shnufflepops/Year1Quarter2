using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultifomsExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create and run the second form.
            SecondForm f2 = new SecondForm(); // this creates the form in memory
            // Run the form/ display the form
            
            f2.Show();

            // read the form 2 textbox
            string str = f2.textBox1.Text;
            // assign the text to Form 2 label
            f2.label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
