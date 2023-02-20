namespace WinFormsTest
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompanyInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.ShowEmpBtn = new System.Windows.Forms.Button();
            this.AddNewEmpBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.AddNewDeptBtn = new System.Windows.Forms.Button();
            this.AddNewPosBtn = new System.Windows.Forms.Button();
            this.CompanyInfoEditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyInfoTextBox
            // 
            this.CompanyInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyInfoTextBox.Location = new System.Drawing.Point(386, 12);
            this.CompanyInfoTextBox.Name = "CompanyInfoTextBox";
            this.CompanyInfoTextBox.ReadOnly = true;
            this.CompanyInfoTextBox.Size = new System.Drawing.Size(402, 426);
            this.CompanyInfoTextBox.TabIndex = 0;
            this.CompanyInfoTextBox.Text = "";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompanyNameLabel.Location = new System.Drawing.Point(66, 33);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(254, 45);
            this.CompanyNameLabel.TabIndex = 1;
            this.CompanyNameLabel.Text = "Good Company";
            // 
            // ShowEmpBtn
            // 
            this.ShowEmpBtn.Location = new System.Drawing.Point(12, 110);
            this.ShowEmpBtn.Name = "ShowEmpBtn";
            this.ShowEmpBtn.Size = new System.Drawing.Size(368, 50);
            this.ShowEmpBtn.TabIndex = 2;
            this.ShowEmpBtn.Text = "Show employees";
            this.ShowEmpBtn.UseVisualStyleBackColor = true;
            this.ShowEmpBtn.Click += new System.EventHandler(this.ShowEmpBtn_Click);
            // 
            // AddNewEmpBtn
            // 
            this.AddNewEmpBtn.Location = new System.Drawing.Point(12, 222);
            this.AddNewEmpBtn.Name = "AddNewEmpBtn";
            this.AddNewEmpBtn.Size = new System.Drawing.Size(368, 50);
            this.AddNewEmpBtn.TabIndex = 3;
            this.AddNewEmpBtn.Text = "Add new employee";
            this.AddNewEmpBtn.UseVisualStyleBackColor = true;
            this.AddNewEmpBtn.Click += new System.EventHandler(this.AddNewEmpBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.Location = new System.Drawing.Point(12, 166);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(368, 50);
            this.ReportBtn.TabIndex = 4;
            this.ReportBtn.Text = "Salary report";
            this.ReportBtn.UseVisualStyleBackColor = true;
            // 
            // AddNewDeptBtn
            // 
            this.AddNewDeptBtn.Location = new System.Drawing.Point(12, 278);
            this.AddNewDeptBtn.Name = "AddNewDeptBtn";
            this.AddNewDeptBtn.Size = new System.Drawing.Size(368, 50);
            this.AddNewDeptBtn.TabIndex = 5;
            this.AddNewDeptBtn.Text = "Add new department";
            this.AddNewDeptBtn.UseVisualStyleBackColor = true;
            this.AddNewDeptBtn.Click += new System.EventHandler(this.AddNewDeptBtn_Click);
            // 
            // AddNewPosBtn
            // 
            this.AddNewPosBtn.Location = new System.Drawing.Point(12, 334);
            this.AddNewPosBtn.Name = "AddNewPosBtn";
            this.AddNewPosBtn.Size = new System.Drawing.Size(368, 50);
            this.AddNewPosBtn.TabIndex = 6;
            this.AddNewPosBtn.Text = "Add new position";
            this.AddNewPosBtn.UseVisualStyleBackColor = true;
            this.AddNewPosBtn.Click += new System.EventHandler(this.AddNewPosBtn_Click);
            // 
            // CompanyInfoEditBtn
            // 
            this.CompanyInfoEditBtn.Location = new System.Drawing.Point(12, 389);
            this.CompanyInfoEditBtn.Name = "CompanyInfoEditBtn";
            this.CompanyInfoEditBtn.Size = new System.Drawing.Size(368, 50);
            this.CompanyInfoEditBtn.TabIndex = 7;
            this.CompanyInfoEditBtn.Text = "Edit company info";
            this.CompanyInfoEditBtn.UseVisualStyleBackColor = true;
            this.CompanyInfoEditBtn.Click += new System.EventHandler(this.CompanyInfoEditBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompanyInfoEditBtn);
            this.Controls.Add(this.AddNewPosBtn);
            this.Controls.Add(this.AddNewDeptBtn);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.AddNewEmpBtn);
            this.Controls.Add(this.ShowEmpBtn);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.CompanyInfoTextBox);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.MenuForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox CompanyInfoTextBox;
        private Label CompanyNameLabel;
        private Button ShowEmpBtn;
        private Button AddNewEmpBtn;
        private Button ReportBtn;
        private Button AddNewDeptBtn;
        private Button AddNewPosBtn;
        private Button CompanyInfoEditBtn;
    }
}