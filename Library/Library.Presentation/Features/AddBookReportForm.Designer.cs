namespace Library.Presentation.Features
{
    partial class AddBookReportForm
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
            this.LoanDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LoanDateLabel = new System.Windows.Forms.Label();
            this.SelectBookReportButton = new System.Windows.Forms.Button();
            this.SelectedBookReportLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(187, 270);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(102, 34);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(64, 271);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(102, 33);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // LoanDateDateTimePicker
            // 
            this.LoanDateDateTimePicker.Location = new System.Drawing.Point(161, 215);
            this.LoanDateDateTimePicker.Name = "LoanDateDateTimePicker";
            this.LoanDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.LoanDateDateTimePicker.TabIndex = 20;
            this.LoanDateDateTimePicker.ValueChanged += new System.EventHandler(this.LoanDateDateTimePicker_ValueChanged);
            // 
            // LoanDateLabel
            // 
            this.LoanDateLabel.AutoSize = true;
            this.LoanDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoanDateLabel.Location = new System.Drawing.Point(40, 212);
            this.LoanDateLabel.Name = "LoanDateLabel";
            this.LoanDateLabel.Size = new System.Drawing.Size(100, 24);
            this.LoanDateLabel.TabIndex = 19;
            this.LoanDateLabel.Text = "Loan Date:";
            this.LoanDateLabel.Click += new System.EventHandler(this.LoanDateLabel_Click);
            // 
            // SelectBookReportButton
            // 
            this.SelectBookReportButton.Location = new System.Drawing.Point(9, 153);
            this.SelectBookReportButton.Name = "SelectBookReportButton";
            this.SelectBookReportButton.Size = new System.Drawing.Size(131, 34);
            this.SelectBookReportButton.TabIndex = 18;
            this.SelectBookReportButton.Text = "Selected Book Report:";
            this.SelectBookReportButton.UseVisualStyleBackColor = true;
            this.SelectBookReportButton.Click += new System.EventHandler(this.SelectBookReport);
            // 
            // SelectedBookReportLabel
            // 
            this.SelectedBookReportLabel.AutoSize = true;
            this.SelectedBookReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SelectedBookReportLabel.Location = new System.Drawing.Point(157, 156);
            this.SelectedBookReportLabel.Name = "SelectedBookReportLabel";
            this.SelectedBookReportLabel.Size = new System.Drawing.Size(183, 24);
            this.SelectedBookReportLabel.TabIndex = 17;
            this.SelectedBookReportLabel.Text = "No Student Selected";
            this.SelectedBookReportLabel.Click += new System.EventHandler(this.SelectedBookReportLabel_Click);
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClassLabel.Location = new System.Drawing.Point(75, 98);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(65, 24);
            this.ClassLabel.TabIndex = 15;
            this.ClassLabel.Text = "Class: ";
            this.ClassLabel.Click += new System.EventHandler(this.ClassLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(23, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(326, 46);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "Add Book Report";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(161, 100);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 25;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // AddBookReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoanDateDateTimePicker);
            this.Controls.Add(this.LoanDateLabel);
            this.Controls.Add(this.SelectBookReportButton);
            this.Controls.Add(this.SelectedBookReportLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddBookReportForm";
            this.Text = "AddBookReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker LoanDateDateTimePicker;
        private System.Windows.Forms.Label LoanDateLabel;
        private System.Windows.Forms.Button SelectBookReportButton;
        private System.Windows.Forms.Label SelectedBookReportLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox ClassComboBox;
    }
}