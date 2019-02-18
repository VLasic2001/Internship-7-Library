using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities.Models;

namespace Library.Data.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Loan()
        {

        }

        public Loan(int bookId, int studentId, DateTime loanDate, DateTime? returnDate)
        {
            BookId = bookId;
            StudentId = studentId;
            LoanDate = loanDate;
            ReturnDate = returnDate;
        }

        public override string ToString()
        {   
            return IsLoanActive() ? $"{Book.Name} - {Student.FirstName}, is active (loaned {Math.Ceiling((DateTime.Now-LoanDate).TotalDays)} days ago)" : $"{Book.Name} - {Student.FirstName}, was returned {ReturnDate.Value.ToShortDateString()}";
        }

        public bool IsLoanActive()
        {
            return ReturnDate == null;
        }
    }
}