using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpanExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(); // Midnight 1/1/0001

            DateTime dt2 = DateTime.Now;

            TimeSpan duration = dt2 - dt1;

            richTextBox1.AppendText("# of ticks: " + 
                duration.Ticks.ToString() + "\n");
            richTextBox1.AppendText("Total years: " + 
                duration.TotalDays/365 + "\n");

            richTextBox1.AppendText("Duration: " + 
                duration.ToString() + "\n");
            richTextBox1.AppendText("Days: " + duration.Days + "\n");
            richTextBox1.AppendText("Hours: " + duration.Hours + "\n");
            richTextBox1.AppendText("Minutes: " + duration.Minutes + "\n");
            richTextBox1.AppendText("Seconds: " + duration.Seconds + "\n");

            richTextBox1.AppendText("Total Days: " + duration.TotalDays + "\n");
        }
    }
}
