using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePictureBox
{
    public partial class Form1 : Form
    {
        string[] pictures = {"Desert.jpg","Hydrangeas.jpg",
                             "Jellyfish.jpg","Lighthouse.jpg",
                            "Penguins.jpg","Tulips.jpg",
                            "Chrysanthemum.jpg"};
        int pictureIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //code here runs every time the application starts
            //but before the form is displayed.

            //put an image (picture) in pictureBox2 control
            //set the image property of the picturebox from a
            //gif file "Brazil.gif" located in the folders 
            //Images/Flags.
            //The Images folder must be located in the current 
            //director, that is where the .exe (application) resides
            //(under visual studio the current directory is the 
            //debug folder.
            //So in your debug folder, you need to have an Images
            //folder and inside the Images folder you need to have
            //the Flags folder, which contains all the flag gif files
            pictureBox2.Image = Image.FromFile(@"Images\Flags\Brazil.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnGetNextImage_Click(object sender, EventArgs e)
        {
            string pictureName = pictures[pictureIndex];
            pictureBox3.Image = Image.FromFile(@"Images\Sample Pictures\"+ pictureName);
            //pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            //go to the next picture
            pictureIndex++;
            if (pictureIndex >= pictures.Length)
                pictureIndex = 0;

        }
    }
}
///Add a picturebox and a button and rotate thru the flag
///images
///
///Add 2 pictureboxes and a button. the button is to generate
///2 random numbers 1 thru 6. Display the corresponding
///  die images.
