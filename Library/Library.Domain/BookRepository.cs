using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Data.Models;
using Microsoft.EntityFrameworkCore;

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
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.Include(book => book.Loans).ToList();
        }

        public void DeleteBook(Book bookToDelete)
        {
            _context.Books.Remove(GetBook(bookToDelete.BookId));
            _context.SaveChanges();
        }
    }
}
