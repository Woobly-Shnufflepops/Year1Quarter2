// Author: Matthew Powers
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI156MidTermQuestion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cylinderCalc(out double area, out double volume)
        {
            double radius = Convert.ToDouble(textBoxRadius.Text);
            double height = Convert.ToDouble(textBoxHeight.Text);

            area = 2 * Math.PI * radius * height;
            volume = Math.PI * Math.Pow(radius, 2) * height;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double area;
            double volume;
            cylinderCalc(out area, out volume);
            label3.Text = area.ToString();
            label4.Text = volume.ToString();
        }
    }
}
