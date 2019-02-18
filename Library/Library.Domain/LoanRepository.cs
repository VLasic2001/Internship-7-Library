using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain
{
    public class LoanRepository
    {
        public LoanRepository()
        {
            _context = new LibraryContext();
        }

        private LibraryContext _context;

        public Loan GetLoanWithInclude(int id)
        {
            return _context.Loans.Include(loan => loan.Book).Include(loan => loan.Student).FirstOrDefault(loan => loan.LoanId == id);
        }

        public Loan GetLoan(int id)
        {
            return _context.Loans.Find(id);
        }

        public List<Loan> GetAllLoans()
        {
            return _context.Loans.ToList();
        }

        public void AddLoan(Loan loanToAdd)
        {
            _context.Loans.Add(loanToAdd);
            _context.SaveChanges();
        }

        public void DeleteLoan(Loan loanToDelete)
        {
            _context = new LibraryContext();
            var loan = GetLoanWithInclude(loanToDelete.LoanId);
            _context.Loans.Remove(loan);
            _context.SaveChanges();
        }

        public void ReturnLoan(Loan loan, DateTime returnDate)
        {
            _context.Loans.Find(loan.LoanId).ReturnDate = returnDate;
            _context.SaveChanges();
        }
    }
}
