using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Enums;
using Library.Data.Models;

namespace Library.Data.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int NumberOfPages { get; set; }
        public Genres Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
    }
}
