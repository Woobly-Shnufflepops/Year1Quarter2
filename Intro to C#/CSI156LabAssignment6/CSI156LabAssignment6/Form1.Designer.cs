namespace CSI156LabAssignment6
{
    partial class frmProRat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numUDHelp = new System.Windows.Forms.NumericUpDown();
            this.numUDClar = new System.Windows.Forms.NumericUpDown();
            this.numUDEase = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxProID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbxAvg = new System.Windows.Forms.TextBox();
            this.txtbxEase = new System.Windows.Forms.TextBox();
            this.txtbxClar = new System.Windows.Forms.TextBox();
            this.txtbxHelp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrintRatings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDClar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor\'s ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Helpfulness:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clarity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Easiness:";
            // 
            // numUDHelp
            // 
            this.numUDHelp.Location = new System.Drawing.Point(110, 45);
            this.numUDHelp.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDHelp.Name = "numUDHelp";
            this.numUDHelp.Size = new System.Drawing.Size(120, 20);
            this.numUDHelp.TabIndex = 10;
            // 
            // numUDClar
            // 
            this.numUDClar.Location = new System.Drawing.Point(110, 71);
            this.numUDClar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDClar.Name = "numUDClar";
            this.numUDClar.Size = new System.Drawing.Size(120, 20);
            this.numUDClar.TabIndex = 11;
            // 
            // numUDEase
            // 
            this.numUDEase.Location = new System.Drawing.Point(110, 97);
            this.numUDEase.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDEase.Name = "numUDEase";
            this.numUDEase.Size = new System.Drawing.Size(120, 20);
            this.numUDEase.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxProID);
            this.groupBox1.Controls.Add(this.numUDEase);
            this.groupBox1.Controls.Add(this.numUDClar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numUDHelp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 145);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter The Ratings";
            // 
            // txtbxProID
            // 
            this.txtbxProID.Location = new System.Drawing.Point(109, 19);
            this.txtbxProID.Name = "txtbxProID";
            this.txtbxProID.Size = new System.Drawing.Size(120, 20);
            this.txtbxProID.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbxAvg);
            this.groupBox2.Controls.Add(this.txtbxEase);
            this.groupBox2.Controls.Add(this.txtbxClar);
            this.groupBox2.Controls.Add(this.txtbxHelp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 172);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ratings";
            // 
            // txtbxAvg
            // 
            this.txtbxAvg.Location = new System.Drawing.Point(110, 102);
            this.txtbxAvg.Name = "txtbxAvg";
            this.txtbxAvg.ReadOnly = true;
            this.txtbxAvg.Size = new System.Drawing.Size(120, 20);
            this.txtbxAvg.TabIndex = 20;
            // 
            // txtbxEase
            // 
            this.txtbxEase.Location = new System.Drawing.Point(110, 76);
            this.txtbxEase.Name = "txtbxEase";
            this.txtbxEase.ReadOnly = true;
            this.txtbxEase.Size = new System.Drawing.Size(120, 20);
            this.txtbxEase.TabIndex = 19;
            // 
            // txtbxClar
            // 
            this.txtbxClar.Location = new System.Drawing.Point(110, 50);
            this.txtbxClar.Name = "txtbxClar";
            this.txtbxClar.ReadOnly = true;
            this.txtbxClar.Size = new System.Drawing.Size(120, 20);
            this.txtbxClar.TabIndex = 18;
            // 
            // txtbxHelp
            // 
            this.txtbxHelp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtbxHelp.Location = new System.Drawing.Point(110, 24);
            this.txtbxHelp.Name = "txtbxHelp";
            this.txtbxHelp.ReadOnly = true;
            this.txtbxHelp.Size = new System.Drawing.Size(120, 20);
            this.txtbxHelp.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Average:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Helpfulness:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Easiness:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Clarity:";
            // 
            // btnPrintRatings
            // 
            this.btnPrintRatings.Location = new System.Drawing.Point(13, 343);
            this.btnPrintRatings.Name = "btnPrintRatings";
            this.btnPrintRatings.Size = new System.Drawing.Size(120, 55);
            this.btnPrintRatings.TabIndex = 15;
            this.btnPrintRatings.Text = "Print Ratings";
            this.btnPrintRatings.UseVisualStyleBackColor = true;
            this.btnPrintRatings.Click += new System.EventHandler(this.btnPrintRatings_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 55);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmProRat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 410);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintRatings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProRat";
            this.Text = "Professor Ratings";
            ((System.ComponentModel.ISupportInitialize)(this.numUDHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDClar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUDHelp;
        private System.Windows.Forms.NumericUpDown numUDClar;
        private System.Windows.Forms.NumericUpDown numUDEase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbxAvg;
        private System.Windows.Forms.TextBox txtbxEase;
        private System.Windows.Forms.TextBox txtbxClar;
        private System.Windows.Forms.TextBox txtbxHelp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrintRatings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtbxProID;
    }
}

