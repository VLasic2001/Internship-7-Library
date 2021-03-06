﻿namespace Library.Presentation.PublisherForms
{
    partial class ListOfPublishersForm
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
            this.PublishersListBox = new System.Windows.Forms.ListBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.TipLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TitleLabel.Location = new System.Drawing.Point(226, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(332, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "List Of Publishers";
            // 
            // PublishersListBox
            // 
            this.PublishersListBox.FormattingEnabled = true;
            this.PublishersListBox.Location = new System.Drawing.Point(23, 85);
            this.PublishersListBox.Name = "PublishersListBox";
            this.PublishersListBox.Size = new System.Drawing.Size(391, 342);
            this.PublishersListBox.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(678, 346);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 34);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(514, 384);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 34);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete Publisher";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(514, 345);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(95, 33);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit Publisher";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(514, 308);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(95, 31);
            this.DetailsButton.TabIndex = 6;
            this.DetailsButton.Text = "Publisher Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.Details);
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(462, 204);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(300, 13);
            this.TipLabel.TabIndex = 30;
            this.TipLabel.Text = "*Optional and used only for searching through the publisher list";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(452, 166);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 13);
            this.NameLabel.TabIndex = 29;
            this.NameLabel.Text = "Publisher\'s name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(687, 161);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(560, 163);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 27;
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPictureBox.Location = new System.Drawing.Point(439, 114);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(334, 128);
            this.SearchPictureBox.TabIndex = 26;
            this.SearchPictureBox.TabStop = false;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SearchLabel.Location = new System.Drawing.Point(567, 124);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(70, 24);
            this.SearchLabel.TabIndex = 31;
            this.SearchLabel.Text = "Search";
            // 
            // ListOfPublishersForm
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
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.PublishersListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ListOfPublishersForm";
            this.Text = "ListOfPublishersForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox PublishersListBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}