using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessingExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reads the input and trims the white space(s)
            string input = textBox1.Text.Trim();

            // string str = input.Substring(3, 11);

            // MessageBox.Show("New text: " + str);

            // Example 1: Split the message into many words seperated with white space
            // string[] words = input.Split(null);

            // split an e-mail address into a userID, domain, and extention
            // Define an array of seperators: Characters that seperate the words from each other
            // char[] seperators = { '@', '.', ' ', ','};

            // Call the Split method on the input text and pass the seperators to it.

            // string[] words = input.Split(seperators);

            // Example 3: Read multiple values and sum them up. Using split to obtain the individual values, and then convert them to int
            char[] seps = {' '};
            string[] words = input.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            foreach(string word in words)
            {
                // parse each word and convert to an interger
                int x = int.Parse(word);
                richTextBox1.AppendText(x.ToString() + "\n");
                sum += x;
            }
            richTextBox1.AppendText("Sum = " + sum.ToString());
        }
    }
}
