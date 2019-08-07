/* Author: Matthew Powers
 * Date: 4/14/17
 * Class: CSI_154
 * Assignment: Lab Assingment 1
 * Description: Displays a flag, then cycles to the next flag and repeats
 */

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace FlagApplication 
{
    public partial class flagWindow : Form 
    {
        public flagWindow() 
        {
            InitializeComponent();
        } // end of flagWindow

        // Initalizes the string array
        private string[] flagFileNames;
        // Initalizes the index and sets it to 0
        private int index = 0;

        // Loads the flag images when the application starts
        private void flagWindow_Load(object sender, EventArgs e) 
        {
            string folder = "Flags";
            string filter = "*gif";
            string[] pictureFiles = Directory.GetFiles(folder, filter);


            flagFileNames = new string[pictureFiles.Length];

            for (int i = 0; i < pictureFiles.Length; i++) 
            {
                flagFileNames[i] = Path.GetFileName(pictureFiles[i]);
            } // end of for
        } // end of flagWindow_Load

        // Switches the flag upon button press and cycles when it reaches the end
        private void switchFlag_Click(object sender, EventArgs e) 
        {
            flagDisplay.Image = Image.FromFile(@"Flags\" + flagFileNames[index]);

            index = (index + 1) % flagFileNames.Length;
        } // end of switchFlag_Click
    } // end of class
} // end of namespace
