using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Models;

namespace Library.Presentation.AuthorForms
{
    public partial class AuthorDetailsForm : Form
    {
        private Author _author { get; set; }
        public AuthorDetailsForm(Author author)
        {
            InitializeComponent();
            _author = author;
            UpdateForm();
        }

        public void UpdateForm()
        {
            FirstNameLabel.Text = $"First Name: {_author.FirstName}";
            LastNameLabel.Text = $"Last Name: {_author.LastName}";
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
