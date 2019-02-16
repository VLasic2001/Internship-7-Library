namespace Library.Presentation.Popups
{
    partial class SelectPublisherForm
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
            this.TipLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SelectPublisherLabel = new System.Windows.Forms.Label();
            this.PublishersListBox = new System.Windows.Forms.ListBox();
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
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(427, 163);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(300, 13);
            this.TipLabel.TabIndex = 17;
            this.TipLabel.Text = "*Optional and used only for searching through the publisher list";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(427, 109);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 13);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Publisher\'s name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(662, 104);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(535, 106);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 12;
            // 
            // SelectPublisherLabel
            // 
            this.SelectPublisherLabel.AutoSize = true;
            this.SelectPublisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.SelectPublisherLabel.Location = new System.Drawing.Point(265, 9);
            this.SelectPublisherLabel.Name = "SelectPublisherLabel";
            this.SelectPublisherLabel.Size = new System.Drawing.Size(309, 46);
            this.SelectPublisherLabel.TabIndex = 11;
            this.SelectPublisherLabel.Text = "Select Publisher";
            // 
            // PublishersListBox
            // 
            this.PublishersListBox.FormattingEnabled = true;
            this.PublishersListBox.Location = new System.Drawing.Point(23, 66);
            this.PublishersListBox.Name = "PublishersListBox";
            this.PublishersListBox.Size = new System.Drawing.Size(347, 368);
            this.PublishersListBox.TabIndex = 10;
            // 
            // SelectPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SelectPublisherLabel);
            this.Controls.Add(this.PublishersListBox);
            this.Name = "SelectPublisherForm";
            this.Text = "SelectPublisherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SelectPublisherLabel;
        private System.Windows.Forms.ListBox PublishersListBox;
    }
}