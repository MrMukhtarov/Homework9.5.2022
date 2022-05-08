using System;
using System.Collections.Generic;
using System.Text;

namespace _10._5._2022.Models
{
    class Library
    {
        
        public List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> books = Books.FindAll(b => b.Name.ToLower().Contains(value.ToLower()));
            return books;
            #region
            //List<Book> books = new List<Book>();
            //foreach (Book book in Books)
            //{
            //    if (book.Name.ToLower() == value.ToLower())
            //    {
            //        books.Add(book);
            //    }
            //}
            //foreach (var item in books)
            //{
            //    Console.WriteLine(item);
            //}
            //return books;
            #endregion
        }

        public void RemoveAllBookByName(string value)
        {
            Books.RemoveAll(b => b.Name.ToLower().Contains(value.ToLower()));
            
        }

        public List<Book> SearchBooks(string search)
        {
            List<Book> books = Books.FindAll(b => b.Name.ToLower() == search.ToLower() || b.AuthorName.ToLower() == search.ToLower() || b.PageCount.ToString() == search);

            foreach (Book item in books)
            {
                Console.WriteLine(item);
            }
            return books;
        }

        public List<Book> FindAllBooksByPageCountRange(int minimum, int maximum)
        {
            //return Books.FindAll(b => b.PageCount >= minimum && b.PageCount <= maximum);
            List<Book> books = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.PageCount > minimum && book.PageCount < maximum)
                {
                    books.Add(book);
                }
            }
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
            return books;
        }
        public void RemoveByNo(string code)
        {
            Books.RemoveAll(b => b.Code.ToLower() == code.ToLower());
            #region
            //    List<Book> books = new List<Book>();

            //if (book != null)
            //{
            //    Books.Remove(book);
            //}
            #endregion
        }
    }
}
