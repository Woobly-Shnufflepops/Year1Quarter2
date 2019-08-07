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
            string school = textBox1.Text;
            school = school.Trim();

            //for (int i = 0; i < school.Length; i++)
            //{
            //    richTextBox1.AppendText(school[i] + "  ");

            //    if (char.IsUpper(school, i))
            //    {
            //        MessageBox.Show(school[i] + " is uppercase");
            //    }
            //}
            // check if the input has the word "ice' in it
            // convert every char to lower case: so the search
            // is not case sensitive
            string str = school.ToLower();
            int index = str.IndexOf("ice");
            if (index >= 0)
            {
                MessageBox.Show("TRUE");
                richTextBox1.AppendText("The position is " + index);
            }

        }
    }
}
