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
            SetupList();
        }

        public void SetupList()
        {
            _bookRepository.GetAllBooks().ForEach(book => BooksListBox.Items.Add(book));
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
