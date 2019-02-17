namespace Library.Presentation.BookForms
{
    partial class AddBookForm
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
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.SelectAuthorButton = new System.Windows.Forms.Button();
            this.SelectedAuthorLabel = new System.Windows.Forms.Label();
            this.SelectedPublisherLabel = new System.Windows.Forms.Label();
            this.SelectPublisherButton = new System.Windows.Forms.Button();
            this.NumberOfPagesLabel = new System.Windows.Forms.Label();
            this.NumberOfPagesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NumberOfCopiesLabel = new System.Windows.Forms.Label();
            this.NumberOfCopiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPagesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCopiesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(283, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(195, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Add Book";
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(186, 104);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(109, 20);
            this.BookNameTextBox.TabIndex = 1;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(99, 107);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(63, 13);
            this.BookNameLabel.TabIndex = 2;
            this.BookNameLabel.Text = "Book Name";
            // 
            // SelectAuthorButton
            // 
            this.SelectAuthorButton.Location = new System.Drawing.Point(47, 265);
            this.SelectAuthorButton.Name = "SelectAuthorButton";
            this.SelectAuthorButton.Size = new System.Drawing.Size(115, 23);
            this.SelectAuthorButton.TabIndex = 3;
            this.SelectAuthorButton.Text = "Select Author :";
            this.SelectAuthorButton.UseVisualStyleBackColor = true;
            this.SelectAuthorButton.Click += new System.EventHandler(this.SelectAuthor);
            // 
            // SelectedAuthorLabel
            // 
            this.SelectedAuthorLabel.AutoSize = true;
            this.SelectedAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SelectedAuthorLabel.Location = new System.Drawing.Point(183, 268);
            this.SelectedAuthorLabel.Name = "SelectedAuthorLabel";
            this.SelectedAuthorLabel.Size = new System.Drawing.Size(131, 17);
            this.SelectedAuthorLabel.TabIndex = 4;
            this.SelectedAuthorLabel.Text = "No Author Selected";
            // 
            // SelectedPublisherLabel
            // 
            this.SelectedPublisherLabel.AutoSize = true;
            this.SelectedPublisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SelectedPublisherLabel.Location = new System.Drawing.Point(183, 312);
            this.SelectedPublisherLabel.Name = "SelectedPublisherLabel";
            this.SelectedPublisherLabel.Size = new System.Drawing.Size(148, 17);
            this.SelectedPublisherLabel.TabIndex = 6;
            this.SelectedPublisherLabel.Text = "No Publisher Selected";
            // 
            // SelectPublisherButton
            // 
            this.SelectPublisherButton.Location = new System.Drawing.Point(47, 309);
            this.SelectPublisherButton.Name = "SelectPublisherButton";
            this.SelectPublisherButton.Size = new System.Drawing.Size(115, 23);
            this.SelectPublisherButton.TabIndex = 5;
            this.SelectPublisherButton.Text = "Select Publisher :";
            this.SelectPublisherButton.UseVisualStyleBackColor = true;
            this.SelectPublisherButton.Click += new System.EventHandler(this.SelectPublisher);
            // 
            // NumberOfPagesLabel
            // 
            this.NumberOfPagesLabel.AutoSize = true;
            this.NumberOfPagesLabel.Location = new System.Drawing.Point(71, 148);
            this.NumberOfPagesLabel.Name = "NumberOfPagesLabel";
            this.NumberOfPagesLabel.Size = new System.Drawing.Size(91, 13);
            this.NumberOfPagesLabel.TabIndex = 7;
            this.NumberOfPagesLabel.Text = "Number Of Pages";
            // 
            // NumberOfPagesNumericUpDown
            // 
            this.NumberOfPagesNumericUpDown.Location = new System.Drawing.Point(186, 148);
            this.NumberOfPagesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumberOfPagesNumericUpDown.Name = "NumberOfPagesNumericUpDown";
            this.NumberOfPagesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.NumberOfPagesNumericUpDown.TabIndex = 8;
            this.NumberOfPagesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(126, 192);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 9;
            this.GenreLabel.Text = "Genre";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(186, 192);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenreComboBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(568, 174);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(568, 231);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // NumberOfCopiesLabel
            // 
            this.NumberOfCopiesLabel.AutoSize = true;
            this.NumberOfCopiesLabel.Location = new System.Drawing.Point(66, 231);
            this.NumberOfCopiesLabel.Name = "NumberOfCopiesLabel";
            this.NumberOfCopiesLabel.Size = new System.Drawing.Size(96, 13);
            this.NumberOfCopiesLabel.TabIndex = 13;
            this.NumberOfCopiesLabel.Text = "Number Of Copies:";
            // 
            // NumberOfCopiesNumericUpDown
            // 
            this.NumberOfCopiesNumericUpDown.Location = new System.Drawing.Point(186, 229);
            this.NumberOfCopiesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumberOfCopiesNumericUpDown.Name = "NumberOfCopiesNumericUpDown";
            this.NumberOfCopiesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.NumberOfCopiesNumericUpDown.TabIndex = 14;
            this.NumberOfCopiesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberOfCopiesNumericUpDown);
            this.Controls.Add(this.NumberOfCopiesLabel);
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
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPagesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCopiesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Button SelectAuthorButton;
        private System.Windows.Forms.Label SelectedAuthorLabel;
        private System.Windows.Forms.Label SelectedPublisherLabel;
        private System.Windows.Forms.Button SelectPublisherButton;
        private System.Windows.Forms.Label NumberOfPagesLabel;
        private System.Windows.Forms.NumericUpDown NumberOfPagesNumericUpDown;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label NumberOfCopiesLabel;
        private System.Windows.Forms.NumericUpDown NumberOfCopiesNumericUpDown;
    }
}