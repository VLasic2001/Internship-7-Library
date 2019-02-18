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
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(597, 324);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 34);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(597, 200);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 34);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete Loan";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(597, 161);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(95, 33);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit Loan";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(597, 124);
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
            this.LoansListBox.Size = new System.Drawing.Size(431, 342);
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
            // ListOfLoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.LoansListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ListOfLoansForm";
            this.Text = "ListOfLoansForm";
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
    }
}