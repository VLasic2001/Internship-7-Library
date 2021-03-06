﻿namespace Library.Presentation.BookForms
{
    partial class BookDetailsForm
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
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.NumberOfPagesLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NumberOfLibrarysCopiesLabel = new System.Windows.Forms.Label();
            this.NumberOfAvailableCopiesLabel = new System.Windows.Forms.Label();
            this.NumberOfLoanedCopiesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(233, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(246, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Book Details";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BookNameLabel.Location = new System.Drawing.Point(48, 93);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(119, 24);
            this.BookNameLabel.TabIndex = 1;
            this.BookNameLabel.Text = "Book Name: ";
            // 
            // NumberOfPagesLabel
            // 
            this.NumberOfPagesLabel.AutoSize = true;
            this.NumberOfPagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfPagesLabel.Location = new System.Drawing.Point(48, 135);
            this.NumberOfPagesLabel.Name = "NumberOfPagesLabel";
            this.NumberOfPagesLabel.Size = new System.Drawing.Size(171, 24);
            this.NumberOfPagesLabel.TabIndex = 2;
            this.NumberOfPagesLabel.Text = "Number Of Pages: ";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GenreLabel.Location = new System.Drawing.Point(48, 176);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(73, 24);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre: ";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AuthorLabel.Location = new System.Drawing.Point(48, 258);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(76, 24);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author: ";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PublisherLabel.Location = new System.Drawing.Point(48, 299);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(99, 24);
            this.PublisherLabel.TabIndex = 5;
            this.PublisherLabel.Text = "Publisher: ";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(441, 252);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 40);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit Book";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(556, 252);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 40);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // NumberOfLibrarysCopiesLabel
            // 
            this.NumberOfLibrarysCopiesLabel.AutoSize = true;
            this.NumberOfLibrarysCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfLibrarysCopiesLabel.Location = new System.Drawing.Point(48, 216);
            this.NumberOfLibrarysCopiesLabel.Name = "NumberOfLibrarysCopiesLabel";
            this.NumberOfLibrarysCopiesLabel.Size = new System.Drawing.Size(251, 24);
            this.NumberOfLibrarysCopiesLabel.TabIndex = 8;
            this.NumberOfLibrarysCopiesLabel.Text = "Number Of Library\'s Copies: ";
            // 
            // NumberOfAvailableCopiesLabel
            // 
            this.NumberOfAvailableCopiesLabel.AutoSize = true;
            this.NumberOfAvailableCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfAvailableCopiesLabel.Location = new System.Drawing.Point(431, 93);
            this.NumberOfAvailableCopiesLabel.Name = "NumberOfAvailableCopiesLabel";
            this.NumberOfAvailableCopiesLabel.Size = new System.Drawing.Size(253, 24);
            this.NumberOfAvailableCopiesLabel.TabIndex = 9;
            this.NumberOfAvailableCopiesLabel.Text = "Number Of Available Copies:";
            // 
            // NumberOfLoanedCopiesLabel
            // 
            this.NumberOfLoanedCopiesLabel.AutoSize = true;
            this.NumberOfLoanedCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfLoanedCopiesLabel.Location = new System.Drawing.Point(431, 135);
            this.NumberOfLoanedCopiesLabel.Name = "NumberOfLoanedCopiesLabel";
            this.NumberOfLoanedCopiesLabel.Size = new System.Drawing.Size(241, 24);
            this.NumberOfLoanedCopiesLabel.TabIndex = 10;
            this.NumberOfLoanedCopiesLabel.Text = "Number Of Loaned Copies:";
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 350);
            this.Controls.Add(this.NumberOfLoanedCopiesLabel);
            this.Controls.Add(this.NumberOfAvailableCopiesLabel);
            this.Controls.Add(this.NumberOfLibrarysCopiesLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.NumberOfPagesLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "BookDetailsForm";
            this.Text = "BookDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label NumberOfPagesLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label NumberOfLibrarysCopiesLabel;
        private System.Windows.Forms.Label NumberOfAvailableCopiesLabel;
        private System.Windows.Forms.Label NumberOfLoanedCopiesLabel;
    }
}