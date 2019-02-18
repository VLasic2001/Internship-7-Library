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

namespace Library.Presentation.Popups
{
    public partial class SelectBookForm : Form
    {
        private BookRepository _bookRepository { get; set; }
        public Book Book { get; set; }

        public SelectBookForm()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            _bookRepository = new BookRepository();
            _bookRepository.GetAllBooks().ForEach(book => BooksListBox.Items.Add(book));
        }

        private void Search(object sender, EventArgs e)
        {
            var searchPublisherList = new List<Book>();

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                BooksListBox.Items.Clear();
                _bookRepository.GetAllBooks().ForEach(author => BooksListBox.Items.Add(author));
            }

            foreach (var book in _bookRepository.GetAllBooks())
            {
                if (book.Name.ToLower().Contains(NameTextBox.Text.ToLower()))
                {
                    searchPublisherList.Add(book);
                }
            }
            if (searchPublisherList.Count == 0)
            {
                MessageBox.Show(@"No books fit the search conditions", @"Invalid search term", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                BooksListBox.Items.Clear();
                searchPublisherList.ForEach(author => BooksListBox.Items.Add(author));
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Select(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem == null)
            {
                MessageBox.Show(@"No book selected, please select a publisher and try again", @"No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Book = (Book)BooksListBox.SelectedItem;
                Close();
            }
        }
    }
}
