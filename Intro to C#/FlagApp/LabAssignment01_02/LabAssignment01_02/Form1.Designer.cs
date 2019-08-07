namespace LabAssignment01_02 {
    partial class diceRollApp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.diePictureBox = new System.Windows.Forms.PictureBox();
            this.dieRollButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // diePictureBox
            // 
            this.diePictureBox.Location = new System.Drawing.Point(12, 12);
            this.diePictureBox.Name = "diePictureBox";
            this.diePictureBox.Size = new System.Drawing.Size(1240, 481);
            this.diePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.diePictureBox.TabIndex = 0;
            this.diePictureBox.TabStop = false;
            // 
            // dieRollButton
            // 
            this.dieRollButton.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieRollButton.Location = new System.Drawing.Point(12, 499);
            this.dieRollButton.Name = "dieRollButton";
            this.dieRollButton.Size = new System.Drawing.Size(1240, 170);
            this.dieRollButton.TabIndex = 1;
            this.dieRollButton.Text = "Run Application";
            this.dieRollButton.UseVisualStyleBackColor = true;
            this.dieRollButton.Click += new System.EventHandler(this.dieRollButton_Click);
            // 
            // diceRollApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LabAssignment01_02.Properties.Resources.prophetMohamad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dieRollButton);
            this.Controls.Add(this.diePictureBox);
            this.Name = "diceRollApp";
            this.Text = "Dice Roll Application";
            this.Load += new System.EventHandler(this.diceRollApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox diePictureBox;
        private System.Windows.Forms.Button dieRollButton;
    }
}

