namespace MatthewPowers_Population
{
    partial class frmPopulation
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
            this.txtbxOrganisms = new System.Windows.Forms.TextBox();
            this.txtbxIncrease = new System.Windows.Forms.TextBox();
            this.txtbxMultiply = new System.Windows.Forms.TextBox();
            this.lblNumOrganisms = new System.Windows.Forms.Label();
            this.lblDailyIncrease = new System.Windows.Forms.Label();
            this.lblDaysMultiply = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lstbxDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtbxOrganisms
            // 
            this.txtbxOrganisms.Location = new System.Drawing.Point(174, 12);
            this.txtbxOrganisms.Name = "txtbxOrganisms";
            this.txtbxOrganisms.Size = new System.Drawing.Size(129, 20);
            this.txtbxOrganisms.TabIndex = 0;
            // 
            // txtbxIncrease
            // 
            this.txtbxIncrease.Location = new System.Drawing.Point(174, 38);
            this.txtbxIncrease.Name = "txtbxIncrease";
            this.txtbxIncrease.Size = new System.Drawing.Size(129, 20);
            this.txtbxIncrease.TabIndex = 1;
            // 
            // txtbxMultiply
            // 
            this.txtbxMultiply.Location = new System.Drawing.Point(174, 64);
            this.txtbxMultiply.Name = "txtbxMultiply";
            this.txtbxMultiply.Size = new System.Drawing.Size(129, 20);
            this.txtbxMultiply.TabIndex = 2;
            // 
            // lblNumOrganisms
            // 
            this.lblNumOrganisms.AutoSize = true;
            this.lblNumOrganisms.Location = new System.Drawing.Point(22, 15);
            this.lblNumOrganisms.Name = "lblNumOrganisms";
            this.lblNumOrganisms.Size = new System.Drawing.Size(146, 13);
            this.lblNumOrganisms.TabIndex = 3;
            this.lblNumOrganisms.Text = "Starting number of organisms:";
            // 
            // lblDailyIncrease
            // 
            this.lblDailyIncrease.AutoSize = true;
            this.lblDailyIncrease.Location = new System.Drawing.Point(51, 41);
            this.lblDailyIncrease.Name = "lblDailyIncrease";
            this.lblDailyIncrease.Size = new System.Drawing.Size(117, 13);
            this.lblDailyIncrease.TabIndex = 4;
            this.lblDailyIncrease.Text = "Average daily increase:";
            // 
            // lblDaysMultiply
            // 
            this.lblDaysMultiply.AutoSize = true;
            this.lblDaysMultiply.Location = new System.Drawing.Point(35, 67);
            this.lblDaysMultiply.Name = "lblDaysMultiply";
            this.lblDaysMultiply.Size = new System.Drawing.Size(133, 13);
            this.lblDaysMultiply.TabIndex = 5;
            this.lblDaysMultiply.Text = "Number of days to multiply:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(227, 91);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lstbxDisplay
            // 
            this.lstbxDisplay.FormattingEnabled = true;
            this.lstbxDisplay.Location = new System.Drawing.Point(12, 121);
            this.lstbxDisplay.Name = "lstbxDisplay";
            this.lstbxDisplay.Size = new System.Drawing.Size(291, 147);
            this.lstbxDisplay.TabIndex = 7;
            // 
            // frmPopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 279);
            this.Controls.Add(this.lstbxDisplay);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblDaysMultiply);
            this.Controls.Add(this.lblDailyIncrease);
            this.Controls.Add(this.lblNumOrganisms);
            this.Controls.Add(this.txtbxMultiply);
            this.Controls.Add(this.txtbxIncrease);
            this.Controls.Add(this.txtbxOrganisms);
            this.Name = "frmPopulation";
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxOrganisms;
        private System.Windows.Forms.TextBox txtbxIncrease;
        private System.Windows.Forms.TextBox txtbxMultiply;
        private System.Windows.Forms.Label lblNumOrganisms;
        private System.Windows.Forms.Label lblDailyIncrease;
        private System.Windows.Forms.Label lblDaysMultiply;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lstbxDisplay;
    }
}

