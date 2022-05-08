using _10._5._2022Task2.Enums;
using _10._5._2022Task2.Interfaces;
using _10._5._2022Task2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10._5._2022Task2.Services
{
    class LibraryManager : ILibraryManager
    {
        public List<Book> Books { get; }

        public LibraryManager()
        {
            Books = new List<Book>();
        }

        public void Add(Book book)
        {
            List<Book> books = new List<Book>();
            //List<Book> books1 = Books.FindAll(b => b.Name.ToLower() == book.Name.ToLower());
            if (Books.Exists(b => b.Name.ToLower() == book.Name.ToLower()))
            {
                throw new Exception("SameBookalreadyAddedExpection");
            }
            else
            {
                Books.Add(book);
            }
        }
        public List<Book> Filter(string author, Genre genre)
        {
           List<Book> books = Books.FindAll(b => b.Author.ToLower() == author.ToLower() || b.Genre.ToString() == genre.ToString());
            return books;
        }
        public List<Book> Search(string search)
        {
            List<Book> books = Books.FindAll(b => b.Name.ToLower() == search.ToLower() || b.Author.ToLower() == search.ToLower() || b.Genre.ToString().ToLower() == search.ToLower() || b.PageCount.ToString() == search);
            return books;
        }
        public Book ShowInfo(string name)
        {
            Book book = Books.Find(b => b.Name.ToLower() == name.ToLower());
            if (book == null)
            {
                throw new Exception("BookNotFoundException");
            }
            return book;
            
        }
    }
}
