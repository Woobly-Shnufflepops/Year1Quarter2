using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorShowApp
{
    // Examples of enumeration types
    // enumeration of colors

    enum Spectrum
    {
        Red = 10, // was 0
        Green,  // 11 was 1
        Blue, // 12 was 2
        Violet,
        Yellow,
        Orange
    }

    enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum RGB
    {
        Red, 
        Blue,
        Green
    }

    // Enumeration of courses
    enum Courses
    {
        CSI154,
        CSI156,
        CSI147
    }

    enum WaterTemperatures
    {
        Freezing = 0,
        Boiling = 100
    }


    

    public partial class EnumerationForm : Form
    {
        public EnumerationForm()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // decalre a variable to hold
            // spectrum values
            Spectrum spColors = Spectrum.Blue;
            richTextBox1.AppendText(spColors.ToString());
            richTextBox1.AppendText(
                string.Format("{0}\n", spColors));

            RGB grColors = RGB.Blue;

            switch (grColors)
            {
                case RGB.Blue:
                    //richTextBox1.AppendText("Blue color!\n");
                    richTextBox1.BackColor = Color.Blue;
                    break;
                case RGB.Red:
                    richTextBox1.AppendText("Red color!\n");
                    break;

                case RGB.Green:
                    richTextBox1.AppendText("Gree color!\n");
                    break;
                default:
                    // error
                    richTextBox1.AppendText("Error: no such color!\n");
                    break;
            }

            int[] temperatures = { 20, 34, 56, 45, 60, 55, 61 };

            richTextBox1.AppendText(
                temperatures[(int)DaysOfTheWeek.Tuesday].ToString()
                + "\n");
            // use Enum class methods to access the details of an
            // enumeration type
            // 1 access all the values
            foreach (int value in Enum.GetValues(typeof(WaterTemperatures)))
            {
                richTextBox1.AppendText(value.ToString() + " ");
            }

            // 2 access the names
            foreach (string value in Enum.GetNames(typeof(WaterTemperatures)))
            {
                richTextBox1.AppendText(value + " ");
            }

        }
    }
}
