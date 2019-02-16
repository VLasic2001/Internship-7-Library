using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain
{
    public class AuthorRepository
    {
        public AuthorRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public Author GetAuthor(int id)
        {
            return _context.Authors.Include(author => author.Books).ToList().FirstOrDefault(author => author.AuthorId == id);
        }

        public List<Author> GetAllAuthors()
        {
            return _context.Authors.Include(author => author.Books).ToList();
        }
    }
}
