using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data.Entities
{
    public class LibraryContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LibraryDatabase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 1, FirstName = "Luka", LastName = "Lukanovic"});
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 2, FirstName = "Filip", LastName = "Filipovic"});
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 3, FirstName = "Ivan", LastName = "Ivanovic"});
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 4, FirstName = "Stipe", LastName = "Stipic"});
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 5, FirstName = "Josip", LastName = "Josipovic"});
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 6, FirstName = "Nikola", LastName = "Nikolic"});
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 7, FirstName = "Roko", LastName = "Rokic"});

            modelBuilder.Entity<Publisher>().HasData(new Publisher { PublisherId = 1, Name = "Black Library" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { PublisherId = 2, Name = "HarperCollins" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { PublisherId = 3, Name = "Baen Books" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { PublisherId = 4, Name = "Ballantine Books" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { PublisherId = 5, Name = "Firebrand Books" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { PublisherId = 6, Name = "Hay House" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { PublisherId = 7, Name = "Parragon" });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Name = "Treasure Island",
                NumberOfPages = 143,
                Genre = Genre.Adventure,
                NumberOfCopies = 10,
                AuthorId = 1,
                PublisherId = 1
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Name = "Love Story",
                NumberOfPages = 657,
                Genre = Genre.Romance,
                NumberOfCopies = 15,
                AuthorId = 2,
                PublisherId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                Name = "Adrenaline",
                NumberOfPages = 216,
                Genre = Genre.Action,
                NumberOfCopies = 15,
                AuthorId = 3,
                PublisherId = 3
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                Name = "In Cold Blood",
                NumberOfPages = 457,
                Genre = Genre.Crime,
                NumberOfCopies = 20,
                AuthorId = 4,
                PublisherId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                Name = "Romeo and Juliet",
                NumberOfPages = 480,
                Genre = Genre.Drama,
                NumberOfCopies = 40,
                AuthorId = 5,
                PublisherId = 5
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 6,
                Name = "A Princess Of Mars",
                NumberOfPages = 356,
                Genre = Genre.Fantasy,
                NumberOfCopies = 5,
                AuthorId = 6,
                PublisherId = 6
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 7,
                Name = "Animal Farm",
                NumberOfPages = 112,
                Genre = Genre.Satire,
                NumberOfCopies = 40,
                AuthorId = 3,
                PublisherId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 8,
                Name = "Dracula",
                NumberOfPages = 143,
                Genre = Genre.Horror,
                NumberOfCopies = 30,
                AuthorId = 2,
                PublisherId = 1
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 1,
                FirstName = "Toni",
                LastName = "Tonicevic",
                DateOfBirth = new DateTime(2001, 06, 10),
                Gender = Gender.Male,
                Class = "3.b"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 2,
                FirstName = "Ana",
                LastName = "Anic",
                DateOfBirth = new DateTime(2003, 02, 03),
                Gender = Gender.Female,
                Class = "1.c"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 3,
                FirstName = "Leo",
                LastName = "Leovic",
                DateOfBirth = new DateTime(2001, 08, 10),
                Gender = Gender.Male,
                Class = "3.b"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 4,
                FirstName = "Dora",
                LastName = "Doric",
                DateOfBirth = new DateTime(2003, 02, 03),
                Gender = Gender.Female,
                Class = "1.c"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 5,
                FirstName = "Leon",
                LastName = "Loencevic",
                DateOfBirth = new DateTime(2001, 07, 14),
                Gender = Gender.Male,
                Class = "3.b"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 6,
                FirstName = "Ivana",
                LastName = "Ivanic",
                DateOfBirth = new DateTime(2003, 02, 03),
                Gender = Gender.Female,
                Class = "1.c"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 7,
                FirstName = "Tomislav",
                LastName = "Tomicic",
                DateOfBirth = new DateTime(1997, 12, 31),
                Gender = Gender.Male,
                Class = "4.a"
            });

            modelBuilder.Entity<Loan>().HasData(new Loan
            {
                LoanId = 1,
                StudentId = 1,
                BookId = 1,
                LoanDate = new DateTime(2019, 01, 01),
                ReturnDate = null
            });
            modelBuilder.Entity<Loan>().HasData(new Loan
            {
                LoanId = 2,
                StudentId = 2,
                BookId = 2,
                LoanDate = new DateTime(2019, 02, 01),
                ReturnDate = null
            });
            modelBuilder.Entity<Loan>().HasData(new Loan
            {
                LoanId = 3,
                StudentId = 3,
                BookId = 3,
                LoanDate = new DateTime(2019, 01, 17),
                ReturnDate = new DateTime(2019, 02, 01)
            });
            modelBuilder.Entity<Loan>().HasData(new Loan
            {
                LoanId = 4,
                StudentId = 4,
                BookId = 3,
                LoanDate = new DateTime(2019, 02, 17),
                ReturnDate = null
            });
            modelBuilder.Entity<Loan>().HasData(new Loan
            {
                LoanId = 5,
                StudentId = 5,
                BookId = 2,
                LoanDate = new DateTime(2018, 12, 31),
                ReturnDate = null
            });
            modelBuilder.Entity<Loan>().HasData(new Loan
            {
                LoanId = 6,
                StudentId = 6,
                BookId = 7,
                LoanDate = new DateTime(2019, 01, 17),
                ReturnDate = new DateTime(2019, 02, 01)
            });

            modelBuilder.Entity<Loan>().HasOne(loan => loan.Book)
                .WithMany(book => book.Loans)
                .HasForeignKey(loan => loan.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Loan>().HasOne(loan => loan.Student)
                .WithMany(student => student.Loans)
                .HasForeignKey(loan => loan.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
