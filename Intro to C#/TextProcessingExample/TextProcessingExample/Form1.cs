using System;
using System.Text;
using System.Windows.Forms;

namespace TextProcessingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string school = textBox1.Text.Trim();
            // alternative to trimming
            // school = school.Trim();
            string str = school.ToLower();
            int index = str.IndexOf("ice");
            if (index >= 0)
            {
                MessageBox.Show("True");
                richTextBox1.AppendText("The position is " + index);
            }
            //for (int i = 0; i < school.Length; i++)
            //{
                // richTextBox1.AppendText(school[i] + " ");

                //if (char.IsLetter(school[i]))
                //{
                //    MessageBox.Show("A Letter");
                //}
                //else if (char.IsPunctuation(school[i]))
                //{
                //    MessageBox.Show("A punctuation");
                //}

                // Check to see if the input has the word "ice" in it
                // Convert every character to lower case: so the search is not case sensitive
                
            //}
        }
    }
}
