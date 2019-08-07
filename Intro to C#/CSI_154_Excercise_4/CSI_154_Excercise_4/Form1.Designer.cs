namespace CSI_154_Excercise_4
{
    partial class frmFiftyValues
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
            this.components = new System.ComponentModel.Container();
            this.tmrDisplayValues = new System.Windows.Forms.Timer(this.components);
            this.lstbxDisplayValues = new System.Windows.Forms.ListBox();
            this.btnDisplayValues = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrDisplayValues
            // 
            this.tmrDisplayValues.Tick += new System.EventHandler(this.tmrDisplayValues_Tick);
            // 
            // lstbxDisplayValues
            // 
            this.lstbxDisplayValues.FormattingEnabled = true;
            this.lstbxDisplayValues.Location = new System.Drawing.Point(12, 70);
            this.lstbxDisplayValues.Name = "lstbxDisplayValues";
            this.lstbxDisplayValues.Size = new System.Drawing.Size(423, 173);
            this.lstbxDisplayValues.TabIndex = 0;
            // 
            // btnDisplayValues
            // 
            this.btnDisplayValues.Location = new System.Drawing.Point(12, 12);
            this.btnDisplayValues.Name = "btnDisplayValues";
            this.btnDisplayValues.Size = new System.Drawing.Size(157, 52);
            this.btnDisplayValues.TabIndex = 1;
            this.btnDisplayValues.Text = "Display Values";
            this.btnDisplayValues.UseVisualStyleBackColor = true;
            this.btnDisplayValues.Click += new System.EventHandler(this.btnDisplayValues_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(175, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(278, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(157, 52);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmFiftyValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 255);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnDisplayValues);
            this.Controls.Add(this.lstbxDisplayValues);
            this.Name = "frmFiftyValues";
            this.Text = "50 Values";
            this.Load += new System.EventHandler(this.frmFiftyValues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrDisplayValues;
        private System.Windows.Forms.ListBox lstbxDisplayValues;
        private System.Windows.Forms.Button btnDisplayValues;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnStop;
    }
}

