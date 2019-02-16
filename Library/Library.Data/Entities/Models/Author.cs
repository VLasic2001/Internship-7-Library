using System.Collections.Generic;
using System.Linq;
using Library.Data.Models;

namespace Library.Data.Entities.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    

        public override string ToString()
        {
            return Books.Count > 0 ? $"{FirstName} {LastName} - {Books.Count} books ({Books.FirstOrDefault()}...)" : $"{FirstName} {LastName}";
        }
    }
}
