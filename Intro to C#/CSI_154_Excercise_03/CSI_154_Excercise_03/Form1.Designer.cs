namespace CSI_154_Excercise_03
{
    partial class frmStudentNames
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
            this.lstbxDisplay = new System.Windows.Forms.ListBox();
            this.btnDisplayNames = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnInsertName = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.txtbxAddName = new System.Windows.Forms.TextBox();
            this.txtbxInsertName = new System.Windows.Forms.TextBox();
            this.txtbxRemoveName = new System.Windows.Forms.TextBox();
            this.txtbxSearchName = new System.Windows.Forms.TextBox();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.txtbxInsertLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxDisplay
            // 
            this.lstbxDisplay.FormattingEnabled = true;
            this.lstbxDisplay.Location = new System.Drawing.Point(205, 12);
            this.lstbxDisplay.Name = "lstbxDisplay";
            this.lstbxDisplay.Size = new System.Drawing.Size(300, 524);
            this.lstbxDisplay.TabIndex = 0;
            // 
            // btnDisplayNames
            // 
            this.btnDisplayNames.Location = new System.Drawing.Point(12, 12);
            this.btnDisplayNames.Name = "btnDisplayNames";
            this.btnDisplayNames.Size = new System.Drawing.Size(187, 56);
            this.btnDisplayNames.TabIndex = 1;
            this.btnDisplayNames.Text = "Display Names";
            this.btnDisplayNames.UseVisualStyleBackColor = true;
            this.btnDisplayNames.Click += new System.EventHandler(this.btnDisplayNames_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 74);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(187, 56);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "Add a name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnInsertName
            // 
            this.btnInsertName.Location = new System.Drawing.Point(12, 162);
            this.btnInsertName.Name = "btnInsertName";
            this.btnInsertName.Size = new System.Drawing.Size(187, 56);
            this.btnInsertName.TabIndex = 3;
            this.btnInsertName.Text = "Insert a name at an index";
            this.btnInsertName.UseVisualStyleBackColor = true;
            this.btnInsertName.Click += new System.EventHandler(this.btnInsertName_Click);
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(12, 310);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(187, 56);
            this.btnRemoveName.TabIndex = 4;
            this.btnRemoveName.Text = "Remove a name";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(12, 398);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(187, 56);
            this.btnSearchName.TabIndex = 5;
            this.btnSearchName.Text = "Search for a Name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Location = new System.Drawing.Point(12, 486);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(187, 56);
            this.btnSortAscending.TabIndex = 6;
            this.btnSortAscending.Text = "Sort Ascending";
            this.btnSortAscending.UseVisualStyleBackColor = true;
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
            // 
            // txtbxAddName
            // 
            this.txtbxAddName.Location = new System.Drawing.Point(12, 136);
            this.txtbxAddName.Name = "txtbxAddName";
            this.txtbxAddName.Size = new System.Drawing.Size(187, 20);
            this.txtbxAddName.TabIndex = 7;
            // 
            // txtbxInsertName
            // 
            this.txtbxInsertName.Location = new System.Drawing.Point(12, 284);
            this.txtbxInsertName.Name = "txtbxInsertName";
            this.txtbxInsertName.Size = new System.Drawing.Size(187, 20);
            this.txtbxInsertName.TabIndex = 8;
            // 
            // txtbxRemoveName
            // 
            this.txtbxRemoveName.Location = new System.Drawing.Point(12, 372);
            this.txtbxRemoveName.Name = "txtbxRemoveName";
            this.txtbxRemoveName.Size = new System.Drawing.Size(187, 20);
            this.txtbxRemoveName.TabIndex = 9;
            // 
            // txtbxSearchName
            // 
            this.txtbxSearchName.Location = new System.Drawing.Point(12, 460);
            this.txtbxSearchName.Name = "txtbxSearchName";
            this.txtbxSearchName.Size = new System.Drawing.Size(187, 20);
            this.txtbxSearchName.TabIndex = 10;
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Location = new System.Drawing.Point(12, 548);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(187, 56);
            this.btnSortDescending.TabIndex = 11;
            this.btnSortDescending.Text = "Sort Descending";
            this.btnSortDescending.UseVisualStyleBackColor = true;
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // txtbxInsertLocation
            // 
            this.txtbxInsertLocation.Location = new System.Drawing.Point(12, 242);
            this.txtbxInsertLocation.Name = "txtbxInsertLocation";
            this.txtbxInsertLocation.Size = new System.Drawing.Size(187, 20);
            this.txtbxInsertLocation.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Insert Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name Insert";
            // 
            // frmStudentNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxInsertLocation);
            this.Controls.Add(this.btnSortDescending);
            this.Controls.Add(this.txtbxSearchName);
            this.Controls.Add(this.txtbxRemoveName);
            this.Controls.Add(this.txtbxInsertName);
            this.Controls.Add(this.txtbxAddName);
            this.Controls.Add(this.btnSortAscending);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.btnRemoveName);
            this.Controls.Add(this.btnInsertName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.btnDisplayNames);
            this.Controls.Add(this.lstbxDisplay);
            this.Name = "frmStudentNames";
            this.Text = "Student Names";
            this.Load += new System.EventHandler(this.frmStudentNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxDisplay;
        private System.Windows.Forms.Button btnDisplayNames;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnInsertName;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.TextBox txtbxAddName;
        private System.Windows.Forms.TextBox txtbxInsertName;
        private System.Windows.Forms.TextBox txtbxRemoveName;
        private System.Windows.Forms.TextBox txtbxSearchName;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.TextBox txtbxInsertLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

