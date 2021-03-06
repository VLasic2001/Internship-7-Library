﻿namespace Library.Presentation.AuthorForms
{
    partial class AuthorDetailsForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BooksLabel = new System.Windows.Forms.Label();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(172, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(271, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Author Details";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FirstNameLabel.Location = new System.Drawing.Point(14, 86);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(106, 24);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LastNameLabel.Location = new System.Drawing.Point(18, 146);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(104, 24);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "LastName: ";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(170, 248);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(94, 46);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(52, 248);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 46);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit);
            // 
            // BooksLabel
            // 
            this.BooksLabel.AutoSize = true;
            this.BooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BooksLabel.Location = new System.Drawing.Point(370, 86);
            this.BooksLabel.Name = "BooksLabel";
            this.BooksLabel.Size = new System.Drawing.Size(154, 24);
            this.BooksLabel.TabIndex = 9;
            this.BooksLabel.Text = "Books By Author:";
            // 
            // BooksListBox
            // 
            this.BooksListBox.Enabled = false;
            this.BooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 16;
            this.BooksListBox.Location = new System.Drawing.Point(374, 128);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(265, 228);
            this.BooksListBox.TabIndex = 10;
            // 
            // AuthorDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 403);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.BooksLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AuthorDetailsForm";
            this.Text = "AuthorDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label BooksLabel;
        private System.Windows.Forms.ListBox BooksListBox;
    }
}