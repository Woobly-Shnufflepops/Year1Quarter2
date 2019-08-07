namespace CSI_154_Lab_Assignment_4
{
    partial class frmDialogs
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtbxNumbersInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstbxDisplay = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnPopulateArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxNumbersInput
            // 
            this.txtbxNumbersInput.Location = new System.Drawing.Point(12, 35);
            this.txtbxNumbersInput.Name = "txtbxNumbersInput";
            this.txtbxNumbersInput.Size = new System.Drawing.Size(208, 20);
            this.txtbxNumbersInput.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstbxDisplay
            // 
            this.lstbxDisplay.FormattingEnabled = true;
            this.lstbxDisplay.Location = new System.Drawing.Point(12, 111);
            this.lstbxDisplay.Name = "lstbxDisplay";
            this.lstbxDisplay.Size = new System.Drawing.Size(591, 316);
            this.lstbxDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numbers written (0 to 100)";
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.Location = new System.Drawing.Point(394, 53);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(209, 44);
            this.btnWriteToFile.TabIndex = 3;
            this.btnWriteToFile.Text = "Write to File";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(394, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(209, 44);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnPopulateArray
            // 
            this.btnPopulateArray.Location = new System.Drawing.Point(15, 61);
            this.btnPopulateArray.Name = "btnPopulateArray";
            this.btnPopulateArray.Size = new System.Drawing.Size(209, 44);
            this.btnPopulateArray.TabIndex = 5;
            this.btnPopulateArray.Text = "Write Numbers";
            this.btnPopulateArray.UseVisualStyleBackColor = true;
            this.btnPopulateArray.Click += new System.EventHandler(this.btnPopulateArray_Click);
            // 
            // frmDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 439);
            this.Controls.Add(this.btnPopulateArray);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxDisplay);
            this.Controls.Add(this.txtbxNumbersInput);
            this.Name = "frmDialogs";
            this.Text = "File Dialogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtbxNumbersInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstbxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnPopulateArray;
    }
}

