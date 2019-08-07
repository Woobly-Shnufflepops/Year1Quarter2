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

        private void btnRunApp_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(); // Default = Midnight 1/1/0001

            DateTime dt2 = DateTime.Now;

            TimeSpan duration = dt2 - dt1;

            rchtxtbxDisplay.Clear();
            rchtxtbxDisplay.AppendText("# of ticks: " + duration.Ticks.ToString() + "\n");

            rchtxtbxDisplay.AppendText("Duration: " + duration.ToString() + "\n");
            rchtxtbxDisplay.AppendText("Total years: " + duration.Days / 365 + "\n");
            rchtxtbxDisplay.AppendText("Days: " + duration.Days%365.23 + "\n");
            rchtxtbxDisplay.AppendText("Hours: " + duration.Hours + "\n");
            rchtxtbxDisplay.AppendText("Minutes: " + duration.Minutes + "\n");
            rchtxtbxDisplay.AppendText("Seconds: " + duration.Seconds + "\n");

            rchtxtbxDisplay.AppendText("Total Days: " + duration.TotalDays + "\n");
        }
    }
}
