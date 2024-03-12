using BookList;
using System;

namespace BookListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList.BookList list = new BookList.BookList();

            list.AddBook("Book1");
            list.AddBook("Book2");
            list.AddBook("Book3");

            list.DisplayBooks();

            Console.WriteLine("Removing Book2");
            list.RemoveBook("Book2");

            list.DisplayBooks();

            Console.WriteLine("Is 'Book1' in the list? " + (list == "Book1"));

            Console.WriteLine("Number of books: " + list.Count);

            Console.WriteLine("Book at index 0: " + list[0]);

            list[0] = "NewBook1";

            Console.WriteLine("Updated book at index 0: " + list[0]);

            Console.ReadKey();
        }
    }
}