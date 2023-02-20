namespace WinFormsTest
{
    partial class TextFieldAddForm
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
            this.MainText = new System.Windows.Forms.RichTextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.Location = new System.Drawing.Point(12, 73);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(646, 392);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 471);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(151, 38);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(507, 471);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(151, 38);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 23);
            this.NameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 55);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(28, 15);
            this.TextLabel.TabIndex = 5;
            this.TextLabel.Text = "Text";
            // 
            // TextFieldAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 521);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.MainText);
            this.Name = "TextFieldAddForm";
            this.Text = "Adding text field";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox MainText;
        private Button SaveBtn;
        private Button ClearBtn;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Label TextLabel;
    }
}