using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Models;

namespace Library.Domain
{
    public class StudentRepository
    {
        public StudentRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public Student GetStudent(int id)
        {
            return _context.Students.Find(id);
        }
    }
}
