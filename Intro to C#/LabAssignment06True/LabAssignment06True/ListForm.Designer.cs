namespace LabAssignment06True
{
    partial class frmListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxEMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(12, 25);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.ReadOnly = true;
            this.txtbxName.Size = new System.Drawing.Size(260, 20);
            this.txtbxName.TabIndex = 1;
            // 
            // txtbxEMail
            // 
            this.txtbxEMail.Location = new System.Drawing.Point(12, 64);
            this.txtbxEMail.Name = "txtbxEMail";
            this.txtbxEMail.ReadOnly = true;
            this.txtbxEMail.Size = new System.Drawing.Size(260, 20);
            this.txtbxEMail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            // 
            // txtbxPhoneNumber
            // 
            this.txtbxPhoneNumber.Location = new System.Drawing.Point(12, 103);
            this.txtbxPhoneNumber.Name = "txtbxPhoneNumber";
            this.txtbxPhoneNumber.ReadOnly = true;
            this.txtbxPhoneNumber.Size = new System.Drawing.Size(260, 20);
            this.txtbxPhoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // frmListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtbxPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxEMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label1);
            this.Name = "frmListForm";
            this.Text = "List Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtbxName;
        public System.Windows.Forms.TextBox txtbxEMail;
        public System.Windows.Forms.TextBox txtbxPhoneNumber;
    }
}