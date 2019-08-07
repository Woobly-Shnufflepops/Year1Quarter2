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

        private void btnRunApp_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(1992, 07, 10);
            DateTime dt2 = DateTime.Now;
            CultureInfo ci = new CultureInfo("");
            rchtxtbxDisplay.Clear();
            rchtxtbxDisplay.AppendText(dt1.ToString("F") + "\n");
            rchtxtbxDisplay.AppendText(dt2.ToString("F") + "\n");
            rchtxtbxDisplay.AppendText((dt2 - dt1).ToString() + "\n");
            TimeElapsed();
        }

        private void TimeElapsed()
        {
            // record the time before the loop runs in ticks
            long start = DateTime.Now.Ticks;
            int sum = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                sum += i;
            }
            // record the time in ticks after the loop terminates
            long end = DateTime.Now.Ticks;
            // Calculate the elapsed time in ticks
            long time = end - start;
            TimeSpan ts = new TimeSpan(time);
            rchtxtbxDisplay.AppendText("Duration = " + ts.Milliseconds + " mili-seconds\n");
        }
    }
}
