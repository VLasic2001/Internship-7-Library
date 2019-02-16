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
using Library.Data.Models;
using Library.Domain;

namespace Library.Presentation.BookForms
{
    public partial class ListOfBooksForm : Form
    {
        private LibraryContext _context { get; set; }
        private BookRepository _bookRepository = new BookRepository();
        public ListOfBooksForm()
        {
            InitializeComponent();
            _context = new LibraryContext();
            UpdateList();
        }

        public void UpdateList()
        {
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
    }
}
