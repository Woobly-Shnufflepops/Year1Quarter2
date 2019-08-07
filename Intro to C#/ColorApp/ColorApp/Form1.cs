using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorApp
{
    // Examples of enumeration types
    // enumeration of color
    enum Spectrum
    {
        Red = 10, // was 0
        Green, // 11, was 1
        Blue, // 12, was 2
        Violet, // 13, was 3
        Yellow, // 14, was 4
        Orange // 15, was 5
    }

    enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    enum RGB
    {
        Red,
        Green,
        Blue
    }

    // Enumeration of courses
    enum Courses
    {
        CSI_154,
        CSI_156,
        CSI_147
    }

    enum WaterTemperatures
    {
        Freezing = 0,
        Boiling = 100
    }

    public partial class colorApplicationBox : Form
    {
        public colorApplicationBox()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // declare a variable to hold spectrum values
            Spectrum spColor = Spectrum.Blue;
            // colorAppTextBox.AppendText(spColor.ToString());
            // colorAppTextBox.AppendText(string.Format("{0}\n", spColor));

            RGB grColors = RGB.Blue;

            switch (grColors)
            {
                case RGB.Blue:
                    colorAppTextBox.AppendText(string.Format("{0}\n", grColors));
                    BackColor = Color.Blue;
                    break;

                case RGB.Red:
                    colorAppTextBox.AppendText(string.Format("{0}\n", grColors));
                    break;

                case RGB.Green:
                    colorAppTextBox.AppendText(string.Format("{0}\n", grColors));
                    break;

                default:
                    colorAppTextBox.AppendText("Error: No such color\n");
                    break;
            }

            int[] temperatures = { 20, 34, 56, 45, 60, 55, 61 };

            colorAppTextBox.AppendText(temperatures[(int)DaysOfTheWeek.Tuesday].ToString() + "\n");
            // use Enum class methods to access the details of an enumeration type
            // First, access all the values
            foreach (int value in Enum.GetValues(typeof(WaterTemperatures)))
            {
                colorAppTextBox.AppendText(value.ToString() + " ");
            }

            // Second, access the names
            foreach (int value in Enum.GetNames(typeof(WaterTemperatures)))
            {
                colorAppTextBox.AppendText(value + " ");
            }
        }
    }
}
