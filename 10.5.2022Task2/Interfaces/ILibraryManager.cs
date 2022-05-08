using _10._5._2022Task2.Enums;
using _10._5._2022Task2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10._5._2022Task2.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }

        void Add(Book book);

        Book ShowInfo(string name);

        List<Book> Search(string search);

        List<Book> Filter(string author, Genre genre);

    }
}
