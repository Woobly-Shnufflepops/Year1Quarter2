using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDArrays1
{
    public partial class Form1 : Form
    {
        // create another 2D array and initiualize it with values

        private int[,] table =
        {
            {1, 2, 3, 4, 5}, // row 1
            {6, 7, 8, 9, 10}, // row 2
            {11, 12, 13, 14, 15}, // row 3
            {16, 17, 18, 19, 20} // row 4

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Extract the row number and the column
            // number
            int rowNo = int.Parse(rowTextBox.Text);
            int colNo = int.Parse(columnTextBox.Text);
            // declare a 4x4 2D array of int values
            int[,] matrix = new int[rowNo, colNo];
            // initialize element 1,2 (row 1 and column 2)
            //matrix[1, 2] = 99;
            // to traverse a 2D array you need of course
            // to inspect all the elements.
            // There is a sepcific order:
            // you process each row and repeat that until
            // all the rows are done
            // And each row needs to repeat the steps of
            // processing each elements (column)
            // outer loop controls the row processing/ fixes
            // the row number/ iterates over the rows
            Random rd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // inner loops: controls the column processing
                // fixes the column number within a row
                // iterates over the elements of a row (columns)
                // This loop works for the outer loop/ it gets
                // executed many times
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rd.Next(20, 41);
                }
            }

            // Add all the values in the matrix
            int sum = 0;
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    sum += matrix[i, j];
                } // end of for
            } // end of for

            // output the sum to the label
            //outputLabel.Text = sum.ToString("n0");
            outputLabel.Text =
                string.Format("Sum = {0:n0}", SumArray(matrix));
        } // end of runButton_Click

        // method to add all the elements in a multi-D array

        private int SumArray(int[,] m)
        {
            int sum = 0;
            // use a foreach to go over all the element
            // avoid the nested loop
            foreach (int element in m)
            {
                sum += element;
            }

            return sum;

        }
    } // end of form
} // end of namespace
