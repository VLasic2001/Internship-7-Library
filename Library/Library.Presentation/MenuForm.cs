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
using Library.Data.Models;
using Library.Data.Utility;
using Library.Presentation.BookForms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Library.Presentation
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            SeedData();
        }

        private void AddBook(object sender, EventArgs e)
        {
            var addBook = new AddBookForm();
            addBook.ShowDialog();
        }

        public void SeedData()
        {
            Seeding.SeedingData();
            var context = new LibraryContext();
            context.Authors.Find(1).Books = new List<Book>();
            context.Authors.Find(2).Books = new List<Book>();
            context.Authors.Find(3).Books = new List<Book>();

            context.Publishers.Find(1).Books = new List<Book>();
            context.Publishers.Find(2).Books = new List<Book>();
            context.Publishers.Find(3).Books = new List<Book>();

            context.Authors.Find(1).Books.Add(context.Books.Find(1));
            context.Authors.Find(2).Books.Add(context.Books.Find(2));
            context.Authors.Find(3).Books.Add(context.Books.Find(3));

            context.Publishers.Find(1).Books.Add(context.Books.Find(1));
            context.Publishers.Find(2).Books.Add(context.Books.Find(2));
            context.Publishers.Find(3).Books.Add(context.Books.Find(3));
            context.SaveChanges(); 
        }
    }
}
