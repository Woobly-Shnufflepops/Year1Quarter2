namespace starBox
{
    partial class frmStarBox
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
            this.txtbxRows = new System.Windows.Forms.TextBox();
            this.txtbxColumns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAllStar = new System.Windows.Forms.Button();
            this.btnOddColumns = new System.Windows.Forms.Button();
            this.btnEvenRow = new System.Windows.Forms.Button();
            this.btnHollow = new System.Windows.Forms.Button();
            this.rchtxtbxOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtbxRows
            // 
            this.txtbxRows.Location = new System.Drawing.Point(12, 25);
            this.txtbxRows.Name = "txtbxRows";
            this.txtbxRows.Size = new System.Drawing.Size(180, 20);
            this.txtbxRows.TabIndex = 0;
            // 
            // txtbxColumns
            // 
            this.txtbxColumns.Location = new System.Drawing.Point(12, 64);
            this.txtbxColumns.Name = "txtbxColumns";
            this.txtbxColumns.Size = new System.Drawing.Size(180, 20);
            this.txtbxColumns.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the number of Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the number of Columns";
            // 
            // btnAllStar
            // 
            this.btnAllStar.Location = new System.Drawing.Point(12, 98);
            this.btnAllStar.Name = "btnAllStar";
            this.btnAllStar.Size = new System.Drawing.Size(175, 55);
            this.btnAllStar.TabIndex = 4;
            this.btnAllStar.Text = "Draw All Stars";
            this.btnAllStar.UseVisualStyleBackColor = true;
            this.btnAllStar.Click += new System.EventHandler(this.btnAllStar_Click);
            // 
            // btnOddColumns
            // 
            this.btnOddColumns.Location = new System.Drawing.Point(12, 159);
            this.btnOddColumns.Name = "btnOddColumns";
            this.btnOddColumns.Size = new System.Drawing.Size(175, 55);
            this.btnOddColumns.TabIndex = 5;
            this.btnOddColumns.Text = "Draw Box Stars on Odd Columns";
            this.btnOddColumns.UseVisualStyleBackColor = true;
            this.btnOddColumns.Click += new System.EventHandler(this.btnOddColumns_Click);
            // 
            // btnEvenRow
            // 
            this.btnEvenRow.Location = new System.Drawing.Point(12, 220);
            this.btnEvenRow.Name = "btnEvenRow";
            this.btnEvenRow.Size = new System.Drawing.Size(175, 55);
            this.btnEvenRow.TabIndex = 6;
            this.btnEvenRow.Text = "Draw Box Stars on Even Rows";
            this.btnEvenRow.UseVisualStyleBackColor = true;
            this.btnEvenRow.Click += new System.EventHandler(this.btnEvenRow_Click);
            // 
            // btnHollow
            // 
            this.btnHollow.Location = new System.Drawing.Point(12, 281);
            this.btnHollow.Name = "btnHollow";
            this.btnHollow.Size = new System.Drawing.Size(175, 55);
            this.btnHollow.TabIndex = 7;
            this.btnHollow.Text = "Draw Hollow Square";
            this.btnHollow.UseVisualStyleBackColor = true;
            this.btnHollow.Click += new System.EventHandler(this.btnHollow_Click);
            // 
            // rchtxtbxOutput
            // 
            this.rchtxtbxOutput.Location = new System.Drawing.Point(198, 9);
            this.rchtxtbxOutput.Name = "rchtxtbxOutput";
            this.rchtxtbxOutput.Size = new System.Drawing.Size(714, 336);
            this.rchtxtbxOutput.TabIndex = 8;
            this.rchtxtbxOutput.Text = "";
            // 
            // frmStarBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 360);
            this.Controls.Add(this.rchtxtbxOutput);
            this.Controls.Add(this.btnHollow);
            this.Controls.Add(this.btnEvenRow);
            this.Controls.Add(this.btnOddColumns);
            this.Controls.Add(this.btnAllStar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxColumns);
            this.Controls.Add(this.txtbxRows);
            this.Name = "frmStarBox";
            this.Text = "Star Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxRows;
        private System.Windows.Forms.TextBox txtbxColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAllStar;
        private System.Windows.Forms.Button btnOddColumns;
        private System.Windows.Forms.Button btnEvenRow;
        private System.Windows.Forms.Button btnHollow;
        private System.Windows.Forms.RichTextBox rchtxtbxOutput;
    }
}

