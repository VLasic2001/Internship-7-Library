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
using Library.Domain;
using Library.Presentation.Popups;

namespace Library.Presentation.LoanForms
{
    public partial class EditLoanForm : Form
    {
        private Loan _loan { get; set; }
        private StudentRepository _studentRepository { get; set; }
        private BookRepository _bookRepository { get; set; }
        public Student Student { get; set; }
        public Book Book { get; set; }
        private LibraryContext _context { get; set; }

        public EditLoanForm(Loan loan)
        {
            InitializeComponent();
            _loan = loan;
            Book = _loan.Book;
            Student = _loan.Student;
            _context = new LibraryContext();
            UpdateForm();
        }

        public void UpdateForm()
        {
            _studentRepository = new StudentRepository();
            Student = _studentRepository.GetStudent(_loan.StudentId);
            _bookRepository = new BookRepository();
            Book = _bookRepository.GetBook(_loan.BookId);
            SelectedStudentLabel.Text = Student.ToString();
            SelectedBookLabel.Text = Book.ToString();
            LoanDateDateTimePicker.Value = _loan.LoanDate;
            IsBookReturnedCheckBox.Checked = !_loan.IsLoanActive();
        }

        private void IsBookReturnedCheck(object sender, EventArgs e)
        {
            ReturnDateDateTimePicker.Enabled = !ReturnDateDateTimePicker.Enabled;
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectBook(object sender, EventArgs e)
        {
            var selectBook = new SelectBookForm();
            selectBook.ShowDialog();
            if (selectBook.Book == null)
            {
                MessageBox.Show(@"No book selected, please select a book and try again", @"No book selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Book = selectBook.Book;
                SelectedBookLabel.Text = Book.ToString();
            }
        }

        private void SelectStudent(object sender, EventArgs e)
        {
            var selectStudent = new SelectStudentForm();
            selectStudent.ShowDialog();
            if (selectStudent.Student == null)
            {
                MessageBox.Show(@"No student selected, please select a student and try again", @"No student selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Student = selectStudent.Student;
                SelectedStudentLabel.Text = Student.ToString();
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            EditLoan();
            MessageBox.Show(@"Student successfully edited", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public bool IsInCorrectFormat()
        {
            if (Book == null)
            {
                MessageBox.Show(@"Select a book first", @"No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Student == null)
            {
                MessageBox.Show(@"Select a student first", @"No student selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (IsBookReturnedCheckBox.Checked)
            {
                if (ReturnDateDateTimePicker.Value < LoanDateDateTimePicker.Value)
                {
                    MessageBox.Show(@"Loan date cannot be later than the return date",
                        @"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _loan.ReturnDate = ReturnDateDateTimePicker.Value;
                return true;
            }

            _loan.ReturnDate = null;
            return true;
        }

        public void EditLoan()
        {
            var loanToEdit = _context.Loans.Find(_loan.LoanId);
            loanToEdit.BookId = Book.BookId;
            loanToEdit.StudentId = Student.StudentId;
            loanToEdit.LoanDate = LoanDateDateTimePicker.Value;
            loanToEdit.ReturnDate = _loan.ReturnDate.Value;
            _context.SaveChanges();
        }
    }
}
