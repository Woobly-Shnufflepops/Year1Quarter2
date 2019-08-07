/* Author: Matthew Powers
 * Date: 4/21/17
 * Class: CSI 154
 * Assignment: Excercise 2
 * Description: Takes height and radius of a cylinder from a user, then prints off the perimeter, area, and radius in an unknown unit type
 */

using System;
using System.Windows.Forms;

namespace CylinderCalclulator
{
    public partial class frmCylCalc : Form
    {
        public frmCylCalc()
        {
            InitializeComponent();
        } // end of initialization

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // clears the text field of any text
            rchtxtbxOutput.Clear();
            
            // Creates two variables obtained by the user input
            double radius = Convert.ToDouble(txtbxRadius.Text);
            double height = Convert.ToDouble(txtbxHeight.Text);

            // Calculates the perimeter, area, and volume of the cylinder
            double permieter = (2 * (2 * Math.PI * radius + height));
            double area = (2 * Math.PI * radius * (radius + height));
            double volume = (Math.PI * Math.Pow(radius, 2) * height);

            // Prints the results of the above calculations, formated to 2 decimal points
            rchtxtbxOutput.AppendText(string.Format("The perimeter is {0:f2} \n" + "The area is {1:f2} \n" + "The volume is {2:f2}", permieter, area, volume));
        } // end of btnCalculate_Click
    } // end of class
}// end of namespace
