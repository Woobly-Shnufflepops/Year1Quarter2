using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioAndText
{
    public partial class RadioAndTextApp : Form
    {
        public RadioAndTextApp()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Parse the text in the textbox and extract the value
            string input = inputTextBox.Text;
            int value = int.Parse(input);
            double area = 0;

            // check the user's selection from the radio buttons
            if (circleRadioButton.Checked)
            {
                // calculate the circle area
                area = Math.PI * Math.Pow(value, 2);
            } else if (squareRadioButton.Checked)
            {
                // claculate the square area
                area = Math.Pow(value, 2);
            } else if (triangleRadioButton.Checked)
            {
                // claculate the  triangle area
                area = Math.Sqrt(3) / 4 * Math.Pow(value, 2);
            } else
            {
                // Error: no selection
            }

            MessageBox.Show("Area = " + area.ToString("f2"));

        }
    }
}
