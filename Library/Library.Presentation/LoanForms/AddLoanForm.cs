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
using Library.Presentation.Popups;

namespace Library.Presentation.LoanForms
{
    public partial class AddLoanForm : Form
    {
        private Book _book { get; set; }
        private Student _student { get; set; }

        public AddLoanForm()
        {
            InitializeComponent();
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
    }
}
