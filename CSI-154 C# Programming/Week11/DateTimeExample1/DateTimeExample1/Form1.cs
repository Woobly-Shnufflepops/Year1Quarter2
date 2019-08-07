using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(2017, 6, 20, 9, 0, 0);

            // The current time instance
            DateTime dt2 = DateTime.Now;
            CultureInfo ci = new CultureInfo("en-CA");
            richTextBox1.AppendText(dt2.ToLocalTime().ToString("F", ci) + "\n");
            TimeElapsed();
        }

        private void TimeElapsed()
        {
            // record the time before the loop runs in ticks
            long start = DateTime.Now.Ticks;
            int sum = 0;
            for (long i = 0; i < 10000000000; i++)
            {
                //sum += i;
            }
            // record the time in ticks after the loop terminates
            long end = DateTime.Now.Ticks;
            // Caluclate the elapsed time in ticks
            long time = end - start;
            richTextBox1.AppendText("Duration = " + time + " ticks\n");
            TimeSpan ts = new TimeSpan(time); // time in ticks
            richTextBox1.AppendText("Duration = " + ts.Milliseconds + " Milliseconds\n");
        }
    }
}
