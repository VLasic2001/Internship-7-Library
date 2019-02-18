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
using Library.Data.Enums;
using Library.Data.Models;
using Library.Domain;
using Library.Presentation.Popups;

namespace Library.Presentation.BookForms
{
    public partial class EditBookForm : Form
    {
        private Book _book { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        private readonly LibraryContext _context = new LibraryContext();
        public BookRepository BookRepository = new BookRepository();

        public EditBookForm(Book book)
        {
            
            InitializeComponent();
            _book = book;
            UpdateForm();
        }

        public void UpdateForm()
        {
            var authorRepository = new AuthorRepository();
            Author = authorRepository.GetAuthor(_book.AuthorId);
            var publisherRepository = new PublisherRepository();
            Publisher = publisherRepository.GetPublisher(_book.PublisherId);
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            BookNameTextBox.Text = _book.Name;
            NumberOfPagesNumericUpDown.Value = _book.NumberOfPages;
            GenreComboBox.SelectedItem = _book.Genre;
            SelectedAuthorLabel.Text = Author.ToString();
            SelectedPublisherLabel.Text = Publisher.ToString();
        }

        private void SelectAuthor(object sender, EventArgs e)
        {
            var selectAuthor = new SelectAuthorForm(_context);
            selectAuthor.ShowDialog();
            if (selectAuthor.Author == null)
            {
                MessageBox.Show(@"Author not changed", @"No author was selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Author = selectAuthor.Author;
                SelectedAuthorLabel.Text = Author.ToString();
            }
        }

        private void SelectPublisher(object sender, EventArgs e)
        {
            var selectPublisher = new SelectPublisherForm(_context);
            selectPublisher.ShowDialog();
            if (selectPublisher.Publisher == null)
            {
                MessageBox.Show(@"Publisher not changed", @"No publisher was selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Publisher = selectPublisher.Publisher;
                SelectedPublisherLabel.Text = Publisher.ToString();
            }
        }

        public bool IsInCorrectFormat()
        {
            if (string.IsNullOrWhiteSpace(BookNameTextBox.Text))
            {
                MessageBox.Show(@"Book name cannot be empty", @"Book name empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(Convert.ToInt32(NumberOfPagesNumericUpDown.Value).ToString(), out var result))
            {
                MessageBox.Show(@"Number of pages must be a number", @"Incorrect format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(Convert.ToInt32(NumberOfCopiesNumericUpDown.Value).ToString(), out var resultCopies))
            {
                MessageBox.Show(@"Number of copies must be a number", @"Incorrect format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Author == null)
            {
                MessageBox.Show(@"Select an author first", @"No Author selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Publisher != null) return true;
            MessageBox.Show(@"Select a publisher first", @"No publisher selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            EditBook();
            MessageBox.Show(@"Book successfully edited", @"Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public void EditBook()
        {
            var bookToEdit = _context.Books.Find(_book.BookId);
            bookToEdit.Name = BookNameTextBox.Text;
            bookToEdit.NumberOfPages = decimal.ToInt32(NumberOfPagesNumericUpDown.Value);
            bookToEdit.Genre = (Genre)GenreComboBox.SelectedIndex;
            bookToEdit.NumberOfCopies = decimal.ToInt32(NumberOfCopiesNumericUpDown.Value);
            bookToEdit.AuthorId = Author.AuthorId;
            bookToEdit.PublisherId = Publisher.PublisherId;
            _context.SaveChanges();
        }
    }
}
