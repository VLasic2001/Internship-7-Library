using System;
using System.Collections.Generic;
using Library.Data.Enums;
using Library.Data.Models;

namespace Library.Data.Entities.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Class { get; set; }

        public ICollection<Loan> Loans { get; set; }

        public Student()
        {
            
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, Gender gender, string studentClass)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Class = studentClass;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Class}";
        }
    }
}
