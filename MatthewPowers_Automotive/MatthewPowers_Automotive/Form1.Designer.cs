namespace MatthewPowers_Automotive
{
    partial class frmAutomotive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbxOil = new System.Windows.Forms.GroupBox();
            this.chkbxOilLubeOil = new System.Windows.Forms.CheckBox();
            this.chkbxOilLubeLube = new System.Windows.Forms.CheckBox();
            this.grpbxFlushes = new System.Windows.Forms.GroupBox();
            this.chkbxFlushesTransmission = new System.Windows.Forms.CheckBox();
            this.chkbxFlushesRadiator = new System.Windows.Forms.CheckBox();
            this.grpbxMisc = new System.Windows.Forms.GroupBox();
            this.chkbxMiscMuffler = new System.Windows.Forms.CheckBox();
            this.chkbxMiscInspection = new System.Windows.Forms.CheckBox();
            this.chkbxMiscTire = new System.Windows.Forms.CheckBox();
            this.grpbxPartsLabor = new System.Windows.Forms.GroupBox();
            this.lblPartsLaborParts = new System.Windows.Forms.Label();
            this.txtbxPartsLaborParts = new System.Windows.Forms.TextBox();
            this.txtbxPartsLaborLabor = new System.Windows.Forms.TextBox();
            this.lblPartsLaborLabor = new System.Windows.Forms.Label();
            this.grpbxSummary = new System.Windows.Forms.GroupBox();
            this.lblSumServiceLabor = new System.Windows.Forms.Label();
            this.txtbxSumServiceLabor = new System.Windows.Forms.TextBox();
            this.txtbxSumParts = new System.Windows.Forms.TextBox();
            this.lblSumParts = new System.Windows.Forms.Label();
            this.txtbxSumTax = new System.Windows.Forms.TextBox();
            this.lblSumTax = new System.Windows.Forms.Label();
            this.txtbxSumTotal = new System.Windows.Forms.TextBox();
            this.lblSumTotalFees = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbxOil.SuspendLayout();
            this.grpbxFlushes.SuspendLayout();
            this.grpbxMisc.SuspendLayout();
            this.grpbxPartsLabor.SuspendLayout();
            this.grpbxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxOil
            // 
            this.grpbxOil.Controls.Add(this.chkbxOilLubeLube);
            this.grpbxOil.Controls.Add(this.chkbxOilLubeOil);
            this.grpbxOil.Location = new System.Drawing.Point(13, 13);
            this.grpbxOil.Name = "grpbxOil";
            this.grpbxOil.Size = new System.Drawing.Size(166, 68);
            this.grpbxOil.TabIndex = 0;
            this.grpbxOil.TabStop = false;
            this.grpbxOil.Text = "Oil and Lube";
            // 
            // chkbxOilLubeOil
            // 
            this.chkbxOilLubeOil.AutoSize = true;
            this.chkbxOilLubeOil.Location = new System.Drawing.Point(7, 20);
            this.chkbxOilLubeOil.Name = "chkbxOilLubeOil";
            this.chkbxOilLubeOil.Size = new System.Drawing.Size(120, 17);
            this.chkbxOilLubeOil.TabIndex = 0;
            this.chkbxOilLubeOil.Text = "Oil Change ($26.00)";
            this.chkbxOilLubeOil.UseVisualStyleBackColor = true;
            // 
            // chkbxOilLubeLube
            // 
            this.chkbxOilLubeLube.AutoSize = true;
            this.chkbxOilLubeLube.Location = new System.Drawing.Point(7, 43);
            this.chkbxOilLubeLube.Name = "chkbxOilLubeLube";
            this.chkbxOilLubeLube.Size = new System.Drawing.Size(109, 17);
            this.chkbxOilLubeLube.TabIndex = 1;
            this.chkbxOilLubeLube.Text = "Lube job ($18.00)";
            this.chkbxOilLubeLube.UseVisualStyleBackColor = true;
            // 
            // grpbxFlushes
            // 
            this.grpbxFlushes.Controls.Add(this.chkbxFlushesTransmission);
            this.grpbxFlushes.Controls.Add(this.chkbxFlushesRadiator);
            this.grpbxFlushes.Location = new System.Drawing.Point(185, 13);
            this.grpbxFlushes.Name = "grpbxFlushes";
            this.grpbxFlushes.Size = new System.Drawing.Size(166, 68);
            this.grpbxFlushes.TabIndex = 2;
            this.grpbxFlushes.TabStop = false;
            this.grpbxFlushes.Text = "Flushes";
            // 
            // chkbxFlushesTransmission
            // 
            this.chkbxFlushesTransmission.AutoSize = true;
            this.chkbxFlushesTransmission.Location = new System.Drawing.Point(7, 43);
            this.chkbxFlushesTransmission.Name = "chkbxFlushesTransmission";
            this.chkbxFlushesTransmission.Size = new System.Drawing.Size(157, 17);
            this.chkbxFlushesTransmission.TabIndex = 1;
            this.chkbxFlushesTransmission.Text = "Transmission Flush ($80.00)";
            this.chkbxFlushesTransmission.UseVisualStyleBackColor = true;
            // 
            // chkbxFlushesRadiator
            // 
            this.chkbxFlushesRadiator.AutoSize = true;
            this.chkbxFlushesRadiator.Location = new System.Drawing.Point(7, 20);
            this.chkbxFlushesRadiator.Name = "chkbxFlushesRadiator";
            this.chkbxFlushesRadiator.Size = new System.Drawing.Size(136, 17);
            this.chkbxFlushesRadiator.TabIndex = 0;
            this.chkbxFlushesRadiator.Text = "Radiator Flush ($30.00)";
            this.chkbxFlushesRadiator.UseVisualStyleBackColor = true;
            // 
            // grpbxMisc
            // 
            this.grpbxMisc.Controls.Add(this.chkbxMiscTire);
            this.grpbxMisc.Controls.Add(this.chkbxMiscMuffler);
            this.grpbxMisc.Controls.Add(this.chkbxMiscInspection);
            this.grpbxMisc.Location = new System.Drawing.Point(12, 87);
            this.grpbxMisc.Name = "grpbxMisc";
            this.grpbxMisc.Size = new System.Drawing.Size(166, 100);
            this.grpbxMisc.TabIndex = 3;
            this.grpbxMisc.TabStop = false;
            this.grpbxMisc.Text = "Misc";
            // 
            // chkbxMiscMuffler
            // 
            this.chkbxMiscMuffler.AutoSize = true;
            this.chkbxMiscMuffler.Location = new System.Drawing.Point(7, 43);
            this.chkbxMiscMuffler.Name = "chkbxMiscMuffler";
            this.chkbxMiscMuffler.Size = new System.Drawing.Size(155, 17);
            this.chkbxMiscMuffler.TabIndex = 1;
            this.chkbxMiscMuffler.Text = "Replaced Muffler ($100.00)";
            this.chkbxMiscMuffler.UseVisualStyleBackColor = true;
            // 
            // chkbxMiscInspection
            // 
            this.chkbxMiscInspection.AutoSize = true;
            this.chkbxMiscInspection.Location = new System.Drawing.Point(7, 20);
            this.chkbxMiscInspection.Name = "chkbxMiscInspection";
            this.chkbxMiscInspection.Size = new System.Drawing.Size(117, 17);
            this.chkbxMiscInspection.TabIndex = 0;
            this.chkbxMiscInspection.Text = "Inspection ($15.00)";
            this.chkbxMiscInspection.UseVisualStyleBackColor = true;
            // 
            // chkbxMiscTire
            // 
            this.chkbxMiscTire.AutoSize = true;
            this.chkbxMiscTire.Location = new System.Drawing.Point(7, 66);
            this.chkbxMiscTire.Name = "chkbxMiscTire";
            this.chkbxMiscTire.Size = new System.Drawing.Size(129, 17);
            this.chkbxMiscTire.TabIndex = 2;
            this.chkbxMiscTire.Text = "Tire Rotation ($20.00)";
            this.chkbxMiscTire.UseVisualStyleBackColor = true;
            // 
            // grpbxPartsLabor
            // 
            this.grpbxPartsLabor.Controls.Add(this.txtbxPartsLaborLabor);
            this.grpbxPartsLabor.Controls.Add(this.lblPartsLaborLabor);
            this.grpbxPartsLabor.Controls.Add(this.txtbxPartsLaborParts);
            this.grpbxPartsLabor.Controls.Add(this.lblPartsLaborParts);
            this.grpbxPartsLabor.Location = new System.Drawing.Point(185, 87);
            this.grpbxPartsLabor.Name = "grpbxPartsLabor";
            this.grpbxPartsLabor.Size = new System.Drawing.Size(166, 100);
            this.grpbxPartsLabor.TabIndex = 4;
            this.grpbxPartsLabor.TabStop = false;
            this.grpbxPartsLabor.Text = "Parts and Labor";
            // 
            // lblPartsLaborParts
            // 
            this.lblPartsLaborParts.AutoSize = true;
            this.lblPartsLaborParts.Location = new System.Drawing.Point(30, 36);
            this.lblPartsLaborParts.Name = "lblPartsLaborParts";
            this.lblPartsLaborParts.Size = new System.Drawing.Size(46, 13);
            this.lblPartsLaborParts.TabIndex = 0;
            this.lblPartsLaborParts.Text = "Parts ($)";
            // 
            // txtbxPartsLaborParts
            // 
            this.txtbxPartsLaborParts.Location = new System.Drawing.Point(79, 33);
            this.txtbxPartsLaborParts.Name = "txtbxPartsLaborParts";
            this.txtbxPartsLaborParts.Size = new System.Drawing.Size(52, 20);
            this.txtbxPartsLaborParts.TabIndex = 1;
            // 
            // txtbxPartsLaborLabor
            // 
            this.txtbxPartsLaborLabor.Location = new System.Drawing.Point(79, 59);
            this.txtbxPartsLaborLabor.Name = "txtbxPartsLaborLabor";
            this.txtbxPartsLaborLabor.Size = new System.Drawing.Size(52, 20);
            this.txtbxPartsLaborLabor.TabIndex = 3;
            // 
            // lblPartsLaborLabor
            // 
            this.lblPartsLaborLabor.AutoSize = true;
            this.lblPartsLaborLabor.Location = new System.Drawing.Point(27, 62);
            this.lblPartsLaborLabor.Name = "lblPartsLaborLabor";
            this.lblPartsLaborLabor.Size = new System.Drawing.Size(49, 13);
            this.lblPartsLaborLabor.TabIndex = 2;
            this.lblPartsLaborLabor.Text = "Labor ($)";
            // 
            // grpbxSummary
            // 
            this.grpbxSummary.Controls.Add(this.txtbxSumTotal);
            this.grpbxSummary.Controls.Add(this.lblSumTotalFees);
            this.grpbxSummary.Controls.Add(this.txtbxSumTax);
            this.grpbxSummary.Controls.Add(this.lblSumTax);
            this.grpbxSummary.Controls.Add(this.txtbxSumParts);
            this.grpbxSummary.Controls.Add(this.lblSumParts);
            this.grpbxSummary.Controls.Add(this.txtbxSumServiceLabor);
            this.grpbxSummary.Controls.Add(this.lblSumServiceLabor);
            this.grpbxSummary.Location = new System.Drawing.Point(13, 194);
            this.grpbxSummary.Name = "grpbxSummary";
            this.grpbxSummary.Size = new System.Drawing.Size(338, 130);
            this.grpbxSummary.TabIndex = 5;
            this.grpbxSummary.TabStop = false;
            this.grpbxSummary.Text = "Summary";
            // 
            // lblSumServiceLabor
            // 
            this.lblSumServiceLabor.AutoSize = true;
            this.lblSumServiceLabor.Location = new System.Drawing.Point(7, 20);
            this.lblSumServiceLabor.Name = "lblSumServiceLabor";
            this.lblSumServiceLabor.Size = new System.Drawing.Size(94, 13);
            this.lblSumServiceLabor.TabIndex = 0;
            this.lblSumServiceLabor.Text = "Service and Labor";
            // 
            // txtbxSumServiceLabor
            // 
            this.txtbxSumServiceLabor.Location = new System.Drawing.Point(107, 18);
            this.txtbxSumServiceLabor.Name = "txtbxSumServiceLabor";
            this.txtbxSumServiceLabor.ReadOnly = true;
            this.txtbxSumServiceLabor.Size = new System.Drawing.Size(100, 20);
            this.txtbxSumServiceLabor.TabIndex = 1;
            // 
            // txtbxSumParts
            // 
            this.txtbxSumParts.Location = new System.Drawing.Point(107, 44);
            this.txtbxSumParts.Name = "txtbxSumParts";
            this.txtbxSumParts.ReadOnly = true;
            this.txtbxSumParts.Size = new System.Drawing.Size(100, 20);
            this.txtbxSumParts.TabIndex = 3;
            // 
            // lblSumParts
            // 
            this.lblSumParts.AutoSize = true;
            this.lblSumParts.Location = new System.Drawing.Point(70, 47);
            this.lblSumParts.Name = "lblSumParts";
            this.lblSumParts.Size = new System.Drawing.Size(31, 13);
            this.lblSumParts.TabIndex = 2;
            this.lblSumParts.Text = "Parts";
            // 
            // txtbxSumTax
            // 
            this.txtbxSumTax.Location = new System.Drawing.Point(107, 70);
            this.txtbxSumTax.Name = "txtbxSumTax";
            this.txtbxSumTax.ReadOnly = true;
            this.txtbxSumTax.Size = new System.Drawing.Size(100, 20);
            this.txtbxSumTax.TabIndex = 5;
            // 
            // lblSumTax
            // 
            this.lblSumTax.AutoSize = true;
            this.lblSumTax.Location = new System.Drawing.Point(29, 73);
            this.lblSumTax.Name = "lblSumTax";
            this.lblSumTax.Size = new System.Drawing.Size(72, 13);
            this.lblSumTax.TabIndex = 4;
            this.lblSumTax.Text = "Tax (on parts)";
            // 
            // txtbxSumTotal
            // 
            this.txtbxSumTotal.Location = new System.Drawing.Point(107, 96);
            this.txtbxSumTotal.Name = "txtbxSumTotal";
            this.txtbxSumTotal.ReadOnly = true;
            this.txtbxSumTotal.Size = new System.Drawing.Size(100, 20);
            this.txtbxSumTotal.TabIndex = 7;
            // 
            // lblSumTotalFees
            // 
            this.lblSumTotalFees.AutoSize = true;
            this.lblSumTotalFees.Location = new System.Drawing.Point(44, 99);
            this.lblSumTotalFees.Name = "lblSumTotalFees";
            this.lblSumTotalFees.Size = new System.Drawing.Size(57, 13);
            this.lblSumTotalFees.TabIndex = 6;
            this.lblSumTotalFees.Text = "Total Fees";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(60, 330);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(141, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(222, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAutomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 372);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpbxSummary);
            this.Controls.Add(this.grpbxPartsLabor);
            this.Controls.Add(this.grpbxMisc);
            this.Controls.Add(this.grpbxFlushes);
            this.Controls.Add(this.grpbxOil);
            this.Name = "frmAutomotive";
            this.Text = "Automotive";
            this.grpbxOil.ResumeLayout(false);
            this.grpbxOil.PerformLayout();
            this.grpbxFlushes.ResumeLayout(false);
            this.grpbxFlushes.PerformLayout();
            this.grpbxMisc.ResumeLayout(false);
            this.grpbxMisc.PerformLayout();
            this.grpbxPartsLabor.ResumeLayout(false);
            this.grpbxPartsLabor.PerformLayout();
            this.grpbxSummary.ResumeLayout(false);
            this.grpbxSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxOil;
        private System.Windows.Forms.CheckBox chkbxOilLubeLube;
        private System.Windows.Forms.CheckBox chkbxOilLubeOil;
        private System.Windows.Forms.GroupBox grpbxFlushes;
        private System.Windows.Forms.CheckBox chkbxFlushesTransmission;
        private System.Windows.Forms.CheckBox chkbxFlushesRadiator;
        private System.Windows.Forms.GroupBox grpbxMisc;
        private System.Windows.Forms.CheckBox chkbxMiscTire;
        private System.Windows.Forms.CheckBox chkbxMiscMuffler;
        private System.Windows.Forms.CheckBox chkbxMiscInspection;
        private System.Windows.Forms.GroupBox grpbxPartsLabor;
        private System.Windows.Forms.TextBox txtbxPartsLaborLabor;
        private System.Windows.Forms.Label lblPartsLaborLabor;
        private System.Windows.Forms.TextBox txtbxPartsLaborParts;
        private System.Windows.Forms.Label lblPartsLaborParts;
        private System.Windows.Forms.GroupBox grpbxSummary;
        private System.Windows.Forms.Label lblSumServiceLabor;
        private System.Windows.Forms.TextBox txtbxSumTotal;
        private System.Windows.Forms.Label lblSumTotalFees;
        private System.Windows.Forms.TextBox txtbxSumTax;
        private System.Windows.Forms.Label lblSumTax;
        private System.Windows.Forms.TextBox txtbxSumParts;
        private System.Windows.Forms.Label lblSumParts;
        private System.Windows.Forms.TextBox txtbxSumServiceLabor;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

