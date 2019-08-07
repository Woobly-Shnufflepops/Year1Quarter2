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

namespace CSI156MidTermQuestion4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        string[] carNames = new string[] { "Hyundai Elantra", "Jeep Grand Cherokee", "Nissan Sentra", "GMC Sierra", "Chevrolet Malibu", "Chevrolet Equinox", "Ford Explorer", "Ford Fusion", "Ford Escape", "Nissan Altima"};

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(carNames);
        }

        private void moveItem()
        {
            string tempItem;
            tempItem = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(tempItem);
            listBox1.Items.Add(tempItem);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            moveItem();
        }
    }
}
