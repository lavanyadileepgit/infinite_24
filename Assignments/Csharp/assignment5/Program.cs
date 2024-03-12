using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}, Author: {AuthorName}");
        }
    }

    public class BookShelf
    {
        private Books[] _books = new Books[5];

        public Books this[int index]
        {
            get { return _books[index]; }
            set { _books[index] = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1}:");
                Console.Write("Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Author Name: ");
                string authorName = Console.ReadLine();

                shelf[i] = new Books(bookName, authorName);
            }

            Console.WriteLine("\nBook details stored in the bookshelf:");
            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }

            Console.ReadLine();
        }
    }


}
