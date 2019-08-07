/* Author: Matthew Powers
 * Date: 4/14/17
 * Class: CSI_154
 * Description: Displays a random dice image each time the button is pressed
 */

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace LabAssignment01_02 
{
    public partial class diceRollApp : Form 
        
    {
        public diceRollApp() 

        {
            InitializeComponent();
        } // end of Initialization

        // Initalizes the string array
        private string[] dieFileNames;
        // Initalizes the random object
        Random rd = new Random();

        // Loads the images when the application loads
        private void diceRollApp_Load(object sender, EventArgs e) 
        {
            string folder = "Die";
            string filter = "*.gif";
            string[] dieFiles = Directory.GetFiles(folder, filter);

            dieFileNames = new string[dieFiles.Length];

            for (int i = 0; i < dieFiles.Length; i++) 
            {
                dieFileNames[i] = Path.GetFileName(dieFiles[i]);
            } // end of for
        } // end of diceRollApp_Load

        // Displays the random die image when the button is clicked
        private void dieRollButton_Click(object sender, EventArgs e) 
        {
            diePictureBox.Image = Image.FromFile(@"Die\" + dieFileNames[rd.Next(0,6)]);
        } // end of dieRollButton_Click
    } // end of class
} // end of namespace
