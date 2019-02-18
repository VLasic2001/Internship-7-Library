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

namespace Library.Presentation.Features
{
    public partial class AddBookReportForm : Form
    {
        private StudentRepository _studentRepository { get; set; }
        private LoanRepository _loanRepository { get; set; }
        private Book _book { get; set; }

        public AddBookReportForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
            _loanRepository = new LoanRepository();
            SetupForm();
        }

        public void SetupForm()
        {
            ClassComboBox.Items.Clear();
            foreach (var studentClass in _studentRepository.GetAllStudents().GroupBy(student => student.Class).OrderBy(student => student.Key))
            {
                ClassComboBox.Items.Add(studentClass.Key);
            }

            ClassComboBox.SelectedIndex = 0;
        }

        public void UpdateForm()
        {
            SelectedBookReportLabel.Text = _book == null ? "No Book Report Selected" : $"{_book.Name}";
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            CreateAndAddBookReport(_studentRepository.GetAllStudents().Where(student => student.Class == ClassComboBox.Text).ToList());
            Close();
        }

        public bool IsInCorrectFormat()
        {
            if (_book != null) return true;
            MessageBox.Show("Select a book and try again", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }

        private void SelectBookReport(object sender, EventArgs e)
        {
            var selectBookReport = new SelectBookReportForm(GetNumberOfStudents(ClassComboBox.Text));
            selectBookReport.ShowDialog();
            if (selectBookReport.Book == null) return;
            _book = selectBookReport.Book;
            UpdateForm();
        }

        public int GetNumberOfStudents(string className)
        {
            return _studentRepository.GetAllStudents().Count(student => student.Class == className);
        }

        public void CreateAndAddBookReport(List<Student> students)
        {
            foreach (var student in students)
            {
                if (student.Loans.Count(loan => loan.BookId == _book.BookId) == 0)
                _loanRepository.AddLoan(new Loan(_book.BookId, student.StudentId, LoanDateDateTimePicker.Value, null));
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void LoanDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoanDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectedBookReportLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClassLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
