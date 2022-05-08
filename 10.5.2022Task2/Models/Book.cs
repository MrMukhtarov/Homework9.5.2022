using _10._5._2022Task2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10._5._2022Task2.Models
{
    class Book
    {
    
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public Genre Genre { get; set; }

        public Book(string name, string author, int pagecount, Genre genre)
        {
            Name = name;
            Author = author;
            PageCount = pagecount;
            Genre = genre;
        }

        public override string ToString()
        {
            return $" Name: {Name}\n Author: {Author}\n Page Count: {PageCount}\n Genre: {Genre}";
        }
    }
}
