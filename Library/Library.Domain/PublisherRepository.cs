using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Models;

namespace Library.Domain
{
    public class PublisherRepository
    {
        public PublisherRepository(LibraryContext context)
        {
            _context = context;
        }

        private readonly LibraryContext _context;

        public Publisher GetPublisher(int id)
        {
            return _context.Publishers.Find(id);
        }
    }
}
