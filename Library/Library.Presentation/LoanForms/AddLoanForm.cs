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
using Library.Data.Models;
using Library.Domain;
using Library.Presentation.Popups;

namespace Library.Presentation.LoanForms
{
    public partial class AddLoanForm : Form
    {
        private Book _book { get; set; }
        private Student _student { get; set; }
        private DateTime? _returnDate { get; set; }
        private LoanRepository _loanRepository { get; set; }

        public AddLoanForm()
        {
            InitializeComponent();
            _loanRepository = new LoanRepository();
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
                _book = selectBook.Book;
                SelectedBookLabel.Text = _book.ToString();
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
                _student = selectStudent.Student;
                SelectedStudentLabel.Text = _student.ToString();
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInValidFormat()) return;
            CreateAndAddLoan();
            MessageBox.Show(@"Student successfully added", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public bool IsInValidFormat()
        {
            if (_book == null)
            {
                MessageBox.Show(@"No book selected, please select a book and try again", @"No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_student == null)
            {
                MessageBox.Show(@"No student selected, please select a student and try again", @"No student selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _returnDate = ReturnDateDateTimePicker.Value;
                return true;
            }

            _returnDate = null;
            return true;
        }

        public void CreateAndAddLoan()
        {
            _loanRepository.AddLoan(new Loan(_book.BookId, _student.StudentId, LoanDateDateTimePicker.Value, _returnDate));
        }
    }
}
