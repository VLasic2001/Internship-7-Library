namespace Library.Presentation
{
    partial class MenuForm
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
            this.AddBookButton = new System.Windows.Forms.Button();
            this.ListOfBooksButton = new System.Windows.Forms.Button();
            this.ListOfAuthorsButton = new System.Windows.Forms.Button();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.ListOfStudentsButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.ListOfPublishersButton = new System.Windows.Forms.Button();
            this.AddPublisherButton = new System.Windows.Forms.Button();
            this.ListOfLoansButton = new System.Windows.Forms.Button();
            this.AddLoanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(315, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(119, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Menu";
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(42, 123);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(102, 33);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBook);
            // 
            // ListOfBooksButton
            // 
            this.ListOfBooksButton.Location = new System.Drawing.Point(42, 163);
            this.ListOfBooksButton.Name = "ListOfBooksButton";
            this.ListOfBooksButton.Size = new System.Drawing.Size(102, 34);
            this.ListOfBooksButton.TabIndex = 2;
            this.ListOfBooksButton.Text = "List Of Books";
            this.ListOfBooksButton.UseVisualStyleBackColor = true;
            this.ListOfBooksButton.Click += new System.EventHandler(this.ListOfBooks);
            // 
            // ListOfAuthorsButton
            // 
            this.ListOfAuthorsButton.Location = new System.Drawing.Point(185, 163);
            this.ListOfAuthorsButton.Name = "ListOfAuthorsButton";
            this.ListOfAuthorsButton.Size = new System.Drawing.Size(102, 34);
            this.ListOfAuthorsButton.TabIndex = 4;
            this.ListOfAuthorsButton.Text = "List Of Authors";
            this.ListOfAuthorsButton.UseVisualStyleBackColor = true;
            this.ListOfAuthorsButton.Click += new System.EventHandler(this.ListOfAuthors);
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Location = new System.Drawing.Point(185, 123);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(102, 33);
            this.AddAuthorButton.TabIndex = 3;
            this.AddAuthorButton.Text = "Add Author";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthor);
            // 
            // ListOfStudentsButton
            // 
            this.ListOfStudentsButton.Location = new System.Drawing.Point(466, 163);
            this.ListOfStudentsButton.Name = "ListOfStudentsButton";
            this.ListOfStudentsButton.Size = new System.Drawing.Size(102, 34);
            this.ListOfStudentsButton.TabIndex = 8;
            this.ListOfStudentsButton.Text = "List Of Students";
            this.ListOfStudentsButton.UseVisualStyleBackColor = true;
            this.ListOfStudentsButton.Click += new System.EventHandler(this.ListOfStudents);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(466, 123);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(102, 33);
            this.AddStudentButton.TabIndex = 7;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudent);
            // 
            // ListOfPublishersButton
            // 
            this.ListOfPublishersButton.Location = new System.Drawing.Point(323, 163);
            this.ListOfPublishersButton.Name = "ListOfPublishersButton";
            this.ListOfPublishersButton.Size = new System.Drawing.Size(102, 34);
            this.ListOfPublishersButton.TabIndex = 6;
            this.ListOfPublishersButton.Text = "List Of Publishers";
            this.ListOfPublishersButton.UseVisualStyleBackColor = true;
            this.ListOfPublishersButton.Click += new System.EventHandler(this.ListOfPublishers);
            // 
            // AddPublisherButton
            // 
            this.AddPublisherButton.Location = new System.Drawing.Point(323, 123);
            this.AddPublisherButton.Name = "AddPublisherButton";
            this.AddPublisherButton.Size = new System.Drawing.Size(102, 33);
            this.AddPublisherButton.TabIndex = 5;
            this.AddPublisherButton.Text = "Add Publisher";
            this.AddPublisherButton.UseVisualStyleBackColor = true;
            this.AddPublisherButton.Click += new System.EventHandler(this.AddPublisher);
            // 
            // ListOfLoansButton
            // 
            this.ListOfLoansButton.Location = new System.Drawing.Point(611, 163);
            this.ListOfLoansButton.Name = "ListOfLoansButton";
            this.ListOfLoansButton.Size = new System.Drawing.Size(102, 34);
            this.ListOfLoansButton.TabIndex = 10;
            this.ListOfLoansButton.Text = "List Of Loans";
            this.ListOfLoansButton.UseVisualStyleBackColor = true;
            this.ListOfLoansButton.Click += new System.EventHandler(this.ListOfLoans);
            // 
            // AddLoanButton
            // 
            this.AddLoanButton.Location = new System.Drawing.Point(611, 123);
            this.AddLoanButton.Name = "AddLoanButton";
            this.AddLoanButton.Size = new System.Drawing.Size(102, 33);
            this.AddLoanButton.TabIndex = 9;
            this.AddLoanButton.Text = "Add Loan";
            this.AddLoanButton.UseVisualStyleBackColor = true;
            this.AddLoanButton.Click += new System.EventHandler(this.AddLoan);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListOfLoansButton);
            this.Controls.Add(this.AddLoanButton);
            this.Controls.Add(this.ListOfStudentsButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.ListOfPublishersButton);
            this.Controls.Add(this.AddPublisherButton);
            this.Controls.Add(this.ListOfAuthorsButton);
            this.Controls.Add(this.AddAuthorButton);
            this.Controls.Add(this.ListOfBooksButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button ListOfBooksButton;
        private System.Windows.Forms.Button ListOfAuthorsButton;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.Button ListOfStudentsButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button ListOfPublishersButton;
        private System.Windows.Forms.Button AddPublisherButton;
        private System.Windows.Forms.Button ListOfLoansButton;
        private System.Windows.Forms.Button AddLoanButton;
    }
}