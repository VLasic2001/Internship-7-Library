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

namespace Library.Presentation.LoanForms
{
    public partial class ListOfLoansForm : Form
    {
        private LoanRepository _loanRepository { get; set; }
        private BookRepository _bookRepository { get; set; }
        private StudentRepository _studentRepository { get; set; }
        public bool ShowActive { get; set; }
        public List<Loan> Loans { get; set; }

        public ListOfLoansForm()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
            _studentRepository = new StudentRepository();
            _loanRepository = new LoanRepository();
            Loans = _loanRepository.GetAllLoans();
            ShowActive = false;
            UpdateList();
        }

        public void UpdateList()
        {
            StudentClassComboBox.Items.Clear();
            StudentClassComboBox.Items.Add("");
            foreach (var studentClass in _studentRepository.GetAllStudents().GroupBy(student => student.Class).OrderBy(student => student.Key))
            {
                StudentClassComboBox.Items.Add(studentClass.Key);
            }
            StudentClassComboBox.SelectedIndex = 0;

            LoansListBox.Items.Clear();
            foreach (var loan in Loans)
            {
                loan.Book = _bookRepository.GetBook(loan.BookId);
                loan.Student = _studentRepository.GetStudent(loan.StudentId);
                LoansListBox.Items.Add(loan);
            }

            NumberOfActiveLoansLabel.Text =
                $"Number Of Active Loans: {_loanRepository.GetAllLoans().Count(loan => loan.IsLoanActive())}";
            
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete(object sender, EventArgs e)
        {
            if (LoansListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the loan you want to delete", @"No loan selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selection = (Loan)LoansListBox.SelectedItem;
            if (MessageBox.Show($@"Are you sure you want to delete {selection.Book.Name} - {selection.Student.FirstName} {selection.Student.LastName}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            _loanRepository = new LoanRepository();
            _loanRepository.DeleteLoan(selection);
            UpdateList();
        }

        private void Details(object sender, EventArgs e)
        {
            if (LoansListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the loan you want to view the details of", @"No loan selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var loanDetails = new LoanDetails((Loan)LoansListBox.SelectedItem);
            loanDetails.ShowDialog();
            UpdateList();
        }

        private void Edit(object sender, EventArgs e)
        {
            if (LoansListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the loan you want to edit", @"No loan selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var editLoan = new EditLoanForm((Loan)LoansListBox.SelectedItem);
            editLoan.ShowDialog();
            UpdateList();
        }

        private void ShowActiveCheck(object sender, EventArgs e)
        {
            ShowActive = !ShowActive;
            Search(sender, e);
            UpdateList();
        }

        public List<Loan> ActiveListUpdate()
        {
            return ShowActive ? _loanRepository.GetAllLoans().Where(loan => loan.IsLoanActive()).ToList() : _loanRepository.GetAllLoans();
        }

        private void Search(object sender, EventArgs e)
        {
            var searchLoansList = new List<Loan>(ActiveListUpdate());

            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                searchLoansList = searchLoansList.Where(loan => loan.Student.FirstName.ToLower().Contains(FirstNameTextBox.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                searchLoansList = searchLoansList.Where(loan => loan.Student.LastName.ToLower().Contains(LastNameTextBox.Text.ToLower())).ToList();
            }

            if (StudentClassComboBox.SelectedIndex != 0)
            {
                searchLoansList = searchLoansList.Where(loan => loan.Student.Class == StudentClassComboBox.SelectedItem).ToList();
            }

            if (!string.IsNullOrWhiteSpace(BookNameTextBox.Text))
            {
                searchLoansList = searchLoansList.Where(loan => loan.Book.Name.ToLower().Contains(BookNameTextBox.Text.ToLower())).ToList();
            }

            if (searchLoansList.Count == 0)
            {
                MessageBox.Show(@"Change the search inputs and try again", @"No loan matches the search inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoansListBox.Items.Clear();
            if (searchLoansList.Count == _loanRepository.GetAllLoans().Count)
            {
                Loans = ActiveListUpdate();
                UpdateList();
                return;
            }

            Loans = searchLoansList;
            UpdateList();
        }
    }
}
