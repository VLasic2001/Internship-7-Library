using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Models;

namespace Library.Domain
{
    public class BookRepository
    {
        public BookRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public Book GetBook(int id)
        {
            return _context.Books.Find(id);
        }

        public void AddBook(Book bookToAdd)
        {
            _context.Books.Add(bookToAdd);
        }
    }
}
