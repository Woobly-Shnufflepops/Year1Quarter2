namespace MatthewPowers_ColorMixer
{
    partial class frmColorMixer
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
            this.grpbxFColor = new System.Windows.Forms.GroupBox();
            this.rdbtnFRed = new System.Windows.Forms.RadioButton();
            this.rdbtnFBlue = new System.Windows.Forms.RadioButton();
            this.rdbtnFYellow = new System.Windows.Forms.RadioButton();
            this.grpbxSColor = new System.Windows.Forms.GroupBox();
            this.rdbtnSYellow = new System.Windows.Forms.RadioButton();
            this.rdbtnSBlue = new System.Windows.Forms.RadioButton();
            this.rdbtnSRed = new System.Windows.Forms.RadioButton();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbxFColor.SuspendLayout();
            this.grpbxSColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxFColor
            // 
            this.grpbxFColor.Controls.Add(this.rdbtnFYellow);
            this.grpbxFColor.Controls.Add(this.rdbtnFBlue);
            this.grpbxFColor.Controls.Add(this.rdbtnFRed);
            this.grpbxFColor.Location = new System.Drawing.Point(13, 13);
            this.grpbxFColor.Name = "grpbxFColor";
            this.grpbxFColor.Size = new System.Drawing.Size(200, 102);
            this.grpbxFColor.TabIndex = 0;
            this.grpbxFColor.TabStop = false;
            this.grpbxFColor.Text = "Select The First Color";
            // 
            // rdbtnFRed
            // 
            this.rdbtnFRed.AutoSize = true;
            this.rdbtnFRed.Location = new System.Drawing.Point(7, 20);
            this.rdbtnFRed.Name = "rdbtnFRed";
            this.rdbtnFRed.Size = new System.Drawing.Size(45, 17);
            this.rdbtnFRed.TabIndex = 0;
            this.rdbtnFRed.TabStop = true;
            this.rdbtnFRed.Text = "Red";
            this.rdbtnFRed.UseVisualStyleBackColor = true;
            // 
            // rdbtnFBlue
            // 
            this.rdbtnFBlue.AutoSize = true;
            this.rdbtnFBlue.Location = new System.Drawing.Point(7, 43);
            this.rdbtnFBlue.Name = "rdbtnFBlue";
            this.rdbtnFBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbtnFBlue.TabIndex = 1;
            this.rdbtnFBlue.TabStop = true;
            this.rdbtnFBlue.Text = "Blue";
            this.rdbtnFBlue.UseVisualStyleBackColor = true;
            // 
            // rdbtnFYellow
            // 
            this.rdbtnFYellow.AutoSize = true;
            this.rdbtnFYellow.Location = new System.Drawing.Point(7, 66);
            this.rdbtnFYellow.Name = "rdbtnFYellow";
            this.rdbtnFYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbtnFYellow.TabIndex = 2;
            this.rdbtnFYellow.TabStop = true;
            this.rdbtnFYellow.Text = "Yellow";
            this.rdbtnFYellow.UseVisualStyleBackColor = true;
            // 
            // grpbxSColor
            // 
            this.grpbxSColor.Controls.Add(this.rdbtnSYellow);
            this.grpbxSColor.Controls.Add(this.rdbtnSBlue);
            this.grpbxSColor.Controls.Add(this.rdbtnSRed);
            this.grpbxSColor.Location = new System.Drawing.Point(257, 13);
            this.grpbxSColor.Name = "grpbxSColor";
            this.grpbxSColor.Size = new System.Drawing.Size(200, 102);
            this.grpbxSColor.TabIndex = 3;
            this.grpbxSColor.TabStop = false;
            this.grpbxSColor.Text = "Select The Second Color";
            // 
            // rdbtnSYellow
            // 
            this.rdbtnSYellow.AutoSize = true;
            this.rdbtnSYellow.Location = new System.Drawing.Point(7, 66);
            this.rdbtnSYellow.Name = "rdbtnSYellow";
            this.rdbtnSYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbtnSYellow.TabIndex = 2;
            this.rdbtnSYellow.TabStop = true;
            this.rdbtnSYellow.Text = "Yellow";
            this.rdbtnSYellow.UseVisualStyleBackColor = true;
            // 
            // rdbtnSBlue
            // 
            this.rdbtnSBlue.AutoSize = true;
            this.rdbtnSBlue.Location = new System.Drawing.Point(7, 43);
            this.rdbtnSBlue.Name = "rdbtnSBlue";
            this.rdbtnSBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbtnSBlue.TabIndex = 1;
            this.rdbtnSBlue.TabStop = true;
            this.rdbtnSBlue.Text = "Blue";
            this.rdbtnSBlue.UseVisualStyleBackColor = true;
            // 
            // rdbtnSRed
            // 
            this.rdbtnSRed.AutoSize = true;
            this.rdbtnSRed.Location = new System.Drawing.Point(7, 20);
            this.rdbtnSRed.Name = "rdbtnSRed";
            this.rdbtnSRed.Size = new System.Drawing.Size(45, 17);
            this.rdbtnSRed.TabIndex = 0;
            this.rdbtnSRed.TabStop = true;
            this.rdbtnSRed.Text = "Red";
            this.rdbtnSRed.UseVisualStyleBackColor = true;
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(138, 137);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(75, 23);
            this.btnMix.TabIndex = 4;
            this.btnMix.Text = "Mix";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmColorMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 172);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.grpbxSColor);
            this.Controls.Add(this.grpbxFColor);
            this.Name = "frmColorMixer";
            this.Text = "Color Mixer";
            this.grpbxFColor.ResumeLayout(false);
            this.grpbxFColor.PerformLayout();
            this.grpbxSColor.ResumeLayout(false);
            this.grpbxSColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxFColor;
        private System.Windows.Forms.RadioButton rdbtnFYellow;
        private System.Windows.Forms.RadioButton rdbtnFBlue;
        private System.Windows.Forms.RadioButton rdbtnFRed;
        private System.Windows.Forms.GroupBox grpbxSColor;
        private System.Windows.Forms.RadioButton rdbtnSYellow;
        private System.Windows.Forms.RadioButton rdbtnSBlue;
        private System.Windows.Forms.RadioButton rdbtnSRed;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnClose;
    }
}

