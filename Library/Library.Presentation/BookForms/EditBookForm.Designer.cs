namespace Library.Presentation.BookForms
{
    partial class EditBookForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.NumberOfPagesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumberOfPagesLabel = new System.Windows.Forms.Label();
            this.SelectedPublisherLabel = new System.Windows.Forms.Label();
            this.SelectPublisherButton = new System.Windows.Forms.Button();
            this.SelectedAuthorLabel = new System.Windows.Forms.Label();
            this.SelectAuthorButton = new System.Windows.Forms.Button();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPagesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(590, 231);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 25;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(590, 174);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(208, 192);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenreComboBox.TabIndex = 23;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(148, 192);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 22;
            this.GenreLabel.Text = "Genre";
            // 
            // NumberOfPagesNumericUpDown
            // 
            this.NumberOfPagesNumericUpDown.Location = new System.Drawing.Point(208, 148);
            this.NumberOfPagesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumberOfPagesNumericUpDown.Name = "NumberOfPagesNumericUpDown";
            this.NumberOfPagesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.NumberOfPagesNumericUpDown.TabIndex = 21;
            // 
            // NumberOfPagesLabel
            // 
            this.NumberOfPagesLabel.AutoSize = true;
            this.NumberOfPagesLabel.Location = new System.Drawing.Point(93, 148);
            this.NumberOfPagesLabel.Name = "NumberOfPagesLabel";
            this.NumberOfPagesLabel.Size = new System.Drawing.Size(91, 13);
            this.NumberOfPagesLabel.TabIndex = 20;
            this.NumberOfPagesLabel.Text = "Number Of Pages";
            // 
            // SelectedPublisherLabel
            // 
            this.SelectedPublisherLabel.AutoSize = true;
            this.SelectedPublisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SelectedPublisherLabel.Location = new System.Drawing.Point(205, 278);
            this.SelectedPublisherLabel.Name = "SelectedPublisherLabel";
            this.SelectedPublisherLabel.Size = new System.Drawing.Size(148, 17);
            this.SelectedPublisherLabel.TabIndex = 19;
            this.SelectedPublisherLabel.Text = "No Publisher Selected";
            // 
            // SelectPublisherButton
            // 
            this.SelectPublisherButton.Location = new System.Drawing.Point(69, 275);
            this.SelectPublisherButton.Name = "SelectPublisherButton";
            this.SelectPublisherButton.Size = new System.Drawing.Size(115, 23);
            this.SelectPublisherButton.TabIndex = 18;
            this.SelectPublisherButton.Text = "Select Publisher :";
            this.SelectPublisherButton.UseVisualStyleBackColor = true;
            this.SelectPublisherButton.Click += new System.EventHandler(this.SelectPublisher);
            // 
            // SelectedAuthorLabel
            // 
            this.SelectedAuthorLabel.AutoSize = true;
            this.SelectedAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SelectedAuthorLabel.Location = new System.Drawing.Point(205, 234);
            this.SelectedAuthorLabel.Name = "SelectedAuthorLabel";
            this.SelectedAuthorLabel.Size = new System.Drawing.Size(131, 17);
            this.SelectedAuthorLabel.TabIndex = 17;
            this.SelectedAuthorLabel.Text = "No Author Selected";
            // 
            // SelectAuthorButton
            // 
            this.SelectAuthorButton.Location = new System.Drawing.Point(69, 231);
            this.SelectAuthorButton.Name = "SelectAuthorButton";
            this.SelectAuthorButton.Size = new System.Drawing.Size(115, 23);
            this.SelectAuthorButton.TabIndex = 16;
            this.SelectAuthorButton.Text = "Select Author :";
            this.SelectAuthorButton.UseVisualStyleBackColor = true;
            this.SelectAuthorButton.Click += new System.EventHandler(this.SelectAuthor);
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(121, 107);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(63, 13);
            this.BookNameLabel.TabIndex = 15;
            this.BookNameLabel.Text = "Book Name";
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(208, 104);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.BookNameTextBox.TabIndex = 14;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(305, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(193, 46);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Edit Book";
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.NumberOfPagesNumericUpDown);
            this.Controls.Add(this.NumberOfPagesLabel);
            this.Controls.Add(this.SelectedPublisherLabel);
            this.Controls.Add(this.SelectPublisherButton);
            this.Controls.Add(this.SelectedAuthorLabel);
            this.Controls.Add(this.SelectAuthorButton);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPagesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.NumericUpDown NumberOfPagesNumericUpDown;
        private System.Windows.Forms.Label NumberOfPagesLabel;
        private System.Windows.Forms.Label SelectedPublisherLabel;
        private System.Windows.Forms.Button SelectPublisherButton;
        private System.Windows.Forms.Label SelectedAuthorLabel;
        private System.Windows.Forms.Button SelectAuthorButton;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}