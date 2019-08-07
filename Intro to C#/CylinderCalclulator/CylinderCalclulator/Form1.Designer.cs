namespace CylinderCalclulator
{
    partial class frmCylCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxRadius = new System.Windows.Forms.TextBox();
            this.txtbxHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rchtxtbxOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the Height";
            // 
            // txtbxRadius
            // 
            this.txtbxRadius.Location = new System.Drawing.Point(217, 51);
            this.txtbxRadius.Name = "txtbxRadius";
            this.txtbxRadius.Size = new System.Drawing.Size(210, 20);
            this.txtbxRadius.TabIndex = 2;
            // 
            // txtbxHeight
            // 
            this.txtbxHeight.Location = new System.Drawing.Point(217, 83);
            this.txtbxHeight.Name = "txtbxHeight";
            this.txtbxHeight.Size = new System.Drawing.Size(210, 20);
            this.txtbxHeight.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(115, 141);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(266, 47);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rchtxtbxOutput
            // 
            this.rchtxtbxOutput.Location = new System.Drawing.Point(58, 241);
            this.rchtxtbxOutput.Name = "rchtxtbxOutput";
            this.rchtxtbxOutput.Size = new System.Drawing.Size(368, 124);
            this.rchtxtbxOutput.TabIndex = 5;
            this.rchtxtbxOutput.Text = "";
            // 
            // frmCylCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(516, 444);
            this.Controls.Add(this.rchtxtbxOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtbxHeight);
            this.Controls.Add(this.txtbxRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCylCalc";
            this.Text = "Cylinder Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxRadius;
        private System.Windows.Forms.TextBox txtbxHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox rchtxtbxOutput;
    }
}

