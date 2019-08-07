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

namespace FiendsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void write()
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("Friends.txt");

                outputFile.WriteLine(textBox1.Text);

                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            write();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
