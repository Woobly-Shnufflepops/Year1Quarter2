﻿namespace LabAssignment06True
{
    partial class frmMainMenu
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
            this.lstbxPeople = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbxPeople
            // 
            this.lstbxPeople.FormattingEnabled = true;
            this.lstbxPeople.Location = new System.Drawing.Point(12, 12);
            this.lstbxPeople.Name = "lstbxPeople";
            this.lstbxPeople.Size = new System.Drawing.Size(413, 186);
            this.lstbxPeople.TabIndex = 0;
            this.lstbxPeople.SelectedIndexChanged += new System.EventHandler(this.lstbxPeople_SelectedIndexChanged);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 365);
            this.Controls.Add(this.lstbxPeople);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxPeople;
    }
}

