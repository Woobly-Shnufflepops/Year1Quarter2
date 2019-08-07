/* Author: Matthew Powers
 * Date: 5/25/19
 * Description: Creates an array of clothing items and displays it to a rich text box
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI_156_Exercise_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button creates an array of 3 retail items: Jacker, Jeans, and Shirt then appends the details to a list box and formatted
        private void button1_Click(object sender, EventArgs e)
        {
            // Array of retailitems
            RetailItem[] clothing = 
            {
            new RetailItem("Jacker", 12, 59.95m),
            new RetailItem("Jeans", 40, 34.95m),
            new RetailItem("Shirt", 20, 24.95m)
            };

            // Loop that prints them to the rich text box
            foreach(RetailItem cloth in clothing)
            {
                richTextBox1.AppendText(cloth.ToString() + "\n");
            }
        }
    }
}
