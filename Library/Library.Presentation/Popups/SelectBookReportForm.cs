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
    public partial class SelectBookReportForm : Form
    {
        private BookRepository _bookRepository { get; set; }
        public Book Book { get; set; }
        private int NumberOfStudents { get; set; }

        public SelectBookReportForm(int numberOfStudents)
        {
            InitializeComponent();
            NumberOfStudents = numberOfStudents;
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

        private void SelectedBook(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem == null) return;
            var selection = (Book)BooksListBox.SelectedItem;
            if (selection.Loans.Count(loan => loan.IsLoanActive()) >= selection.NumberOfCopies)
            {
                MessageBox.Show(@"All Copies Of The Book Are Loaned", @"No Copy Available", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                BooksListBox.ClearSelected();
            }

            if (selection.NumberOfCopies - selection.Loans.Count(loan => loan.IsLoanActive()) > NumberOfStudents) return;
            MessageBox.Show(@"Not Enough Copies For The Whole Class", @"Not Enough Copies Available", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            BooksListBox.ClearSelected();
        }
    }
}
