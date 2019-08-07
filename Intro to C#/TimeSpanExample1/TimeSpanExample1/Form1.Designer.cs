namespace TimeSpanExample1
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
            this.btnRunApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunApp.Location = new System.Drawing.Point(12, 325);
            this.btnRunApp.Name = "btnRunApp";
            this.btnRunApp.Size = new System.Drawing.Size(544, 71);
            this.btnRunApp.TabIndex = 0;
            this.btnRunApp.Text = "Run Application";
            this.btnRunApp.UseVisualStyleBackColor = true;
            this.btnRunApp.Click += new System.EventHandler(this.btnRunApp_Click);
            // 
            // rchtxtbxDisplay
            // 
            this.rchtxtbxDisplay.Location = new System.Drawing.Point(13, 13);
            this.rchtxtbxDisplay.Name = "rchtxtbxDisplay";
            this.rchtxtbxDisplay.Size = new System.Drawing.Size(543, 306);
            this.rchtxtbxDisplay.TabIndex = 1;
            this.rchtxtbxDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 408);
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

