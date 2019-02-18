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
using Library.Presentation.Features;
using Library.Presentation.LoanForms;
using Library.Presentation.PublisherForms;
using Library.Presentation.StudentForms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Library.Presentation
{
    public partial class MenuForm : Form
    {
        public LibraryContext Context { get; set; }

        public MenuForm()
        {
            InitializeComponent();
            Context = new LibraryContext();
        }

        private void AddBook(object sender, EventArgs e)
        {
            if (!AnyAuthorsInDatabase(Context) || !AnyPublishersInDatabase(Context)) return;
            var addBook = new AddBookForm();
            addBook.ShowDialog();
        }

        private void ListOfBooks(object sender, EventArgs e)
        {
            if (!AnyBooksInDatabase(Context)) return;
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
            if (!AnyAuthorsInDatabase(Context)) return;
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
            if (!AnyPublishersInDatabase(Context)) return;
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
            if (!AnyStudentsInDatabase(Context)) return;
            var listOfStudents = new ListOfStudentsForm();
            listOfStudents.ShowDialog();
        }

        private void AddLoan(object sender, EventArgs e)
        {
            if (!AnyStudentsInDatabase(Context) || !AnyBooksInDatabase(Context)) return;
            var addLoan = new AddLoanForm();
            addLoan.ShowDialog();
        }

        private void ListOfLoans(object sender, EventArgs e)
        {
            if (!AnyLoansInDatabase(Context)) return;
            var listOfLoans = new ListOfLoansForm();
            listOfLoans.ShowDialog();
        }

        public bool AnyAuthorsInDatabase(LibraryContext context)
        {
            if (context.Authors.Any()) return true;
            MessageBox.Show("Add an author and try again", "No Authors In The Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool AnyPublishersInDatabase(LibraryContext context)
        {
            if (context.Publishers.Any()) return true;
            MessageBox.Show("Add a publisher and try again", "No Publishers In The Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool AnyBooksInDatabase(LibraryContext context)
        {
            if (context.Books.Any()) return true;
            MessageBox.Show("Add a book and try again", "No Books In The Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool AnyStudentsInDatabase(LibraryContext context)
        {
            if (context.Students.Any()) return true;
            MessageBox.Show("Add a student and try again", "No Students In The Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool AnyLoansInDatabase(LibraryContext context)
        {
            if (context.Loans.Any()) return true;
            MessageBox.Show("Add a loan and try again", "No Loans In The Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void AddBookReport(object sender, EventArgs e)
        {
            var addBookReport = new AddBookReportForm();
            addBookReport.ShowDialog();
        }
    }
}
