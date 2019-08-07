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

namespace MatthewPowers_Population
{
    public partial class frmPopulation : Form
    {
        public frmPopulation()
        {
            InitializeComponent();
        }

        private void populationCalculator()
        {
            string[] Days = new string[int.Parse(txtbxMultiply.Text)];
            double aproxPopulation = double.Parse(txtbxOrganisms.Text);
            lstbxDisplay.Items.Add("Day     Aproximate Population");
            int numDays = 1;
            for (int i = 0; i < Days.Length; i++)
            {
                Days[i] = aproxPopulation.ToString();
                lstbxDisplay.Items.Add(numDays + "          " + Days[i]);
                aproxPopulation = aproxPopulation * (1 + (double.Parse(txtbxIncrease.Text) / 100.0));
                numDays++;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            populationCalculator();
        }
    }
}
