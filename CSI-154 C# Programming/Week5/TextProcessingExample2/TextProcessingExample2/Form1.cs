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
            // read the input text and trim it (remove
            // white space arround it).
            string input = textBox1.Text.Trim();

            //string str = input.Substring(3, 11);

            //MessageBox.Show("New text: " + str);
            // Example 1
            // Split the message into many words separated by white space
            //string[] words = input.Split(null);

            // split an email address into userid, domain, extention
            // define an array of separators: character that separate
            // the words that you wish extract/split
            //char[] separators = { '@', '.' };

            // call the Split  method on the input text and pass
            // the separators to it.

            //string[] words = input.Split(separators);

            // example 3: Read multiple values and sum them up.
            // USe the split to get the individual text representing
            // the values and then parse each to integer
            string[] words = input.Split(null);

            int sum = 0;
            foreach (string word in words)
            {
                // parse each word and convert it to integer
                int x = int.Parse(word);
                richTextBox1.AppendText(x.ToString() + "\n");
                sum += x;
            }
            richTextBox1.AppendText("Sum = " + sum.ToString());


        }
    }
}
