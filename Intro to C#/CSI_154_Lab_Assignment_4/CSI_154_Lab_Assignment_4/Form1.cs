/* Author: Matthew Powers
 * Class: CSI 154
 * Assignment: Lab Assignment 4
 * Date: 5/5/17
 * Description: It's supposed to allow the user to genearte a random set of numbers, save a file in a location, then open said file, but doesn't
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI_154_Lab_Assignment_4
{
    public partial class frmDialogs : Form
    {
        // Makes a list and a random
        List<int> userNumbers = new List<int>();
        Random rd = new Random();

        public frmDialogs()
        {
            InitializeComponent();
        } // end of frmDialogs

        // Button that calls userInput
        private void btnPopulateArray_Click(object sender, EventArgs e)
        {
            userInput();
        } // end of btnPopulateArray_Click

        // Method that opens the saved file
        private void openFiles()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            } // end of if
        } // end of openFiles
        
        // Method that saves the content in the list into a text file
        private void saveFiles()
        {
            StreamWriter outfile = null;
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.FileName = "Saved Files";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    outfile = new StreamWriter(saveFileDialog1.OpenFile());
                    for (int i = 0; i < userNumbers.Count; i++)
                    {
                        outfile.WriteLine(userNumbers[i].ToString());
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    outfile.Dispose();
                    outfile.Close();
                }

            }
            //try
            //{
            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        outfile = new StreamWriter(saveFileDialog1.OpenFile());
            //        for (int i = 0; i < userNumbers.Count; i++)
            //        {
            //            outfile.WriteLine(userNumbers[i].ToString());
            //        }
            //    } // end of if
            //} // end of if
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //} // end of try
        } // end of saveFiles

        // Method that generates random nubmers between 1 and 100, and assigns them to the list
        private void userInput()
        {
            for (int i = 0; i < Convert.ToInt32(txtbxNumbersInput.Text); i++)
            {
                userNumbers.Add(rd.Next(1, 101));
            } // end of for
        } // end of userInput

        // Button that calls saveFiles
        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            saveFiles();
        } // end of btnWriteToFile_Click

        // Button that calls openFiles
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFiles();
        } // end of btnOpenFile_Click
    } // end of Class
} // end of Namespace
