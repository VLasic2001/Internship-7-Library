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
using Library.Presentation.AuthorForms;
using Library.Presentation.BookForms;
using Library.Presentation.PublisherForms;
using Library.Presentation.StudentForms;
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
        
        public void SeedData()
        {
            Seeding.SeedingData();
        }

        private void AddBook(object sender, EventArgs e)
        {
            var addBook = new AddBookForm();
            addBook.ShowDialog();
        }

        private void ListOfBooks(object sender, EventArgs e)
        {
            var listOfBooks = new ListOfBooksForm();
            listOfBooks.ShowDialog();
        }

        private void AddAuthor(object sender, EventArgs e)
        {
            var addAuthor = new AddAuthorForm();
            addAuthor.ShowDialog();
        }

        private void ListOfAuthors(object sender, EventArgs e)
        {
            var listOfAuthors = new ListOfAuthorsForm();
            listOfAuthors.ShowDialog();
        }

        private void AddPublisher(object sender, EventArgs e)
        {
            var addPublisher = new AddPublisherForm();
            addPublisher.ShowDialog();
        }

        private void ListOfPublishers(object sender, EventArgs e)
        {
            var listOfPublishers = new ListOfPublishersForm();
            listOfPublishers.ShowDialog();
        }

        private void AddStudent(object sender, EventArgs e)
        {
            var addStudent = new AddStudentForm();
            addStudent.ShowDialog();
        }

        private void ListOfStudents(object sender, EventArgs e)
        {
            var listOfStudents = new ListOfStudentsForm();
            listOfStudents.ShowDialog();
        }
    }
}
