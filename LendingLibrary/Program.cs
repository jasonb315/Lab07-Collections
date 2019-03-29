using LendingLibrary.Classes;
using System;
using System.Collections.Generic;

namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string appName = "Library Lender";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
                Borrow();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Exiting Program");
            }
        }

        public static void Borrow()
        {
            Library<Book> library = new Library<Book>();
            library.Add(new Book("Harry Potter", new Author("J.K. Rawling"), Book.Genres.Fantasy));
            library.Add(new Book("1989", new Author("George Orwell"), Book.Genres.Romance));
            library.Add(new Book("Brave New World", new Author("Aldous Huxley"), Book.Genres.Psychology));
            library.Add(new Book("Red Fish Blue Fish", new Author("Dr. Seuss"), Book.Genres.Fantasy));
            library.Add(new Book("God Save The Queen", new Author("Brittish Guy"), Book.Genres.History));
            library.Add(new Book("Haloween", new Author("Mr. Pumpkin"), Book.Genres.Horror));
            library.Add(new Book("Electro Birds", new Author("Mr. Robot"), Book.Genres.scifi));
            library.Add(new Book("Rudeness", new Author("Flatiron"), Book.Genres.Psychology));
            library.Add(new Book("Wubbalubbadubdub", new Author("Rick"), Book.Genres.theology));
            library.Add(new Book("The God Molecule", new Author("Dr. Strauss"), Book.Genres.theology));

            // readout books
            Console.WriteLine("BOOKS IN LIBRARY");
            foreach (Book book in library)
            {
                Console.WriteLine($"{book.writer.Name} wrote {book.Title}");
            }

            // two readers
            List<Book> readerA = new List<Book>();
            List<Book> readerB = new List<Book>();

            // distribute books to readers
            foreach (Book book in library)
            {
                if (book.genre == Book.Genres.Fantasy)
                {
                    library.Remove(book);
                    readerA.Add(book);
                }
            }
            foreach (Book book in library)
            {
                if (book.genre == Book.Genres.Horror)
                {
                    library.Remove(book);
                    readerB.Add(book);
                }
            }

            // print the books that each reader checked out
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("READER A CHECKED OUT");
            foreach (Book book in readerA)
            {
                Console.WriteLine($"{book.writer.Name} wrote {book.Title}");
            }


            Console.WriteLine();
            Console.WriteLine("READER B CHECKED OUT");
            foreach (Book book in readerB)
            {
                Console.WriteLine($"{book.writer.Name} wrote {book.Title}");
            }


            // print out updated library contents
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("BOOKS IN LIBRARY");
            foreach (Book book in library)
            {
                Console.WriteLine($"{book.writer.Name} wrote {book.Title}");
            }

        }
    }
}
