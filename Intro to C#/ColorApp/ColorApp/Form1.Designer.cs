namespace ColorApp
{
    partial class colorApplicationBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colorApplicationBox));
            this.runButton = new System.Windows.Forms.Button();
            this.colorAppTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // runButton
            // 
            resources.ApplyResources(this.runButton, "runButton");
            this.runButton.Name = "runButton";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // colorAppTextBox
            // 
            resources.ApplyResources(this.colorAppTextBox, "colorAppTextBox");
            this.colorAppTextBox.Name = "colorAppTextBox";
            // 
            // colorApplicationBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorAppTextBox);
            this.Controls.Add(this.runButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "colorApplicationBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.RichTextBox colorAppTextBox;
    }
}

