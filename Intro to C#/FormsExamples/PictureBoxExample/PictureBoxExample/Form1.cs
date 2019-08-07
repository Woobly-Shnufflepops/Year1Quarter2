using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxExample
{
    public partial class Form1 : Form
    {
        private string[] cards = {"2_Clubs.jpg", "3_Clubs.jpg", "4_Clubs.jpg" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool boxState = pictureBox1.Visible;
            //pictureBox1.Visible = !boxState;
            // load a different image into the picture box
            pictureBox1.Image = Image.FromFile(@"PokerLarge\" + cards[0]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meow");
        }
    }
}
