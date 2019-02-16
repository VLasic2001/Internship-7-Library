﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain
{
    public class BookRepository
    {
        public BookRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public Book GetBook(int id)
        {
            return _context.Books.Find(id);
        }

        public void AddBook(string name, int numberOfPages, Genre genre, int authorId, int publisherId)
        {
            _context.Books.Add(new Book
            {
                Name = name,
                NumberOfPages = numberOfPages,
                Genre = genre,
                AuthorId = authorId,
                PublisherId = publisherId
            });
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public void DeleteBook(Book bookToDelete)
        {
            _context.Books.Remove(bookToDelete);
            _context.SaveChanges();
        }
    }
}
