using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxExamples
{
    public partial class Form1 : Form
    {
        int[] values = { 2, 4, 5, 6, 7, 8, 9 };

        string[] names = { "wixMini", "cirFairy", "sirKappacino", "sirBane", "FrankerZ", "Kappa" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunApp_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string str = String.Empty;
            foreach(string item in listBox1.Items)
            {
                str += item + "\n";
            }
            richTextBox1.AppendText(str);

            richTextBox1.AppendText("Selected Item: \n");
            richTextBox1.AppendText(listBox1.SelectedItem.ToString());
            richTextBox1.AppendText("\n" + "Index = " + (listBox1.SelectedIndex + 1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //foreach(string element in names)
            //{
            //    listBox1.Items.Add(element);
            //}

            listBox1.Items.AddRange(names);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Item: " + listBox1.SelectedItem.ToString());
        }
    }
}
