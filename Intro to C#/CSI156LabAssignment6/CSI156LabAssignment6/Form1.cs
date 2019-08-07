/* Author: Matthew Powers
 * Date: 5/26/17
 * Class: CSI_154
 * Assignment: Lab Assignment 5
 * Description: Uses a button to fill in the information about the professor's ratings
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

namespace CSI156LabAssignment6
{
    public partial class frmProRat : Form
    {
        public frmProRat()
        {
            InitializeComponent();
        }

        // Creates numbers for totals
        int numClarity = 0;
        int numEasiness = 0;
        int numHelpfullness = 0;
        int numAverage = 0;
        private void btnPrintRatings_Click(object sender, EventArgs e)
        {
            ProfessorRating fullRating = new ProfessorRating(Convert.ToInt32(txtbxProID.Text), Convert.ToInt32(numUDHelp.Value), Convert.ToInt32(numUDClar.Value), Convert.ToInt32(numUDEase.Value));
            // Clears all the text boxes
            txtbxAvg.Clear();
            txtbxClar.Clear();
            txtbxEase.Clear();
            txtbxHelp.Clear();

            // Takes the numbers and appends them to the text boxes
            numClarity += fullRating.Clarity;
            txtbxClar.AppendText(numClarity.ToString());

            numEasiness += fullRating.Easiness;
            txtbxEase.AppendText(numEasiness.ToString());

            numHelpfullness += fullRating.Helpfullness;
            txtbxHelp.AppendText(numHelpfullness.ToString());

            numAverage += ((numClarity + numEasiness + numHelpfullness) / 3);
            txtbxAvg.AppendText(numAverage.ToString());
        }

        // closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
