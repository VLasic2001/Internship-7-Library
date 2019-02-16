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
using Library.Data.Models;
using Library.Domain;

namespace Library.Presentation.BookForms
{
    public partial class BookDetailsForm : Form
    {
        private Book _book { get; set; }

        public BookDetailsForm(Book book)
        {
            InitializeComponent();
            _book = book;
            BookSetup();
            UpdateForm();
        }

        public void BookSetup()
        {
            var context = new LibraryContext();
            _book.Name = context.Books.ToList().FirstOrDefault(book => book.BookId == _book.BookId).Name;
            _book.NumberOfPages = context.Books.ToList().FirstOrDefault(book => book.BookId == _book.BookId).NumberOfPages;
            _book.Genre = context.Books.ToList().FirstOrDefault(book => book.BookId == _book.BookId).Genre;
            _book.AuthorId = context.Books.ToList().FirstOrDefault(book => book.BookId == _book.BookId).AuthorId;
            _book.PublisherId = context.Books.ToList().FirstOrDefault(book => book.BookId == _book.BookId).PublisherId;
            var authorRepository = new AuthorRepository();
            _book.Author = authorRepository.GetAuthor(_book.AuthorId);
            var publisherRepository = new PublisherRepository();
            _book.Publisher = publisherRepository.GetPublisher(_book.PublisherId);

        }

        public void UpdateForm()
        {
            BookSetup();
            BookNameLabel.Text = $"Book Name: {_book.Name}";
            NumberOfPagesLabel.Text = $"Number Of Pages: {_book.NumberOfPages}";
            GenreLabel.Text = $"Genre: {_book.Genre}";
            AuthorLabel.Text = $"Author: {_book.Author.FirstName} {_book.Author.LastName}";
            PublisherLabel.Text = $"Publisher: {_book.Publisher.Name}";
        }

        private void Edit(object sender, EventArgs e)
        {
            var editBook = new EditBookForm(_book);
            editBook.ShowDialog();
            UpdateForm();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
