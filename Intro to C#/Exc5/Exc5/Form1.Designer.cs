namespace Exc5
{
    partial class Form1
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
            this.btnDisplayToRich = new System.Windows.Forms.Button();
            this.rchtxtbxDisplay = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.txtbxHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplayToRich
            // 
            this.btnDisplayToRich.Location = new System.Drawing.Point(12, 174);
            this.btnDisplayToRich.Name = "btnDisplayToRich";
            this.btnDisplayToRich.Size = new System.Drawing.Size(407, 67);
            this.btnDisplayToRich.TabIndex = 0;
            this.btnDisplayToRich.Text = "Display Name Age and Height";
            this.btnDisplayToRich.UseVisualStyleBackColor = true;
            this.btnDisplayToRich.Click += new System.EventHandler(this.btnDisplayToRich_Click);
            // 
            // rchtxtbxDisplay
            // 
            this.rchtxtbxDisplay.Location = new System.Drawing.Point(12, 247);
            this.rchtxtbxDisplay.Name = "rchtxtbxDisplay";
            this.rchtxtbxDisplay.Size = new System.Drawing.Size(407, 124);
            this.rchtxtbxDisplay.TabIndex = 1;
            this.rchtxtbxDisplay.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(12, 30);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(173, 20);
            this.txtbxName.TabIndex = 5;
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(12, 69);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(173, 20);
            this.txtbxAge.TabIndex = 6;
            // 
            // txtbxHeight
            // 
            this.txtbxHeight.Location = new System.Drawing.Point(12, 108);
            this.txtbxHeight.Name = "txtbxHeight";
            this.txtbxHeight.Size = new System.Drawing.Size(173, 20);
            this.txtbxHeight.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 383);
            this.Controls.Add(this.txtbxHeight);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchtxtbxDisplay);
            this.Controls.Add(this.btnDisplayToRich);
            this.Name = "Form1";
            this.Text = "People Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayToRich;
        private System.Windows.Forms.RichTextBox rchtxtbxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.TextBox txtbxHeight;
    }
}

