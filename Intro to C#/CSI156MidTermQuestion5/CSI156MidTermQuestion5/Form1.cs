// Author: Matthew Powers
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

namespace CSI156MidTermQuestion5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addName()
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void buttonEnterName_Click(object sender, EventArgs e)
        {
            addName();
        }

        private void saveListNames()
        {
            StreamWriter outNames = null;
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.FileName = "Saved Names";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    outNames = new StreamWriter(saveFileDialog1.OpenFile());
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        outNames.WriteLine(listBox1.Items[i].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    outNames.Close();
                }
            }
        }

        private void buttonSaveNames_Click(object sender, EventArgs e)
        {
            saveListNames();
        }
    }
}
