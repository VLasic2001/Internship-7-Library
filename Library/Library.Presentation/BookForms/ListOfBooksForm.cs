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

        private BookRepository _bookRepository { get; set; }
    
        public ListOfBooksForm()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            _bookRepository = new BookRepository();
            BooksListBox.Items.Clear();
            _bookRepository.GetAllBooks().ForEach(book => BooksListBox.Items.Add(book));
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
            if (MessageBox.Show($@"Are you sure you want to delete {selection.Name}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            _bookRepository.DeleteBook(selection);
            UpdateList();
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
            UpdateList();
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
            UpdateList();
        }
    }
}
