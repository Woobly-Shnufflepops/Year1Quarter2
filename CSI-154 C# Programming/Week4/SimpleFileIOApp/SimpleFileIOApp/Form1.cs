using System;
using System.IO; // for File IO
using System.Windows.Forms;

namespace SimpleFileIOApp
{
    public partial class Form1 : Form
    {
        // declare a reference to an IO output object
        private StreamWriter outFile;
        public Form1()
        {
            InitializeComponent();

            
        }


        // 2. Process the file
        private void button1_Click(object sender, EventArgs e)
        {
            // Every time the user click on the button
            // the text typed in the text box is saved
            // to the output file.
            WriteMethod();

        }

        public void WriteMethod()
        {
             StreamWriter outFile = null;

            try // try block
            {
                outFile = File.AppendText(@"output.txt");
                string input = textBox1.Text;
                outFile.WriteLine(input);
                // Clear the entry text
                textBox1.Clear();
                textBox1.Focus();
                // The file is closed when the App is closed
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                outFile.Close();
            }
        }

        // Reads from a file and dumps the data to
        // the rich text box
        private void ReadMethod()
        {
            StreamReader inFile = null;
            string fileName = null;
            // value returned by the open file dialog 
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }
            else
            {
                return;
            }

            try
            {
                // open a file for reading
                inFile = File.OpenText(fileName);
                // read one line from the file
                string line = inFile.ReadLine();
                MessageBox.Show(line);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadMethod();
        }
    }
}
