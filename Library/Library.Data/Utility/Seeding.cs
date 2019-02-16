using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Data.Models;

namespace Library.Data.Utility
{
    public static class Seeding
    {
        public static void SeedingData()
        {
            
            var context = new LibraryContext();
            if (!context.Authors.Any())
            {
                context.Authors.AddRange(new Author {FirstName = "Luka", LastName = "Lukanovic"},
                    new Author {FirstName = "Filip", LastName = "Filipovic"},
                    new Author {FirstName = "Roko", LastName = "Rokic"});
            }

            if (!context.Publishers.Any())
            {
                context.Publishers.AddRange(
                    new Publisher {Name = "Black Library"},
                    new Publisher {Name = "HarperCollins"},
                    new Publisher {Name = "Parragon"});
            }

            context.SaveChanges();
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Name = "Treasure Island", NumberOfPages = 143, Genre = Genre.Adventure, AuthorId = 1,
                        PublisherId = 1
                    },
                    new Book
                    {
                        Name = "Love Story", NumberOfPages = 657, Genre = Genre.Romance, AuthorId = 2,
                        PublisherId = 2
                    },
                    new Book
                    {
                        Name = "Dracula", NumberOfPages = 143, Genre = Genre.Horror, AuthorId = 3,
                        PublisherId = 3
                    });
            }

            context.SaveChanges();
            if (!context.Students.Any())
            {
                context.Students.AddRange(
                    new Student
                    {
                        FirstName = "Toni", LastName = "Tonicevic",
                        DateOfBirth = new DateTime(2001 / 06 / 10), Gender = Gender.Male, Class = "3.b"
                    },
                    new Student
                    {
                        FirstName = "Ana", LastName = "Anic", DateOfBirth = new DateTime(2003 / 02 / 03),
                        Gender = Gender.Female, Class = "1.c"
                    },
                    new Student
                    {
                        FirstName = "Tomislav", LastName = "Tomicic",
                        DateOfBirth = new DateTime(1997 / 12 / 31), Gender = Gender.Male, Class = "4.a"
                    });
            }

            context.SaveChanges();
        }
    }
}
