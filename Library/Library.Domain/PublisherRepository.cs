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
    public class PublisherRepository
    {
        public PublisherRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public Publisher GetPublisher(int id)
        {
            return _context.Publishers.Include(publisher => publisher.Books).ToList().FirstOrDefault(publisher => publisher.PublisherId == id);
        }

        public List<Publisher> GetAllPublishers()
        {
            return _context.Publishers.Include(publisher => publisher.Books).ToList();
        }

        public void AddPublisher(Publisher publisherToAdd)
        {
            _context.Publishers.Add(publisherToAdd);
            _context.SaveChanges();
        }
    }
}
