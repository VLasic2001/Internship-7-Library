using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Models;
using Library.Domain;

namespace Library.Presentation.LoanForms
{
    public partial class ListOfLoansForm : Form
    {
        private LoanRepository _loanRepository { get; set; }
        private BookRepository _bookRepository { get; set; }
        private StudentRepository _studentRepository { get; set; }

        public ListOfLoansForm()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
            _studentRepository = new StudentRepository();
            UpdateList();
        }

        public void UpdateList()
        {
            _loanRepository = new LoanRepository();
            LoansListBox.Items.Clear();
            foreach (var loan in _loanRepository.GetAlLoans())
            {
                loan.Book = _bookRepository.GetBook(loan.BookId);
                loan.Student = _studentRepository.GetStudent(loan.StudentId);
                LoansListBox.Items.Add(loan);
            }
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
            if (MessageBox.Show($@"Are you sure you want to delete {selection.Book.Name} - {selection.Student.FirstName}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            _loanRepository.DeleteLoan(selection);
            UpdateList();
        }
    }
}
