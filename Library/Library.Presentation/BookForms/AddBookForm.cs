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
            NumberOfPagesNumericUpDown.Value = 1;
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
            CreateAndAddBook();
            Close();
        }

        public void CreateAndAddBook()
        {
            BookRepository.AddBook(BookNameTextBox.Text, decimal.ToInt32(NumberOfPagesNumericUpDown.Value),
                    (Genre) GenreComboBox.SelectedIndex, Author.AuthorId, Publisher.PublisherId);
        }
    }
}
