namespace DateTimeExample1
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
            this.btnRunApp = new System.Windows.Forms.Button();
            this.rchtxtbxDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRunApp
            // 
            this.btnRunApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunApp.Location = new System.Drawing.Point(72, 282);
            this.btnRunApp.Name = "btnRunApp";
            this.btnRunApp.Size = new System.Drawing.Size(282, 53);
            this.btnRunApp.TabIndex = 0;
            this.btnRunApp.Text = "Run Application";
            this.btnRunApp.UseVisualStyleBackColor = true;
            this.btnRunApp.Click += new System.EventHandler(this.btnRunApp_Click);
            // 
            // rchtxtbxDisplay
            // 
            this.rchtxtbxDisplay.Location = new System.Drawing.Point(72, 57);
            this.rchtxtbxDisplay.Name = "rchtxtbxDisplay";
            this.rchtxtbxDisplay.Size = new System.Drawing.Size(282, 208);
            this.rchtxtbxDisplay.TabIndex = 1;
            this.rchtxtbxDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 387);
            this.Controls.Add(this.rchtxtbxDisplay);
            this.Controls.Add(this.btnRunApp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunApp;
        private System.Windows.Forms.RichTextBox rchtxtbxDisplay;
    }
}

