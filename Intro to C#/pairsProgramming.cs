/* Authors: Matthew Powers, Kyle Diablo
* Class: CSI_154
* Assignment: Pairs Programming
* Date: 4/14/17
* Description: Creates a 11x11 2D array, and populates it with random data. Using buttons, find information about the data in the array
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PairsPrograming
{
    public partial class pairProgramExe : Form
    {
        // Initializes code
        public pairProgramExe()
        {
            InitializeComponent();
        }// end of pairProgramExe

        // Creates the 11x11 2D array
        private int[,] matrix = new int[10, 10];
        // Creates the random data object
        Random rd = new Random();

        // Loads the matrix and adds the random data to the matrix
        private void pairProgramExe_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rd.Next(-50, 51);
                } // end of for
            }// end of for
        }// end of pairProgramExe_Load

        // Finds the total of all the positive numbers in the arrray
        private void positiveTotal_Click(object sender, EventArgs e)
        {
            int positiveSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        positiveSum += matrix[i, j];
                    }// end of if
                }// end of for
            }// end of for
            displayTextBox.Text = positiveSum.ToString();
        }// end of postitiveTotal_Click

        // Finds the total of all the average negative numbers in the arrray
        private void averageNegative_Click(object sender, EventArgs e)
        {
            int negativeAverage = 0;
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negativeAverage += matrix[i, j];
                        counter += 1;
                    }// end of if
                }// end of for
            }// end of for
            displayTextBox.Text = (negativeAverage / counter).ToString();
        } // end of averageNegative_Click

        // Finds the total of all the odd numbers in the arrray
        private void sumAllOdd_Click(object sender, EventArgs e)
        {
            int sumOdd = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        sumOdd += matrix[i, j];
                    }// end of if
                }// end of for
            }// end of for
            displayTextBox.Text = sumOdd.ToString();
        } // end of sumAllOdd_Click

        // Finds the total of all the even numbers in the arrray
        private void averageAllEven_Click(object sender, EventArgs e)
        {
            int averageEven = 0;
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        averageEven += matrix[i, j];
                        counter += 1;
                    }// end of if
                }// end of for
            }// end of for
            displayTextBox.Text = (averageEven / counter).ToString();
        } // end of averageAllEven_Click

        // Finds the total of all the positive odd numbers in the arrray
        private void averageAllPositiveOdd_Click(object sender, EventArgs e)
        {
            int sumOddPositive = 0;
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 1 && matrix[i, j] > 0)
                    {
                        sumOddPositive += matrix[i, j];
                        counter += 1;
                    }// end of if
                }// end of for
            }// end of for
            displayTextBox.Text = (sumOddPositive/counter).ToString();
        } // end o faverageAllPositiveOdd_Click

        // Finds all the negative elements in the arrray
        private void numNegativeElements_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        counter += 1;
                    }// end of if
                }// end of for
            }// end of for
            displayTextBox.Text = counter.ToString();
        }// end of numNegativeElements_Click
    }// end of class
}// end of namespace
