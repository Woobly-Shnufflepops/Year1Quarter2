using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTimerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // use the numeric up/down's value to let the user update the interval of the timer
            timer1.Interval = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Each tick, we display a random value to the list box
            Random rd = new Random();
            // int x = rd.Next(101); // between 0 and 100
            // Output the value by adding it to the list box
            // display the current time
            string x = DateTime.Now.ToLocalTime().ToString();
            listBox1.Items.Add(x);
            // Making the list scroll down: Have the code select the last item, so we need to set the SelectedItem property
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
