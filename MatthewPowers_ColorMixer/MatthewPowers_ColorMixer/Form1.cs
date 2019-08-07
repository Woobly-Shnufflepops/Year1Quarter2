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

namespace MatthewPowers_ColorMixer
{
    public partial class frmColorMixer : Form
    {
        public frmColorMixer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            if (rdbtnFRed.Checked == true && rdbtnSRed.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Red;
            }

            else if (rdbtnFRed.Checked == true && rdbtnSYellow.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Orange;
            }

            else if (rdbtnFRed.Checked == true && rdbtnSBlue.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Purple;
            }

            else if (rdbtnFYellow.Checked == true && rdbtnSRed.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Orange;
            }

            else if (rdbtnFYellow.Checked == true && rdbtnSYellow.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Yellow;
            }

            else if (rdbtnFYellow.Checked == true && rdbtnSBlue.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Green;
            }

            else if (rdbtnFBlue.Checked == true && rdbtnSRed.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Purple;
            }

            else if (rdbtnFBlue.Checked == true && rdbtnSYellow.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Green;
            }

            else if (rdbtnFBlue.Checked == true && rdbtnSBlue.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Red;
            }

            else if (rdbtnFRed.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Red;
            }

            else if (rdbtnFYellow.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Yellow;
            }

            else if (rdbtnFBlue.Checked == true)
            {
                frmColorMixer.ActiveForm.BackColor = Color.Blue;
            }
        }
    }
}
