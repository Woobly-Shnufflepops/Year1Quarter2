﻿namespace ReferenceParameters
{
    partial class refParam
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
            this.runApp = new System.Windows.Forms.Button();
            this.txtBoxRefParam = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // runApp
            // 
            this.runApp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runApp.Location = new System.Drawing.Point(109, 231);
            this.runApp.Name = "runApp";
            this.runApp.Size = new System.Drawing.Size(313, 81);
            this.runApp.TabIndex = 0;
            this.runApp.Text = "Run Application";
            this.runApp.UseVisualStyleBackColor = true;
            this.runApp.Click += new System.EventHandler(this.runApp_Click);
            // 
            // txtBoxRefParam
            // 
            this.txtBoxRefParam.Location = new System.Drawing.Point(83, 44);
            this.txtBoxRefParam.Name = "txtBoxRefParam";
            this.txtBoxRefParam.Size = new System.Drawing.Size(364, 120);
            this.txtBoxRefParam.TabIndex = 1;
            this.txtBoxRefParam.Text = "";
            // 
            // refParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 371);
            this.Controls.Add(this.txtBoxRefParam);
            this.Controls.Add(this.runApp);
            this.Name = "refParam";
            this.Text = "Reference Parameter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runApp;
        private System.Windows.Forms.RichTextBox txtBoxRefParam;
    }
}

