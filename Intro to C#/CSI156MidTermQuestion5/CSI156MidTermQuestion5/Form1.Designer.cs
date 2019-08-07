namespace CSI156MidTermQuestion5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonEnterName = new System.Windows.Forms.Button();
            this.buttonSaveNames = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(496, 186);
            this.listBox1.TabIndex = 1;
            // 
            // buttonEnterName
            // 
            this.buttonEnterName.Location = new System.Drawing.Point(12, 139);
            this.buttonEnterName.Name = "buttonEnterName";
            this.buttonEnterName.Size = new System.Drawing.Size(172, 57);
            this.buttonEnterName.TabIndex = 2;
            this.buttonEnterName.Text = "Add a Name";
            this.buttonEnterName.UseVisualStyleBackColor = true;
            this.buttonEnterName.Click += new System.EventHandler(this.buttonEnterName_Click);
            // 
            // buttonSaveNames
            // 
            this.buttonSaveNames.Location = new System.Drawing.Point(336, 139);
            this.buttonSaveNames.Name = "buttonSaveNames";
            this.buttonSaveNames.Size = new System.Drawing.Size(172, 57);
            this.buttonSaveNames.TabIndex = 3;
            this.buttonSaveNames.Text = "Save Names";
            this.buttonSaveNames.UseVisualStyleBackColor = true;
            this.buttonSaveNames.Click += new System.EventHandler(this.buttonSaveNames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.Controls.Add(this.buttonSaveNames);
            this.Controls.Add(this.buttonEnterName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonEnterName;
        private System.Windows.Forms.Button buttonSaveNames;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

