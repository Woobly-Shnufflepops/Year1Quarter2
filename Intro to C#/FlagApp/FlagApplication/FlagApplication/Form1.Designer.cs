namespace FlagApplication {
    partial class flagWindow {
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
            this.flagDisplay = new System.Windows.Forms.PictureBox();
            this.switchFlag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flagDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // flagDisplay
            // 
            this.flagDisplay.Location = new System.Drawing.Point(12, 12);
            this.flagDisplay.Name = "flagDisplay";
            this.flagDisplay.Size = new System.Drawing.Size(1240, 490);
            this.flagDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flagDisplay.TabIndex = 0;
            this.flagDisplay.TabStop = false;
            // 
            // switchFlag
            // 
            this.switchFlag.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchFlag.Location = new System.Drawing.Point(12, 508);
            this.switchFlag.Name = "switchFlag";
            this.switchFlag.Size = new System.Drawing.Size(1239, 161);
            this.switchFlag.TabIndex = 1;
            this.switchFlag.Text = "Switch Flag";
            this.switchFlag.UseVisualStyleBackColor = true;
            this.switchFlag.Click += new System.EventHandler(this.switchFlag_Click);
            // 
            // flagWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.switchFlag);
            this.Controls.Add(this.flagDisplay);
            this.Name = "flagWindow";
            this.Text = "Flag Application";
            this.Load += new System.EventHandler(this.flagWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flagDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox flagDisplay;
        private System.Windows.Forms.Button switchFlag;
    }
}

