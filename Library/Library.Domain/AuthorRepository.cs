using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Models;

namespace Library.Domain
{
    public class AuthorRepository
    {
        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        private readonly LibraryContext _context;

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }
    }
}
