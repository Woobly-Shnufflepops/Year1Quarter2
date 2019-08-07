using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDArrays
{
    public partial class Form1 : Form
    {
        // create another 2D array and initalize it with values

        private int[,] table = 
            {
                {1, 2, 3, 4, 5 }, // row 1
                {6, 7, 8, 9 ,10 }, // row 2
                {11, 12, 13, 14, 15}, // row 3
                {16, 17, 18, 19, 20 }  // row 4
            };
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Extract the row number and the column number
            int rowNumber = int.Parse(rowTextBox.Text);
            int columnNumber = int.Parse(columnTextBox.Text);

            // Delcaring a 4x4 2D array of int values
            int[,] matrix = new int[rowNumber, columnNumber];
            // initialize element 1,2 (row 1, column 2)
            // matrix[1, 2] = 99;
            // to traverse a 2D array you need to access all the elements. There is a specific order:
            // Process each row, and then repeat that until all the rows are accessed, and each row needs to repeat the steps of processing each element.
            // Outer loop controls the row processing,  while the inner loop processes the columns

            // Processes the rows
            Random rd = new Random();
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // processes the columns
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rd.Next(0, 11);
                }// end of for
            }// end of for

            // Add all the values in the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }// end of for
            } // end of for

            // output the sum to the label
            //outputLabel.Text = sum.ToString("n0");
            outputLabel.Text = string.Format("Sum = {0:n0}", sumArray(matrix));


        } // end of runButton_Click

        // method to add all the elements in a multi-dimentional array
        private int sumArray(int[,] m)
        {
            int sum = 0;
            // using a foreach to go over all the elements to avoid the nested loops
            foreach(int element in m)
            {
                sum += element;
            }

            return sum;

        } // end of sumArray
    } // end of form
} // end of namespace
