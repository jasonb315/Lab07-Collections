using LendingLibrary.Classes;
using System;
using System.Collections.Generic;

namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
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


            foreach(Book book in library)
            {
                Console.WriteLine($"{book.writer.Name} wrote {book.Title}");
            }

            List<Book> readerA = new List<Book>();
            List<Book> readerB = new List<Book>();

            Console.WriteLine(".....................");

            foreach (Book book in library)
            {
                if (book.genre == Book.Genres.Fantasy)
                {
                    //library.Remove(book);
                    readerA.Add(book);
                    Console.WriteLine("ding");
                }

            }

            foreach (Book book in readerA)
            {
                Console.WriteLine($"{book.writer.Name} wrote {book.Title}");
            }

        }
    }
}
