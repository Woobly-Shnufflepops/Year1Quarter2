using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace CardsApp
{
    public partial class CardApp : Form
    {
        // Declare a reference to an array that will
        // hold the card file names
        private string[] cardFileNames;
        private int index = 0;

        public CardApp()
        {
            InitializeComponent();
        }

        // load the card file names into an array
        private void CardApp_Load(object sender, EventArgs e)
        {
            // temporary array to hold the files read from
            // the folder that contains your card picture files
            // folder name
            string folder = "Poker"; // local folder
            string filter = "*.jpg"; // pick jpg files only
            string[] pictureFiles = Directory.GetFiles(folder, filter);
            // create memory for the cardFileNames array
            int size = pictureFiles.Length;
            cardFileNames = new string[size];
            // fill our array with extracted card file names
            // set each element of the array to the specific file name
            for (int i = 0; i < size ; i++)
            { // copy elements one by one
                cardFileNames[i] = Path.GetFileName(pictureFiles[i]);
            }

        }

        // change the picture to another card
        private void switchButton_Click(object sender, EventArgs e)
        {
            // chnage the picture on the picture box
            cardPictureBox.Image = Image.FromFile(@"Poker\" + cardFileNames[index]);
            // update the index to next card
            // the modulo forces to reset to 0 when it reaches the end
            // of the array
            index = (index + 1) % cardFileNames.Length;

        }

        // close the app
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
