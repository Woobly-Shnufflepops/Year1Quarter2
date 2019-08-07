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

namespace MatthewPowers_Automotive
{
    public partial class frmAutomotive : Form
    {
        public frmAutomotive()
        {
            InitializeComponent();
        }

        private void ClearOilLube()
        {
            if (chkbxOilLubeLube.Checked == true)
            {
                chkbxOilLubeLube.Checked = false;
            }

            if (chkbxOilLubeOil.Checked == true)
            {
                chkbxOilLubeOil.Checked = false;
            }
        }

        private void ClearFlushes()
        {
            if (chkbxFlushesTransmission.Checked == true)
            {
                chkbxFlushesTransmission.Checked = false;
            }

            if (chkbxFlushesRadiator.Checked == true)
            {
                chkbxFlushesRadiator.Checked = false;
            }
        }

        private void ClearMisc()
        {
            if (chkbxMiscInspection.Checked == true)
            {
                chkbxMiscInspection.Checked = false;
            }

            if (chkbxMiscMuffler.Checked == true)
            {
                chkbxMiscMuffler.Checked = false;
            }

            if (chkbxMiscTire.Checked == true)
            {
                chkbxMiscTire.Checked = false;
            }
        }

        private void ClearOther()
        {
            txtbxPartsLaborLabor.Clear();
            txtbxPartsLaborParts.Clear();
        }

        private void ClearFees()
        {
            txtbxSumParts.Clear();
            txtbxSumServiceLabor.Clear();
            txtbxSumTax.Clear();
            txtbxSumTotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFees();
            ClearFlushes();
            ClearMisc();
            ClearOilLube();
            ClearOther();
        }

        private decimal OilLubeCharges()
        {
            decimal total = 0.0m;
            if (chkbxOilLubeOil.Checked == true)
            {
                total += 26;
            }

            if (chkbxOilLubeLube.Checked == true)
            {
                total += 18;
            }
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0.0m;
            if (chkbxFlushesTransmission.Checked == true)
            {
                total += 80;
            }

            if (chkbxFlushesRadiator.Checked == true)
            {
                total += 30;
            }
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0.0m;
            if (chkbxMiscMuffler.Checked == true)
            {
                total += 100;
            }

            if (chkbxMiscTire.Checked == true)
            {
                total += 20;
            }

            if (chkbxMiscInspection.Checked == true)
            {
                total += 15;
            }
            return total;
        }

        private decimal OtherCharges()
        {
            decimal total = 0.0m;
            total += decimal.Parse(txtbxPartsLaborLabor.Text);
            total += decimal.Parse(txtbxPartsLaborParts.Text);
            return total;
        }

        private decimal TaxCharges()
        {
            decimal total = 0.0m;
            total += decimal.Parse(txtbxPartsLaborParts.Text) * 0.06m;
            return total;
        }

        private decimal TotalCharges()
        {
            decimal total = 0.0m;
            total += (OilLubeCharges() + FlushCharges() + MiscCharges() + decimal.Parse(txtbxPartsLaborLabor.Text) + decimal.Parse(txtbxPartsLaborParts.Text) + TaxCharges());
            return total;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtbxSumTotal.Text = "$" + TotalCharges().ToString();
            txtbxSumParts.Text = "$" + txtbxPartsLaborParts.Text.ToString();
            txtbxSumServiceLabor.Text = "$" + (OilLubeCharges() + FlushCharges() + MiscCharges() + decimal.Parse(txtbxPartsLaborLabor.Text)).ToString();
            txtbxSumTax.Text = "$" + TaxCharges().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
