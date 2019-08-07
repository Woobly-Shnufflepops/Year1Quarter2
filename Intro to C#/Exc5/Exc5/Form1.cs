using System;
/* Author: Matthew Powers
 * Class: CSI_156
 * Assignment: Exercise 5
 * Date: 5/18/17
 * Descritpion: Creates a person class, then displays it to a rich text box
 */

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exc5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } // End of initizleComponent

        // Button that creates the new person and displays it to the rich text box
        private void btnDisplayToRich_Click(object sender, EventArgs e)
        {
            Person TestPerson = new Person(txtbxName.Text, Convert.ToInt32(txtbxAge.Text), Convert.ToDouble(txtbxHeight.Text));
            rchtxtbxDisplay.AppendText(TestPerson.ToString());
        } // End of btnDisplayToRich_Click
    } // End of class
} // End of namespace
