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
using Library.Domain;

namespace Library.Presentation.AuthorForms
{
    public partial class AddAuthorForm : Form
    {
        private AuthorRepository _authorRepository { get; set; }
        public AddAuthorForm()
        {
            InitializeComponent();
            _authorRepository = new AuthorRepository();
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            CreateAndAddAuthor();
            MessageBox.Show(@"Author successfully added", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        public bool IsInCorrectFormat()
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) ||
                !string.IsNullOrWhiteSpace(LastNameTextBox.Text)) return true;
            MessageBox.Show(@"Name cannot be empty", @"Name empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        public void CreateAndAddAuthor()
        {
            _authorRepository.AddAuthor(new Author(FirstNameTextBox.Text, LastNameTextBox.Text));
        }
    }
}
