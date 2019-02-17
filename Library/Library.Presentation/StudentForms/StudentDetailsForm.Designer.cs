namespace Library.Presentation.StudentForms
{
    partial class StudentDetailsForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.NumberOfActiveLoansLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(238, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(290, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Student Details";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FirstNameLabel.Location = new System.Drawing.Point(15, 100);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(111, 24);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name: ";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LastNameLabel.Location = new System.Drawing.Point(15, 149);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(109, 24);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name: ";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DateOfBirthLabel.Location = new System.Drawing.Point(15, 200);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(124, 24);
            this.DateOfBirthLabel.TabIndex = 3;
            this.DateOfBirthLabel.Text = "Date Of Birth: ";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GenderLabel.Location = new System.Drawing.Point(15, 244);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(84, 24);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Gender: ";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClassLabel.Location = new System.Drawing.Point(15, 287);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(65, 24);
            this.ClassLabel.TabIndex = 5;
            this.ClassLabel.Text = "Class: ";
            // 
            // NumberOfActiveLoansLabel
            // 
            this.NumberOfActiveLoansLabel.AutoSize = true;
            this.NumberOfActiveLoansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfActiveLoansLabel.Location = new System.Drawing.Point(426, 100);
            this.NumberOfActiveLoansLabel.Name = "NumberOfActiveLoansLabel";
            this.NumberOfActiveLoansLabel.Size = new System.Drawing.Size(220, 24);
            this.NumberOfActiveLoansLabel.TabIndex = 6;
            this.NumberOfActiveLoansLabel.Text = "Number Of Active Loans:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(554, 339);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(92, 38);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(445, 339);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(85, 38);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit);
            // 
            // StudentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NumberOfActiveLoansLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "StudentDetailsForm";
            this.Text = "StudentDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label NumberOfActiveLoansLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button EditButton;
    }
}