namespace Library.Presentation.Popups
{
    partial class SelectBookReportForm
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
            this.TipLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(447, 161);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(282, 13);
            this.TipLabel.TabIndex = 24;
            this.TipLabel.Text = "*Optional and used only for searching through the book list";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(447, 125);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Book name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(662, 119);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(536, 122);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 21;
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPictureBox.Location = new System.Drawing.Point(423, 80);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(334, 132);
            this.SearchPictureBox.TabIndex = 20;
            this.SearchPictureBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(595, 337);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(96, 46);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(471, 337);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(93, 46);
            this.SelectButton.TabIndex = 18;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.Select);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(260, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(236, 46);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "Select Book";
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(23, 66);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(347, 368);
            this.BooksListBox.TabIndex = 10;
            this.BooksListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedBook);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SearchLabel.Location = new System.Drawing.Point(548, 82);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(70, 24);
            this.SearchLabel.TabIndex = 25;
            this.SearchLabel.Text = "Search";
            // 
            // SelectBookReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BooksListBox);
            this.Name = "SelectBookReportForm";
            this.Text = "SelectBookReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}