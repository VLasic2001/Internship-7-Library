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
    public partial class AddBookForm : Form
    {
        private LibraryContext _context { get; set; }
        public BookRepository BookRepository { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }

        public AddBookForm()
        {
            InitializeComponent();
            _context = new LibraryContext();
            BookRepository = new BookRepository();
            SetupForm();
        }

        public void SetupForm()
        {
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void SelectAuthor(object sender, EventArgs e)
        {
            var selectAuthor = new SelectAuthorForm(_context);
            selectAuthor.ShowDialog();
            if (selectAuthor.Author == null)
            {
                MessageBox.Show(@"No author selected, please select an author and try again", @"No author selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(@"No author selected, please select an author and try again", @"No author selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Publisher = selectPublisher.Publisher;
                SelectedPublisherLabel.Text = Publisher.ToString();
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            CreateAndAddBook();
            MessageBox.Show(@"Book successfully added", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public bool IsInCorrectFormat()
        {
            if (string.IsNullOrWhiteSpace(BookNameTextBox.Text))
            {
                MessageBox.Show(@"Book name cannot be empty", @"Book name empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(Convert.ToInt32(NumberOfPagesNumericUpDown.Value).ToString(), out var resultPages))
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

        public void CreateAndAddBook()
        {

            BookRepository.AddBook(new Book(BookNameTextBox.Text, decimal.ToInt32(NumberOfPagesNumericUpDown.Value),
                (Genre)GenreComboBox.SelectedIndex, decimal.ToInt32(NumberOfCopiesNumericUpDown.Value), Author, Publisher));
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
