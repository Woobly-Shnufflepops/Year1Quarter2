using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace CardsApp
{
    public partial class CardApp : Form
    {
        // Declares a reference to an array that will hold the card file names
        private string[] cardFileNames;
        private int index = 0;
        
        public CardApp()
        {
            InitializeComponent();
        }

        // Loads the card file names into an array
        private void CardApp_Load(object sender, EventArgs e)
        {
            // Temporary array to hold the files read from the folder that conatins your card picture files
            // Folder name
            string folder = "Flags"; // local folder
            string filter = "*.gif"; // picks jpg files only
            string[] pictureFiles = Directory.GetFiles(folder, filter);

            // create memory for the cardFileNames array
            //int size = pictureFiles.Length;

            cardFileNames = new string[pictureFiles.Length];
            // Fill our array with extracted card file names
            // Set each element of the array 

            for (int i = 0; i < pictureFiles.Length; i++)
            { // Copy elements one by one
                cardFileNames[i] = Path.GetFileName(pictureFiles[i]);
            }
        }

        // Switch the picture to another card
        private void switchButton_Click(object sender, EventArgs e)
        {// Change the picture on the picture box
            cardPictureBox.Image = Image.FromFile(@"Poker\" + cardFileNames[index]);

            // update the index to next card
            // the module forces to reset to 0 when it reaches the end of the array
            index = (index + 1) % cardFileNames.Length;
        }

        // Closes the appliaction
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
