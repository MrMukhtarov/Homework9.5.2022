using System;
using System.Collections.Generic;
using System.Text;

namespace _10._5._2022.Models
{
    class Book
    {
        private static int _count;
        public string Code { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        List<Book> Books = new List<Book>();

        static Book()
        {
            _count = 1;
        }
        public Book(string name, string authorName, int pageCount)
        {
            Books = new List<Book>();
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            _count++;
            Code = $"{name.Substring(0, 2).ToUpper()}{_count}";
            Console.WriteLine(Code);
        }
        public override string ToString()
        {
            return $"{Name} {AuthorName} {PageCount} {Code}";
        }

    }
}
