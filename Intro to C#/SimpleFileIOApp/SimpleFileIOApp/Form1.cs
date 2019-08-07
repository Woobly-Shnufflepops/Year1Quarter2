using System;
using System.IO; // for file IO
using System.Windows.Forms;

namespace SimpleFileIOApp
{
    public partial class frmIO : Form
    {
        // declares a reference to an IO output object
        public frmIO()
        {
            InitializeComponent();
        }

        // 2: Process the file
        private void btnRunApplication_Click(object sender, EventArgs e)
        {
            WriteMethod();
        }
        

        public void WriteMethod()
        {
            StreamWriter outFile;

            try // try block
            {
                outFile = File.AppendText(@"F:\SimpleFileIOApp\SimpleFileIOApp\bin\Debug\output.txt");
                string input = txtInput01.Text;
                outFile.WriteLine(input);
                // Clears the entry in the text box
                txtInput01.Clear();
                txtInput01.Focus();
                outFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Reads from a file and dumps the data to a rich text box
        private void ReadMethod()
        {
            StreamReader inFile;
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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            ReadMethod();
        }
    }
}
