// Author: Matthew Powers
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI156MidTermQuestion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void twoD()
        {
            Random rd = new Random();
            int[,] array = new int[5, 5];
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rd.Next(1, 10);
                    richTextBox1.AppendText(array[i, j].ToString());
                    if(i == j)
                    {
                        sum += array[i, j];
                    }
                }
                richTextBox1.AppendText("\n");
            }
            richTextBox1.AppendText("\n" + sum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            twoD();
        }
    }
}
