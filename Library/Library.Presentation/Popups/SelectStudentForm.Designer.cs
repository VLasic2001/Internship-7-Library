namespace Library.Presentation.Popups
{
    partial class SelectStudentForm
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
            this.SelectButton = new System.Windows.Forms.Button();
            this.SelectStudentLabel = new System.Windows.Forms.Label();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.TipLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentClassComboBox = new System.Windows.Forms.ComboBox();
            this.StudentClassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            this.SuspendLayout();
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
            // SelectStudentLabel
            // 
            this.SelectStudentLabel.AutoSize = true;
            this.SelectStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.SelectStudentLabel.Location = new System.Drawing.Point(265, 9);
            this.SelectStudentLabel.Name = "SelectStudentLabel";
            this.SelectStudentLabel.Size = new System.Drawing.Size(280, 46);
            this.SelectStudentLabel.TabIndex = 11;
            this.SelectStudentLabel.Text = "Select Student";
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(24, 71);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(347, 355);
            this.StudentsListBox.TabIndex = 10;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedStudent);
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPictureBox.Location = new System.Drawing.Point(404, 85);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(384, 191);
            this.SearchPictureBox.TabIndex = 22;
            this.SearchPictureBox.TabStop = false;
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(432, 240);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(350, 13);
            this.TipLabel.TabIndex = 28;
            this.TipLabel.Text = "*All three are optional and used only for searching through the student list";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(420, 157);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(99, 13);
            this.LastNameLabel.TabIndex = 27;
            this.LastNameLabel.Text = "Student\'s last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(420, 116);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(99, 13);
            this.FirstNameLabel.TabIndex = 26;
            this.FirstNameLabel.Text = "Student\'s first name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(674, 152);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 25;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(525, 154);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.LastNameTextBox.TabIndex = 24;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(525, 113);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.FirstNameTextBox.TabIndex = 23;
            // 
            // StudentClassComboBox
            // 
            this.StudentClassComboBox.FormattingEnabled = true;
            this.StudentClassComboBox.Location = new System.Drawing.Point(525, 194);
            this.StudentClassComboBox.Name = "StudentClassComboBox";
            this.StudentClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.StudentClassComboBox.TabIndex = 29;
            // 
            // StudentClassLabel
            // 
            this.StudentClassLabel.AutoSize = true;
            this.StudentClassLabel.Location = new System.Drawing.Point(423, 201);
            this.StudentClassLabel.Name = "StudentClassLabel";
            this.StudentClassLabel.Size = new System.Drawing.Size(79, 13);
            this.StudentClassLabel.TabIndex = 30;
            this.StudentClassLabel.Text = "Student\'s Class";
            // 
            // SelectStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentClassLabel);
            this.Controls.Add(this.StudentClassComboBox);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SelectStudentLabel);
            this.Controls.Add(this.StudentsListBox);
            this.Name = "SelectStudentForm";
            this.Text = "SelectStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label SelectStudentLabel;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.ComboBox StudentClassComboBox;
        private System.Windows.Forms.Label StudentClassLabel;
    }
}