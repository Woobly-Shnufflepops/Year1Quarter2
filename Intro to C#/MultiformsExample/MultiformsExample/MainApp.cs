using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiformsExample
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Create and run the second form
            SecondForm f2 = new SecondForm(); // this creates the form in memory
            // Run the form/display the form
            f2.Show();

            // Read the form 2 textbox
            string str = f2.textBox1.Text;
            // Assigns the text to the form 2 label
            f2.label1.Text = str;
        }
    }
}
