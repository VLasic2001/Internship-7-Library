namespace Library.Presentation.PublisherForms
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
            this.PublishersListBox.Size = new System.Drawing.Size(484, 342);
            this.PublishersListBox.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(609, 344);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 34);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(609, 220);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 34);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete Publisher";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(609, 181);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(95, 33);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit Publisher";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(609, 144);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(95, 31);
            this.DetailsButton.TabIndex = 6;
            this.DetailsButton.Text = "Publisher Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            // 
            // ListOfPublishersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.PublishersListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ListOfPublishersForm";
            this.Text = "ListOfPublishersForm";
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
    }
}