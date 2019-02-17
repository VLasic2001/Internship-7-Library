namespace Library.Presentation.LoanForms
{
    partial class AddLoanForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectedBookLabel = new System.Windows.Forms.Label();
            this.SelectBookButton = new System.Windows.Forms.Button();
            this.SelectStudentButton = new System.Windows.Forms.Button();
            this.SelectedStudentLabel = new System.Windows.Forms.Label();
            this.LoanDateLabel = new System.Windows.Forms.Label();
            this.LoanDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IsBookReturnedCheckBox = new System.Windows.Forms.CheckBox();
            this.ReturnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(88, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(191, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Add Loan";
            // 
            // SelectedBookLabel
            // 
            this.SelectedBookLabel.AutoSize = true;
            this.SelectedBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SelectedBookLabel.Location = new System.Drawing.Point(160, 80);
            this.SelectedBookLabel.Name = "SelectedBookLabel";
            this.SelectedBookLabel.Size = new System.Drawing.Size(162, 24);
            this.SelectedBookLabel.TabIndex = 1;
            this.SelectedBookLabel.Text = "No Book Selected";
            // 
            // SelectBookButton
            // 
            this.SelectBookButton.Location = new System.Drawing.Point(37, 77);
            this.SelectBookButton.Name = "SelectBookButton";
            this.SelectBookButton.Size = new System.Drawing.Size(106, 34);
            this.SelectBookButton.TabIndex = 2;
            this.SelectBookButton.Text = "Selected Book:";
            this.SelectBookButton.UseVisualStyleBackColor = true;
            this.SelectBookButton.Click += new System.EventHandler(this.SelectBook);
            // 
            // SelectStudentButton
            // 
            this.SelectStudentButton.Location = new System.Drawing.Point(37, 129);
            this.SelectStudentButton.Name = "SelectStudentButton";
            this.SelectStudentButton.Size = new System.Drawing.Size(106, 34);
            this.SelectStudentButton.TabIndex = 4;
            this.SelectStudentButton.Text = "Selected Student:";
            this.SelectStudentButton.UseVisualStyleBackColor = true;
            this.SelectStudentButton.Click += new System.EventHandler(this.SelectStudent);
            // 
            // SelectedStudentLabel
            // 
            this.SelectedStudentLabel.AutoSize = true;
            this.SelectedStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SelectedStudentLabel.Location = new System.Drawing.Point(160, 132);
            this.SelectedStudentLabel.Name = "SelectedStudentLabel";
            this.SelectedStudentLabel.Size = new System.Drawing.Size(183, 24);
            this.SelectedStudentLabel.TabIndex = 3;
            this.SelectedStudentLabel.Text = "No Student Selected";
            // 
            // LoanDateLabel
            // 
            this.LoanDateLabel.AutoSize = true;
            this.LoanDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoanDateLabel.Location = new System.Drawing.Point(43, 188);
            this.LoanDateLabel.Name = "LoanDateLabel";
            this.LoanDateLabel.Size = new System.Drawing.Size(100, 24);
            this.LoanDateLabel.TabIndex = 5;
            this.LoanDateLabel.Text = "Loan Date:";
            // 
            // LoanDateDateTimePicker
            // 
            this.LoanDateDateTimePicker.Location = new System.Drawing.Point(164, 191);
            this.LoanDateDateTimePicker.Name = "LoanDateDateTimePicker";
            this.LoanDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.LoanDateDateTimePicker.TabIndex = 6;
            // 
            // IsBookReturnedCheckBox
            // 
            this.IsBookReturnedCheckBox.AutoSize = true;
            this.IsBookReturnedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IsBookReturnedCheckBox.Location = new System.Drawing.Point(47, 234);
            this.IsBookReturnedCheckBox.Name = "IsBookReturnedCheckBox";
            this.IsBookReturnedCheckBox.Size = new System.Drawing.Size(212, 28);
            this.IsBookReturnedCheckBox.TabIndex = 7;
            this.IsBookReturnedCheckBox.Text = "Is The Book Returned";
            this.IsBookReturnedCheckBox.UseVisualStyleBackColor = true;
            this.IsBookReturnedCheckBox.CheckedChanged += new System.EventHandler(this.IsBookReturnedCheck);
            // 
            // ReturnDateDateTimePicker
            // 
            this.ReturnDateDateTimePicker.Enabled = false;
            this.ReturnDateDateTimePicker.Location = new System.Drawing.Point(164, 286);
            this.ReturnDateDateTimePicker.Name = "ReturnDateDateTimePicker";
            this.ReturnDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ReturnDateDateTimePicker.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(190, 328);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(102, 34);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(67, 329);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(102, 33);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ReturnDateLabel.Location = new System.Drawing.Point(44, 282);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(114, 24);
            this.ReturnDateLabel.TabIndex = 13;
            this.ReturnDateLabel.Text = "Return Date:";
            // 
            // AddLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 374);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReturnDateDateTimePicker);
            this.Controls.Add(this.IsBookReturnedCheckBox);
            this.Controls.Add(this.LoanDateDateTimePicker);
            this.Controls.Add(this.LoanDateLabel);
            this.Controls.Add(this.SelectStudentButton);
            this.Controls.Add(this.SelectedStudentLabel);
            this.Controls.Add(this.SelectBookButton);
            this.Controls.Add(this.SelectedBookLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddLoanForm";
            this.Text = "Add Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SelectedBookLabel;
        private System.Windows.Forms.Button SelectBookButton;
        private System.Windows.Forms.Button SelectStudentButton;
        private System.Windows.Forms.Label SelectedStudentLabel;
        private System.Windows.Forms.Label LoanDateLabel;
        private System.Windows.Forms.DateTimePicker LoanDateDateTimePicker;
        private System.Windows.Forms.CheckBox IsBookReturnedCheckBox;
        private System.Windows.Forms.DateTimePicker ReturnDateDateTimePicker;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ReturnDateLabel;
    }
}