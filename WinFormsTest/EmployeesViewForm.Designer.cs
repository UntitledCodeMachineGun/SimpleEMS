namespace WinFormsTest
{
    partial class EmployeesViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmpGridView = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FiltersBox = new System.Windows.Forms.GroupBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.ByFatherFilterLabel = new System.Windows.Forms.Label();
            this.FilterByFatherCombo = new System.Windows.Forms.ComboBox();
            this.BySurnameFilterLabel = new System.Windows.Forms.Label();
            this.FilterBySurnameCombo = new System.Windows.Forms.ComboBox();
            this.FilterByNameCombo = new System.Windows.Forms.ComboBox();
            this.ByNameFilterLabel = new System.Windows.Forms.Label();
            this.ByDeptFilterLabel = new System.Windows.Forms.Label();
            this.FilterByDeptCombo = new System.Windows.Forms.ComboBox();
            this.ByPosFilterLabel = new System.Windows.Forms.Label();
            this.FilterByPosCombo = new System.Windows.Forms.ComboBox();
            this.ClearFiltersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            this.FiltersBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpGridView
            // 
            this.EmpGridView.AllowUserToAddRows = false;
            this.EmpGridView.AllowUserToDeleteRows = false;
            this.EmpGridView.AllowUserToOrderColumns = true;
            this.EmpGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.EmpGridView.Location = new System.Drawing.Point(12, 86);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.ReadOnly = true;
            this.EmpGridView.RowTemplate.Height = 25;
            this.EmpGridView.Size = new System.Drawing.Size(776, 352);
            this.EmpGridView.TabIndex = 0;
            this.EmpGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGridView_CellContentClick);
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // FiltersBox
            // 
            this.FiltersBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersBox.Controls.Add(this.ClearFiltersBtn);
            this.FiltersBox.Controls.Add(this.FilterBtn);
            this.FiltersBox.Controls.Add(this.ByFatherFilterLabel);
            this.FiltersBox.Controls.Add(this.FilterByFatherCombo);
            this.FiltersBox.Controls.Add(this.BySurnameFilterLabel);
            this.FiltersBox.Controls.Add(this.FilterBySurnameCombo);
            this.FiltersBox.Controls.Add(this.FilterByNameCombo);
            this.FiltersBox.Controls.Add(this.ByNameFilterLabel);
            this.FiltersBox.Controls.Add(this.ByDeptFilterLabel);
            this.FiltersBox.Controls.Add(this.FilterByDeptCombo);
            this.FiltersBox.Controls.Add(this.ByPosFilterLabel);
            this.FiltersBox.Controls.Add(this.FilterByPosCombo);
            this.FiltersBox.Location = new System.Drawing.Point(12, 8);
            this.FiltersBox.Name = "FiltersBox";
            this.FiltersBox.Size = new System.Drawing.Size(776, 72);
            this.FiltersBox.TabIndex = 1;
            this.FiltersBox.TabStop = false;
            this.FiltersBox.Text = "Filters";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(641, 43);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(129, 22);
            this.FilterBtn.TabIndex = 10;
            this.FilterBtn.Text = "Find";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // ByFatherFilterLabel
            // 
            this.ByFatherFilterLabel.AutoSize = true;
            this.ByFatherFilterLabel.Location = new System.Drawing.Point(514, 19);
            this.ByFatherFilterLabel.Name = "ByFatherFilterLabel";
            this.ByFatherFilterLabel.Size = new System.Drawing.Size(84, 15);
            this.ByFatherFilterLabel.TabIndex = 9;
            this.ByFatherFilterLabel.Text = "By fathername";
            // 
            // FilterByFatherCombo
            // 
            this.FilterByFatherCombo.FormattingEnabled = true;
            this.FilterByFatherCombo.Location = new System.Drawing.Point(514, 43);
            this.FilterByFatherCombo.Name = "FilterByFatherCombo";
            this.FilterByFatherCombo.Size = new System.Drawing.Size(121, 23);
            this.FilterByFatherCombo.TabIndex = 8;
            // 
            // BySurnameFilterLabel
            // 
            this.BySurnameFilterLabel.AutoSize = true;
            this.BySurnameFilterLabel.Location = new System.Drawing.Point(387, 19);
            this.BySurnameFilterLabel.Name = "BySurnameFilterLabel";
            this.BySurnameFilterLabel.Size = new System.Drawing.Size(69, 15);
            this.BySurnameFilterLabel.TabIndex = 7;
            this.BySurnameFilterLabel.Text = "By surname";
            // 
            // FilterBySurnameCombo
            // 
            this.FilterBySurnameCombo.FormattingEnabled = true;
            this.FilterBySurnameCombo.Location = new System.Drawing.Point(387, 43);
            this.FilterBySurnameCombo.Name = "FilterBySurnameCombo";
            this.FilterBySurnameCombo.Size = new System.Drawing.Size(121, 23);
            this.FilterBySurnameCombo.TabIndex = 6;
            // 
            // FilterByNameCombo
            // 
            this.FilterByNameCombo.FormattingEnabled = true;
            this.FilterByNameCombo.Location = new System.Drawing.Point(260, 43);
            this.FilterByNameCombo.Name = "FilterByNameCombo";
            this.FilterByNameCombo.Size = new System.Drawing.Size(121, 23);
            this.FilterByNameCombo.TabIndex = 5;
            // 
            // ByNameFilterLabel
            // 
            this.ByNameFilterLabel.AutoSize = true;
            this.ByNameFilterLabel.Location = new System.Drawing.Point(260, 19);
            this.ByNameFilterLabel.Name = "ByNameFilterLabel";
            this.ByNameFilterLabel.Size = new System.Drawing.Size(53, 15);
            this.ByNameFilterLabel.TabIndex = 4;
            this.ByNameFilterLabel.Text = "By name";
            // 
            // ByDeptFilterLabel
            // 
            this.ByDeptFilterLabel.AutoSize = true;
            this.ByDeptFilterLabel.Location = new System.Drawing.Point(133, 19);
            this.ByDeptFilterLabel.Name = "ByDeptFilterLabel";
            this.ByDeptFilterLabel.Size = new System.Drawing.Size(85, 15);
            this.ByDeptFilterLabel.TabIndex = 3;
            this.ByDeptFilterLabel.Text = "By department";
            // 
            // FilterByDeptCombo
            // 
            this.FilterByDeptCombo.FormattingEnabled = true;
            this.FilterByDeptCombo.Location = new System.Drawing.Point(133, 43);
            this.FilterByDeptCombo.Name = "FilterByDeptCombo";
            this.FilterByDeptCombo.Size = new System.Drawing.Size(121, 23);
            this.FilterByDeptCombo.TabIndex = 2;
            // 
            // ByPosFilterLabel
            // 
            this.ByPosFilterLabel.AutoSize = true;
            this.ByPosFilterLabel.Location = new System.Drawing.Point(6, 19);
            this.ByPosFilterLabel.Name = "ByPosFilterLabel";
            this.ByPosFilterLabel.Size = new System.Drawing.Size(66, 15);
            this.ByPosFilterLabel.TabIndex = 1;
            this.ByPosFilterLabel.Text = "By position";
            // 
            // FilterByPosCombo
            // 
            this.FilterByPosCombo.FormattingEnabled = true;
            this.FilterByPosCombo.Location = new System.Drawing.Point(6, 43);
            this.FilterByPosCombo.Name = "FilterByPosCombo";
            this.FilterByPosCombo.Size = new System.Drawing.Size(121, 23);
            this.FilterByPosCombo.TabIndex = 0;
            // 
            // ClearFiltersBtn
            // 
            this.ClearFiltersBtn.Location = new System.Drawing.Point(641, 19);
            this.ClearFiltersBtn.Name = "ClearFiltersBtn";
            this.ClearFiltersBtn.Size = new System.Drawing.Size(129, 23);
            this.ClearFiltersBtn.TabIndex = 11;
            this.ClearFiltersBtn.Text = "Clear";
            this.ClearFiltersBtn.UseVisualStyleBackColor = true;
            this.ClearFiltersBtn.Click += new System.EventHandler(this.ClearFiltersBtn_Click);
            // 
            // EmployeesViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FiltersBox);
            this.Controls.Add(this.EmpGridView);
            this.Name = "EmployeesViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees View";
            this.Activated += new System.EventHandler(this.EmployeesViewForm_Activated);
            this.Load += new System.EventHandler(this.EmployeesViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            this.FiltersBox.ResumeLayout(false);
            this.FiltersBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView EmpGridView;
        private GroupBox FiltersBox;
        private Button FilterBtn;
        private Label ByFatherFilterLabel;
        private ComboBox FilterByFatherCombo;
        private Label BySurnameFilterLabel;
        private ComboBox FilterBySurnameCombo;
        private ComboBox FilterByNameCombo;
        private Label ByNameFilterLabel;
        private Label ByDeptFilterLabel;
        private ComboBox FilterByDeptCombo;
        private Label ByPosFilterLabel;
        private ComboBox FilterByPosCombo;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button ClearFiltersBtn;
    }
}