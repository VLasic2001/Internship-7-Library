using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities.Models;

namespace Library.Data.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Books.Count > 0 ? $"{Name} - {Books.Count} books ({Books.FirstOrDefault()}...)" : $"{Name}";
        }
    }
}
