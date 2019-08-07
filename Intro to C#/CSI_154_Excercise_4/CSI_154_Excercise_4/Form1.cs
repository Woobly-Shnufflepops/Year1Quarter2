/* Author: Matthew Powers
 * Class CSI 154
 * Assignment: Excercise 4
 * Date: 5/4/17
 * Description: Populates a list with a random set of 50 numbers, then displays said numbers one by one anywhere between .5 and 1 second, determined by the user
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSI_154_Excercise_4
{
    public partial class frmFiftyValues : Form
    {
        public frmFiftyValues()
        {
            InitializeComponent();
        } // end of frmFiftyValues

        // creates an array and a random
        int[] numbers = new int[50];
        Random rd = new Random();

        // Button that starts the timer
        private void btnDisplayValues_Click(object sender, EventArgs e)
        {
            tmrDisplayValues.Start();
        } // end of btnDisplayVlues_Click

        // Button that stops the timer
        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrDisplayValues.Stop();
        } // end of btnStop_Click


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tmrDisplayValues.Interval = (int)numericUpDown1.Value;
        }

        // initalizes subNums
        int subNums = 0;
        // Method that increases subnums by 1, then displays the value at the numbers indecy (using subnums) in the list box. 
        // If subnums is equivelent to 50, it clears the list and resets the value of subnums to 0
        private void displayValues()
        {
            subNums++;
            lstbxDisplayValues.Items.Add(numbers[subNums]);
            if (subNums % 49 == 0)
            {
                lstbxDisplayValues.Items.Clear();
                subNums = 0;
            }// end of if
        }// end of displayValues

        // Timer tick information that calls displayValues
        private void tmrDisplayValues_Tick(object sender, EventArgs e)
        {
            displayValues();
        }// end of tmrDisplayVlues_Tick

        // On load, the array gets populated with 50 random numbers between 0 and 100
        private void frmFiftyValues_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 50; i++)
            {
                numbers[i] = (rd.Next(0, 101));
            }// end of for
        }// end of frmFiftyValues_Load
    }// end of class
}// end of namespace
