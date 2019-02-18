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
        private LibraryContext _context { get; set; }
        private BookRepository _bookRepository { get; set; }

        public BookDetailsForm(Book book)
        {
            InitializeComponent();
            _book = book;
            BookSetup();
            UpdateForm();
        }

        public void BookSetup()
        {
            _context = new LibraryContext();
            _bookRepository = new BookRepository();
            _book = _bookRepository.GetBook(_book.BookId);
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
            NumberOfLibrarysCopiesLabel.Text = $"Number Of Library's Copies: {_book.NumberOfCopies}";
            AuthorLabel.Text = $"Author: {_book.Author.FirstName} {_book.Author.LastName}";
            PublisherLabel.Text = $"Publisher: {_book.Publisher.Name}";
            NumberOfAvailableCopiesLabel.Text =
                $"Number Of Available Copies: {_book.NumberOfCopies - _book.Loans.Count(loan => loan.IsLoanActive())}";
            NumberOfLoanedCopiesLabel.Text =
                $"Number Of Loaned Copies: {_book.Loans.Count(loan => loan.IsLoanActive())}";
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
