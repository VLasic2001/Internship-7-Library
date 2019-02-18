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

namespace Library.Presentation.LoanForms
{
    public partial class LoanDetails : Form
    {
        private Loan _loan { get; set; }

        public LoanDetails(Loan loan)
        {
            InitializeComponent();
            _loan = loan;
            UpdateForm();
        }

        public void UpdateForm()
        {
            BookLabel.Text = $"Book: {_loan.Book}";
            StudentLabel.Text = $"Student: {_loan.Student}";
            LoanDateLabel.Text = $"Loan Date: {_loan.LoanDate.ToShortDateString()}";
            ReturnDateLabel.Text = ReturnDateCalculator();
            
        }

        public string ReturnDateCalculator()
        {
            return _loan.IsLoanActive() ? "Loan is still active" : $"Return Date: {_loan.ReturnDate.Value.ToShortDateString()}";
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
