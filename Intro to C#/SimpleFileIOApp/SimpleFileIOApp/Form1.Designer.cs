namespace SimpleFileIOApp
{
    partial class frmIO
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
            this.txtInput01 = new System.Windows.Forms.TextBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.btnRunApplication = new System.Windows.Forms.Button();
            this.rchtxtbxFileIn = new System.Windows.Forms.RichTextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtInput01
            // 
            this.txtInput01.Location = new System.Drawing.Point(167, 113);
            this.txtInput01.Name = "txtInput01";
            this.txtInput01.Size = new System.Drawing.Size(325, 20);
            this.txtInput01.TabIndex = 0;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Location = new System.Drawing.Point(164, 97);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(70, 13);
            this.lbl01.TabIndex = 1;
            this.lbl01.Text = "Enter a name";
            // 
            // btnRunApplication
            // 
            this.btnRunApplication.Location = new System.Drawing.Point(167, 165);
            this.btnRunApplication.Name = "btnRunApplication";
            this.btnRunApplication.Size = new System.Drawing.Size(324, 42);
            this.btnRunApplication.TabIndex = 2;
            this.btnRunApplication.Text = "Write the name to File";
            this.btnRunApplication.UseVisualStyleBackColor = true;
            this.btnRunApplication.Click += new System.EventHandler(this.btnRunApplication_Click);
            // 
            // rchtxtbxFileIn
            // 
            this.rchtxtbxFileIn.Location = new System.Drawing.Point(167, 359);
            this.rchtxtbxFileIn.Name = "rchtxtbxFileIn";
            this.rchtxtbxFileIn.Size = new System.Drawing.Size(323, 86);
            this.rchtxtbxFileIn.TabIndex = 3;
            this.rchtxtbxFileIn.Text = "";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(167, 304);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(323, 39);
            this.btnReadFile.TabIndex = 4;
            this.btnReadFile.Text = "Read the File name";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 489);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.rchtxtbxFileIn);
            this.Controls.Add(this.btnRunApplication);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.txtInput01);
            this.Name = "frmIO";
            this.Text = "Simple IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput01;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Button btnRunApplication;
        private System.Windows.Forms.RichTextBox rchtxtbxFileIn;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

