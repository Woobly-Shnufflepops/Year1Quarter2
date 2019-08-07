using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringsExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text =
               "Exercises:" + "\n" +
"1.	Define methods to: " + "\n" +
"a.Take an input string and return the number of letters that are capitalized\n" +
"b.Take an input string and return the index of the first occurrence and the index of the last occurrence of\n" +
"  a substring or character(use a method with the out keyword)\n" +
"c.Use the Substring method to extract a substring from the input string.\n" +
"d.Use the substring to extract the first word in an input string\n" +
"e.Use the substring method to extract the last word in an input string\n" +
"f.Use methods defined in the String class to swap the first and last words in a substring";
        }

        private int NumberOfCaps(string text)
        {
            // set up a counter 
            int counter = 0;
            // inspect every character in the text
            // and count the uppercase letter by
            // incrementing the counter
            for (int i = 0; i < text.Length; i++)
            {
                // read the current character
                char ch = text[i];
                // Check if the current char is a cap
                // and increment counter if it's the case
                if (char.IsUpper(ch))
                {
                    counter++;
                }
            }


            return counter;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();

            int num = NumberOfCaps(str);
            richTextBox1.Clear();
            richTextBox1.AppendText(num.ToString());
        }
    }
}
