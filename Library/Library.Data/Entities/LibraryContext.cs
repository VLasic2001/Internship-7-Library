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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, FirstName = "Luka", LastName = "Lukanovic", Books = new List<Book>()},
                new Author { AuthorId = 2, FirstName = "Filip", LastName = "Filipovic", Books = new List<Book>() },
                new Author { AuthorId = 3, FirstName = "Roko", LastName = "Rokic", Books = new List<Book>() }
            );

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { PublisherId = 1, Name = "Black Library", Books = new List<Book>() },
                new Publisher { PublisherId = 2, Name = "HarperCollins", Books = new List<Book>() },
                new Publisher { PublisherId = 3, Name = "Parragon", Books = new List<Book>() }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Name = "Treasure Island", NumberOfPages = 143, Genre = Genre.Adventure },
                new Book { BookId = 2, Name = "Love Story", NumberOfPages = 657, Genre = Genre.Romance },
                new Book { BookId = 3, Name = "Dracula", NumberOfPages = 143, Genre = Genre.Horror }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Toni", LastName = "Tonicevic", DateOfBirth = new DateTime(2001 / 06 / 10), Gender = Gender.Male, Class = "3.b" },
                new Student { StudentId = 2, FirstName = "Ana", LastName = "Anic", DateOfBirth = new DateTime(2003 / 02 / 03), Gender = Gender.Female, Class = "1.c" },
                new Student { StudentId = 3, FirstName = "Tomislav", LastName = "Tomicic", DateOfBirth = new DateTime(1997 / 12 / 31), Gender = Gender.Male, Class = "4.a" }
            );
        }
    }
}
