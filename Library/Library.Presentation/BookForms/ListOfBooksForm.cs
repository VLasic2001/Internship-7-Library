using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Models;
using Library.Domain;

namespace Library.Presentation.BookForms
{
    public partial class ListOfBooksForm : Form
    {
        private LoanRepository _loanRepository { get; set; }
        private BookRepository _bookRepository { get; set; }
    
        public ListOfBooksForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        public void UpdateForm()
        {
            _bookRepository = new BookRepository();
            _loanRepository = new LoanRepository();
            BooksListBox.Items.Clear();
            _bookRepository.GetAllBooks().ForEach(book => BooksListBox.Items.Add(book));
            var totalNumberOfBooks = 0;
            _bookRepository.GetAllBooks().ForEach(book => totalNumberOfBooks+=book.NumberOfCopies);
            TotalNumberOfBooksLabel.Text = $"Total Number Of Library's Books: {totalNumberOfBooks}";
            var numberOfActiveLoans = _loanRepository.GetAllLoans().Count(loan => loan.IsLoanActive());
            NumberOfAvailableBooksLabel.Text = $"Number Of Available Books: {totalNumberOfBooks - numberOfActiveLoans}";
            NumberOfLoanedBooks.Text = $"Number Of Loaned Books: {numberOfActiveLoans}";
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the book you want to delete", @"No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selection = (Book) BooksListBox.SelectedItem;
            if (MessageBox.Show(selection.Loans.Count > 0 ? $@"Are you sure you want to delete {selection.Name}?" + "\n" + "Deleting the book will also delete all of the book's loans" : $"Are you sure you want to delete {selection.Name}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            _bookRepository.DeleteBook(selection);
            UpdateForm();
        }

        private void Details(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the book you want to see the details of", @"No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var bookDetails = new BookDetailsForm((Book)BooksListBox.SelectedItem);
            bookDetails.ShowDialog();
            UpdateForm();
        }

        private void Edit(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the book you want to edit", @"No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             var editBook = new EditBookForm((Book)BooksListBox.SelectedItem);
            editBook.ShowDialog();
            UpdateForm();
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
    }
}
