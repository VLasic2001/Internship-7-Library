namespace Library.Presentation.BookForms
{
    partial class ListOfBooksForm
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
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NumberOfAvailableBooksLabel = new System.Windows.Forms.Label();
            this.TotalNumberOfBooksLabel = new System.Windows.Forms.Label();
            this.NumberOfLoanedBooks = new System.Windows.Forms.Label();
            this.TipLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(262, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(251, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "List of Books";
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(23, 77);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(362, 342);
            this.BooksListBox.TabIndex = 1;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(37, 441);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(95, 31);
            this.DetailsButton.TabIndex = 2;
            this.DetailsButton.Text = "Book Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.Details);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(153, 442);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(95, 33);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit Book";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(270, 441);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 34);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Book";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(551, 438);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 34);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // NumberOfAvailableBooksLabel
            // 
            this.NumberOfAvailableBooksLabel.AutoSize = true;
            this.NumberOfAvailableBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfAvailableBooksLabel.Location = new System.Drawing.Point(437, 307);
            this.NumberOfAvailableBooksLabel.Name = "NumberOfAvailableBooksLabel";
            this.NumberOfAvailableBooksLabel.Size = new System.Drawing.Size(251, 24);
            this.NumberOfAvailableBooksLabel.TabIndex = 15;
            this.NumberOfAvailableBooksLabel.Text = "Number Of Available Books: ";
            // 
            // TotalNumberOfBooksLabel
            // 
            this.TotalNumberOfBooksLabel.AutoSize = true;
            this.TotalNumberOfBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TotalNumberOfBooksLabel.Location = new System.Drawing.Point(437, 261);
            this.TotalNumberOfBooksLabel.Name = "TotalNumberOfBooksLabel";
            this.TotalNumberOfBooksLabel.Size = new System.Drawing.Size(290, 24);
            this.TotalNumberOfBooksLabel.TabIndex = 16;
            this.TotalNumberOfBooksLabel.Text = "Total Number Of Library\'s Books: ";
            // 
            // NumberOfLoanedBooks
            // 
            this.NumberOfLoanedBooks.AutoSize = true;
            this.NumberOfLoanedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfLoanedBooks.Location = new System.Drawing.Point(437, 354);
            this.NumberOfLoanedBooks.Name = "NumberOfLoanedBooks";
            this.NumberOfLoanedBooks.Size = new System.Drawing.Size(239, 24);
            this.NumberOfLoanedBooks.TabIndex = 17;
            this.NumberOfLoanedBooks.Text = "Number Of Loaned Books: ";
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(462, 200);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(282, 13);
            this.TipLabel.TabIndex = 29;
            this.TipLabel.Text = "*Optional and used only for searching through the book list";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(452, 166);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 28;
            this.NameLabel.Text = "Book name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(669, 156);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 27;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(537, 159);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 26;
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPictureBox.Location = new System.Drawing.Point(430, 103);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(334, 128);
            this.SearchPictureBox.TabIndex = 25;
            this.SearchPictureBox.TabStop = false;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SearchLabel.Location = new System.Drawing.Point(556, 113);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(70, 24);
            this.SearchLabel.TabIndex = 30;
            this.SearchLabel.Text = "Search";
            // 
            // ListOfBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.NumberOfLoanedBooks);
            this.Controls.Add(this.TotalNumberOfBooksLabel);
            this.Controls.Add(this.NumberOfAvailableBooksLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ListOfBooksForm";
            this.Text = "ListOfBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label NumberOfAvailableBooksLabel;
        private System.Windows.Forms.Label TotalNumberOfBooksLabel;
        private System.Windows.Forms.Label NumberOfLoanedBooks;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}