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
    public class StudentRepository
    {
        public StudentRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public Student GetStudent(int id)
        {
            return _context.Students.Include(student => student.Loans).FirstOrDefault(student => student.StudentId == id);
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.Include(student => student.Loans).ToList();

        }

        public void AddStudent(Student studentToAdd)
        {
            _context.Students.Add(studentToAdd);
            _context.SaveChanges();
        }

        public void DeleteStudent(Student studentToRemove)
        {
            _context.Students.Remove(GetStudent(studentToRemove.StudentId));
            _context.SaveChanges();
        }
    }
}
