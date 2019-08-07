/* Author: Matthew Powers
 * Class: CSI_154
 * Assignment: Lab Assignment 3
 * Date: 4/26/17
 * Description: Draws 4 different boxes by calling methods via button clicks
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

namespace starBox
{
    public partial class frmStarBox : Form
    {
        public frmStarBox()
        {
            InitializeComponent();
        } // end of initalizeation

        // method that draws a star at every row and column
        private void allStar()
        {
            // passing the text info into values
            int rows = Int32.Parse(txtbxRows.Text);
            int columns = Int32.Parse(txtbxColumns.Text);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rchtxtbxOutput.AppendText("*");
                }// end of for
                rchtxtbxOutput.AppendText("\n");
            }// end of for
        }// end of allStar

        // Method that draws a star every other column
        private void oddColumns()
        {
            // passing the text info into values
            int rows = Int32.Parse(txtbxRows.Text);
            int columns = Int32.Parse(txtbxColumns.Text);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j % 2 == 1) rchtxtbxOutput.AppendText("*");
                    else rchtxtbxOutput.AppendText(" ");
                } // end of for
                rchtxtbxOutput.AppendText("\n");
            }// end of for
        }// end of oddColumns

        // method that prints stars on the even rows
        private void evenRows()
        {
            // passing the text info into values
            int rows = Int32.Parse(txtbxRows.Text);
            int columns = Int32.Parse(txtbxColumns.Text);

            for (int i = 0; i < rows; i++)
            {

                if (i % 2 == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        rchtxtbxOutput.AppendText("*");
                    }// end of for
                }// end of if
                else rchtxtbxOutput.AppendText(" ");
                rchtxtbxOutput.AppendText("\n");
            } // end of for
        } // end of evenRows

        // Method that draws stars, except for the middle 3 spots
        private void hollowSquare()
        {
            // passing the text info into values
            int rows = Int32.Parse(txtbxRows.Text);
            int columns = Int32.Parse(txtbxColumns.Text);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((i == rows / 2 || i == rows / 2 - 1 || i == rows / 2 + 1) && (j == columns / 2 || j == columns / 2 - 1 || j == columns / 2 + 1))
                    {
                        rchtxtbxOutput.AppendText(" ");
                        continue;
                    } // end of if
                        rchtxtbxOutput.AppendText("*");
                } // end of for
                rchtxtbxOutput.AppendText("\n");
            } // end of for
        } // end of hollowSquare

        private void btnAllStar_Click(object sender, EventArgs e)
        {
            rchtxtbxOutput.Clear();
            allStar();
        } // end of btnAllStar_Click

        private void btnOddColumns_Click(object sender, EventArgs e)
        {
            rchtxtbxOutput.Clear();
            oddColumns();
        } // end of btnOddColumns_Click

        private void btnEvenRow_Click(object sender, EventArgs e)
        {
            rchtxtbxOutput.Clear();
            evenRows();
        } // end of btnEvenRow_Click

        private void btnHollow_Click(object sender, EventArgs e)
        {
            rchtxtbxOutput.Clear();
            hollowSquare();
        }// end of btnHollow_Click
    }// end of class
}// end of namespace
