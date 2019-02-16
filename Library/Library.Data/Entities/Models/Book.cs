using System.Collections.Generic;
using Library.Data.Enums;
using Library.Data.Models;

namespace Library.Data.Entities.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }

        public ICollection<Loan> Loans { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
