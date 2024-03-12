using System;
using System.Collections.Generic;
using System.Linq;

namespace BookList
{
    public class BookList
    {
        private List<string> books;

        public BookList()
        {
            books = new List<string>();
        }

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(string book)
        {
            books.Remove(book);
        }

        public bool ContainsBook(string book)
        {
            return books.Contains(book);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in the list:");
            foreach (var b in books)
            {
                Console.WriteLine(b);
            }
        }

        public int Count
        {
            get { return books.Count; }
        }

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public static BookList operator +(BookList list, string book)
        {
            list.AddBook(book);
            return list;
        }

        public static BookList operator -(BookList list, string book)
        {
            list.RemoveBook(book);
            return list;
        }

        public static bool operator ==(BookList list, string book)
        {
            return list.ContainsBook(book);
        }

        public static bool operator !=(BookList list, string book)
        {
            return !list.ContainsBook(book);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            BookList other = (BookList)obj;
            return books.SequenceEqual(other.books);
        }

        public override int GetHashCode()
        {
            return books.GetHashCode();
        }
    }
}