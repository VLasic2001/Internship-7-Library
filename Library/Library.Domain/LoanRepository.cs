using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Models;

namespace Library.Domain
{
    public class LoanRepository
    {
        public LoanRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public Loan GetLoan(int id)
        {
            return _context.Loans.Find(id);
        }

        public List<Loan> GetAlLoans()
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
            _context.Loans.Remove(loanToDelete);
            _context.SaveChanges();
        }
    }
}
