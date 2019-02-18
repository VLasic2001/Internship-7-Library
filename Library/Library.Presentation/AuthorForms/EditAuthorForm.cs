using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Infrastructure;

namespace Library.Presentation.AuthorForms
{
    public partial class EditAuthorForm : Form
    {
        private Author _author { get; set; }
        private LibraryContext _context { get; set; }

        public EditAuthorForm(Author author, LibraryContext context)
        {
            InitializeComponent();
            _author = author;
            _context = context;
            UpdateForm();
        }

        public void UpdateForm()
        {
            FirstNameTextBox.Text = _author.FirstName;
            LastNameTextBox.Text = _author.LastName;
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            EditAuthor();
            MessageBox.Show(@"Author successfully edited", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public bool IsInCorrectFormat()
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(LastNameTextBox.Text)) return true;
            MessageBox.Show(@"Name cannot be empty", @"Name empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }

        public void EditAuthor()
        {
            _context.Authors.Find(_author.AuthorId).FirstName = FirstNameTextBox.Text.RemoveDoubleWhiteSpaces().UpperCaseFirstLetters();
            _context.Authors.Find(_author.AuthorId).LastName = LastNameTextBox.Text.RemoveDoubleWhiteSpaces().UpperCaseFirstLetters();
            _context.SaveChanges();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
