using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxesAndPanels
{
    public partial class CheckBoxesAndPanels : Form
    {
        public CheckBoxesAndPanels()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price = 12;

            if (checkBox1.Checked)
            {
                price += 1.5m;
            }
            if (checkBox2.Checked)
            {
                price += 2m;
            }
            if (checkBox3.Checked)
            {
                price += 0.5m;
            }
            if (checkBox4.Checked)
            {
                price += 3m;
            }

            MessageBox.Show("You pay " +
                price.ToString("C"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // use a try block to check for errors
            // any erros caught will make the execution
            // jump to one or more catch blocks
            int x1 = 0;
            int x2 = 0;
            try
            {
                // input from text box 1
                x1 = int.Parse(textBox1.Text);
                // input from text box 2
                x2 = int.Parse(textBox2.Text);
                MessageBox.Show(
                  string.Format("You entered {0} and {1}", x1, x2));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
