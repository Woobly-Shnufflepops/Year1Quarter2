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
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // declare a 4x4 2D array of int values
            int[,] matrix = new int[4, 4];
            // initialize element 1,2 (row 1 and column 2)
            matrix[1, 2] = 99;
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
            for (int i = 0; i < 4; i++)
            {
                // inner loops: controls the column processing
                // fixes the column number within a row
                // iterates over the elements of a row (columns)
                // This loop works for the outer loop/ it gets
                // executed many times
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rd.Next(20, 41);
                }
            }

            // Add all the values in the matrix
        }
    }
}
