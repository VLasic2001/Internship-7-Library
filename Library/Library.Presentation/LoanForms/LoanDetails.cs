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
    public partial class LoanDetails : Form
    {
        private Loan _loan { get; set; }
        private LoanRepository _loanRepository { get; set; }

        public LoanDetails(Loan loan)
        {
            InitializeComponent();
            _loan = loan;
            UpdateForm();
        }

        public void UpdateForm()
        {
            _loanRepository = new LoanRepository();
            _loan = _loanRepository.GetLoanWithInclude(_loan.LoanId);
            BookLabel.Text = $"Book: {_loan.Book}";
            StudentLabel.Text = $"Student: {_loanRepository.GetLoan(_loan.LoanId).Student}";
            LoanDateLabel.Text = $"Loan Date: {_loan.LoanDate.ToShortDateString()}";
            ReturnDateLabel.Text = ReturnDateCalculator();
            if (_loan.IsLoanActive()) return;
            ReturnBookButton.Visible = false;
            ReturnBookButton.Enabled = false;
        }

        public string ReturnDateCalculator()
        {
            return _loan.IsLoanActive() ? "Loan is still active" : $"Return Date: {_loan.ReturnDate.Value.ToShortDateString()}";
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void ReturnBook(object sender, EventArgs e)
        {
            _loanRepository.ReturnLoan(_loan, DateTime.Now);
            UpdateForm();
        }

        private void Edit(object sender, EventArgs e)
        {
            var editLoan = new EditLoanForm(_loan);
            editLoan.ShowDialog();
            UpdateForm();
        }
    }
}
