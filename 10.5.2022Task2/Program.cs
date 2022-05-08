using _10._5._2022Task2.Models;
using _10._5._2022Task2.Services;
using System;

namespace _10._5._2022Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager libraryManager = new LibraryManager();
            libraryManager.Books.Add(new Book("Seytan Incili", "Patrick Graham", 300,Enums.Genre.ScienceFiction));
            libraryManager.Books.Add(new Book("Deccal", "Fridrix Nitsche", 250, Enums.Genre.Detective));
            libraryManager.Books.Add(new Book("Aeroprt", "Arthur Haley", 700, Enums.Genre.Detective));
            libraryManager.Books.Add(new Book("Mars Xronikalari", "Rey Berdeberi", 410 ,Enums.Genre.ScienceFiction));
            libraryManager.Books.Add(new Book("Sahmat", "Stefan Svayq", 300, Enums.Genre.ScienceFiction));
            //Book book = new Book("Deccal", "Fridrix Nitsche", 250, Enums.Genre.Detective);
            //libraryManager.Add(book);
            //libraryManager.ShowInfo("Sahmat");
            //foreach (var item in libraryManager.Filter("Arthur Haley", Enums.Genre.ScienceFiction))
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(libraryManager.ShowInfo("Sahmat"));
        }
    }
}
