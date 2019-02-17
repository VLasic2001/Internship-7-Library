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
using Microsoft.EntityFrameworkCore;

namespace Library.Presentation.PublisherForms
{
    public partial class PublisherDetailsForm : Form
    {
        private LibraryContext _context { get; set; }
        private Publisher _publisher { get; set; }

        public PublisherDetailsForm(Publisher publisher)
        {
            InitializeComponent();
            _context = new LibraryContext();
            _publisher = publisher;
            UpdateForm();
        }

        public void UpdateForm()
        {
            _publisher = _context.Publishers.Include(publisher => publisher.Books).FirstOrDefault(publisher => publisher.PublisherId == _publisher.PublisherId);
            NameLabel.Text = $"Name: {_publisher.Name}";
            BooksListBox.Items.Clear();
            _publisher.Books.ToList().ForEach(book => BooksListBox.Items.Add(book));
        }

        private void Edit(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
