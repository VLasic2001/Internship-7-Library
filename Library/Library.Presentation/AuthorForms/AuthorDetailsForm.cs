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
using Microsoft.EntityFrameworkCore;

namespace Library.Presentation.AuthorForms
{
    public partial class AuthorDetailsForm : Form
    {
        private Author _author { get; set; }
        private LibraryContext _context { get; set; }

        public AuthorDetailsForm(Author author)
        {
            InitializeComponent();
            _author = author;
            _context = new LibraryContext();
            UpdateForm();
        }

        public void UpdateForm()
        {
            _author = _context.Authors.Include(author => author.Books).First(author => author.AuthorId == _author.AuthorId);
            FirstNameLabel.Text = $"First Name: {_author.FirstName}";
            LastNameLabel.Text = $"Last Name: {_author.LastName}";
            BooksListBox.Items.Clear();
            _author.Books.ToList().ForEach(book => BooksListBox.Items.Add(book));

        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit(object sender, EventArgs e)
        {
            var editAuthor = new EditAuthorForm(_author, _context);
            editAuthor.ShowDialog();
            UpdateForm();
        }
    }
}
