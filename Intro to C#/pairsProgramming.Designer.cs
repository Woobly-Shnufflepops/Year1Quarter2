namespace PairsPrograming
{
    partial class pairProgramExe
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
            this.positiveTotal = new System.Windows.Forms.Button();
            this.sumAllOdd = new System.Windows.Forms.Button();
            this.averageAllPositiveOdd = new System.Windows.Forms.Button();
            this.numNegativeElements = new System.Windows.Forms.Button();
            this.averageAllEven = new System.Windows.Forms.Button();
            this.averageNeagtive = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // positiveTotal
            // 
            this.positiveTotal.Location = new System.Drawing.Point(12, 12);
            this.positiveTotal.Name = "positiveTotal";
            this.positiveTotal.Size = new System.Drawing.Size(237, 122);
            this.positiveTotal.TabIndex = 0;
            this.positiveTotal.Text = "Find Positive Total";
            this.positiveTotal.UseVisualStyleBackColor = true;
            this.positiveTotal.Click += new System.EventHandler(this.positiveTotal_Click);
            // 
            // sumAllOdd
            // 
            this.sumAllOdd.Location = new System.Drawing.Point(12, 140);
            this.sumAllOdd.Name = "sumAllOdd";
            this.sumAllOdd.Size = new System.Drawing.Size(237, 122);
            this.sumAllOdd.TabIndex = 1;
            this.sumAllOdd.Text = "Find Sum All Odd";
            this.sumAllOdd.UseVisualStyleBackColor = true;
            this.sumAllOdd.Click += new System.EventHandler(this.sumAllOdd_Click);
            // 
            // averageAllPositiveOdd
            // 
            this.averageAllPositiveOdd.Location = new System.Drawing.Point(12, 268);
            this.averageAllPositiveOdd.Name = "averageAllPositiveOdd";
            this.averageAllPositiveOdd.Size = new System.Drawing.Size(237, 122);
            this.averageAllPositiveOdd.TabIndex = 2;
            this.averageAllPositiveOdd.Text = "Find Average of All Positive Odd";
            this.averageAllPositiveOdd.UseVisualStyleBackColor = true;
            this.averageAllPositiveOdd.Click += new System.EventHandler(this.averageAllPositiveOdd_Click);
            // 
            // numNegativeElements
            // 
            this.numNegativeElements.Location = new System.Drawing.Point(255, 268);
            this.numNegativeElements.Name = "numNegativeElements";
            this.numNegativeElements.Size = new System.Drawing.Size(237, 122);
            this.numNegativeElements.TabIndex = 3;
            this.numNegativeElements.Text = "Find Number of Negative Elements";
            this.numNegativeElements.UseVisualStyleBackColor = true;
            this.numNegativeElements.Click += new System.EventHandler(this.numNegativeElements_Click);
            // 
            // averageAllEven
            // 
            this.averageAllEven.Location = new System.Drawing.Point(255, 140);
            this.averageAllEven.Name = "averageAllEven";
            this.averageAllEven.Size = new System.Drawing.Size(237, 122);
            this.averageAllEven.TabIndex = 4;
            this.averageAllEven.Text = "Find Average of All Even";
            this.averageAllEven.UseVisualStyleBackColor = true;
            this.averageAllEven.Click += new System.EventHandler(this.averageAllEven_Click);
            // 
            // averageNeagtive
            // 
            this.averageNeagtive.Location = new System.Drawing.Point(255, 12);
            this.averageNeagtive.Name = "averageNeagtive";
            this.averageNeagtive.Size = new System.Drawing.Size(237, 122);
            this.averageNeagtive.TabIndex = 5;
            this.averageNeagtive.Text = "Find Average Negative";
            this.averageNeagtive.UseVisualStyleBackColor = true;
            this.averageNeagtive.Click += new System.EventHandler(this.averageNegative_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.Location = new System.Drawing.Point(498, 12);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(754, 378);
            this.displayTextBox.TabIndex = 6;
            this.displayTextBox.Text = "";
            // 
            // pairProgramExe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 400);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.averageNeagtive);
            this.Controls.Add(this.averageAllEven);
            this.Controls.Add(this.numNegativeElements);
            this.Controls.Add(this.averageAllPositiveOdd);
            this.Controls.Add(this.sumAllOdd);
            this.Controls.Add(this.positiveTotal);
            this.Name = "pairProgramExe";
            this.Text = "Pair Program Thingy";
            this.Load += new System.EventHandler(this.pairProgramExe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button positiveTotal;
        private System.Windows.Forms.Button sumAllOdd;
        private System.Windows.Forms.Button averageAllPositiveOdd;
        private System.Windows.Forms.Button numNegativeElements;
        private System.Windows.Forms.Button averageAllEven;
        private System.Windows.Forms.Button averageNeagtive;
        private System.Windows.Forms.RichTextBox displayTextBox;
    }
}

