namespace Library.Presentation.LoanForms
{
    partial class ListOfLoansForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.LoansListBox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShowActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.NumberOfActiveLoansLabel = new System.Windows.Forms.Label();
            this.SeacrhLabel = new System.Windows.Forms.Label();
            this.StudentClassLabel = new System.Windows.Forms.Label();
            this.StudentClassComboBox = new System.Windows.Forms.ComboBox();
            this.TipLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(582, 437);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 34);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(325, 438);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 34);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete Loan";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(178, 438);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(95, 33);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit Loan";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(45, 440);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(95, 31);
            this.DetailsButton.TabIndex = 8;
            this.DetailsButton.Text = "Loan Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.Details);
            // 
            // LoansListBox
            // 
            this.LoansListBox.FormattingEnabled = true;
            this.LoansListBox.Location = new System.Drawing.Point(33, 77);
            this.LoansListBox.Name = "LoansListBox";
            this.LoansListBox.Size = new System.Drawing.Size(350, 342);
            this.LoansListBox.TabIndex = 7;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(272, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(247, 46);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "List of Loans";
            // 
            // ShowActiveCheckBox
            // 
            this.ShowActiveCheckBox.AutoSize = true;
            this.ShowActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ShowActiveCheckBox.Location = new System.Drawing.Point(529, 113);
            this.ShowActiveCheckBox.Name = "ShowActiveCheckBox";
            this.ShowActiveCheckBox.Size = new System.Drawing.Size(198, 24);
            this.ShowActiveCheckBox.TabIndex = 12;
            this.ShowActiveCheckBox.Text = "Show Only Active Loans";
            this.ShowActiveCheckBox.UseVisualStyleBackColor = true;
            this.ShowActiveCheckBox.CheckedChanged += new System.EventHandler(this.ShowActiveCheck);
            // 
            // NumberOfActiveLoansLabel
            // 
            this.NumberOfActiveLoansLabel.AutoSize = true;
            this.NumberOfActiveLoansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfActiveLoansLabel.Location = new System.Drawing.Point(502, 86);
            this.NumberOfActiveLoansLabel.Name = "NumberOfActiveLoansLabel";
            this.NumberOfActiveLoansLabel.Size = new System.Drawing.Size(225, 24);
            this.NumberOfActiveLoansLabel.TabIndex = 13;
            this.NumberOfActiveLoansLabel.Text = "Number Of Active Loans: ";
            // 
            // SeacrhLabel
            // 
            this.SeacrhLabel.AutoSize = true;
            this.SeacrhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SeacrhLabel.Location = new System.Drawing.Point(549, 176);
            this.SeacrhLabel.Name = "SeacrhLabel";
            this.SeacrhLabel.Size = new System.Drawing.Size(70, 24);
            this.SeacrhLabel.TabIndex = 50;
            this.SeacrhLabel.Text = "Search";
            // 
            // StudentClassLabel
            // 
            this.StudentClassLabel.AutoSize = true;
            this.StudentClassLabel.Location = new System.Drawing.Point(423, 295);
            this.StudentClassLabel.Name = "StudentClassLabel";
            this.StudentClassLabel.Size = new System.Drawing.Size(79, 13);
            this.StudentClassLabel.TabIndex = 49;
            this.StudentClassLabel.Text = "Student\'s Class";
            // 
            // StudentClassComboBox
            // 
            this.StudentClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentClassComboBox.FormattingEnabled = true;
            this.StudentClassComboBox.Location = new System.Drawing.Point(525, 288);
            this.StudentClassComboBox.Name = "StudentClassComboBox";
            this.StudentClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.StudentClassComboBox.TabIndex = 48;
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(441, 375);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(308, 13);
            this.TipLabel.TabIndex = 47;
            this.TipLabel.Text = "*All are optional and used only for searching through the loan list";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(420, 251);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(99, 13);
            this.LastNameLabel.TabIndex = 46;
            this.LastNameLabel.Text = "Student\'s last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(420, 210);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(99, 13);
            this.FirstNameLabel.TabIndex = 45;
            this.FirstNameLabel.Text = "Student\'s first name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(674, 265);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 44;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(525, 248);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.LastNameTextBox.TabIndex = 43;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(525, 207);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.FirstNameTextBox.TabIndex = 42;
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPictureBox.Location = new System.Drawing.Point(404, 167);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(384, 238);
            this.SearchPictureBox.TabIndex = 41;
            this.SearchPictureBox.TabStop = false;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(426, 336);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(63, 13);
            this.BookNameLabel.TabIndex = 51;
            this.BookNameLabel.Text = "Book Name";
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(525, 328);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.BookNameTextBox.TabIndex = 52;
            // 
            // ListOfLoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.SeacrhLabel);
            this.Controls.Add(this.StudentClassLabel);
            this.Controls.Add(this.StudentClassComboBox);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.NumberOfActiveLoansLabel);
            this.Controls.Add(this.ShowActiveCheckBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.LoansListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ListOfLoansForm";
            this.Text = "ListOfLoansForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.ListBox LoansListBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.CheckBox ShowActiveCheckBox;
        private System.Windows.Forms.Label NumberOfActiveLoansLabel;
        private System.Windows.Forms.Label SeacrhLabel;
        private System.Windows.Forms.Label StudentClassLabel;
        private System.Windows.Forms.ComboBox StudentClassComboBox;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.TextBox BookNameTextBox;
    }
}