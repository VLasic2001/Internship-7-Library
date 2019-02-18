namespace Library.Presentation.LoanForms
{
    partial class LoanDetails
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
            this.StudentLabel = new System.Windows.Forms.Label();
            this.BookLabel = new System.Windows.Forms.Label();
            this.LoanDateLabel = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(32, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(242, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Loan Details";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.StudentLabel.Location = new System.Drawing.Point(12, 131);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(84, 24);
            this.StudentLabel.TabIndex = 1;
            this.StudentLabel.Text = "Student: ";
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BookLabel.Location = new System.Drawing.Point(12, 90);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(63, 24);
            this.BookLabel.TabIndex = 2;
            this.BookLabel.Text = "Book: ";
            // 
            // LoanDateLabel
            // 
            this.LoanDateLabel.AutoSize = true;
            this.LoanDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoanDateLabel.Location = new System.Drawing.Point(13, 175);
            this.LoanDateLabel.Name = "LoanDateLabel";
            this.LoanDateLabel.Size = new System.Drawing.Size(105, 24);
            this.LoanDateLabel.TabIndex = 3;
            this.LoanDateLabel.Text = "Loan Date: ";
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ReturnDateLabel.Location = new System.Drawing.Point(14, 222);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(119, 24);
            this.ReturnDateLabel.TabIndex = 4;
            this.ReturnDateLabel.Text = "Return Date: ";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(28, 296);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(80, 37);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(202, 296);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(84, 37);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Location = new System.Drawing.Point(114, 296);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(82, 37);
            this.ReturnBookButton.TabIndex = 7;
            this.ReturnBookButton.Text = "Return Book";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBook);
            // 
            // LoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 354);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.LoanDateLabel);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "LoanDetails";
            this.Text = "LoanDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Label LoanDateLabel;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ReturnBookButton;
    }
}