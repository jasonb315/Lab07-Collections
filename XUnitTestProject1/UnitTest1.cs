using System;
using Xunit;
using LendingLibrary.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void CreateLibrary()
        {
            Library<Book> library = new Library<Book>();
            Assert.IsType<Library<Book>>(library);
        }

        [Fact]
        public void AddBook()
        {
            Library<Book> library = new Library<Book>();
            library.Add(new Book("Harry Potter", new Author("J.K. Rawling"), Book.Genres.Fantasy));
            int count = library.Count();
            Assert.Equal(1, count);
        }

        [Fact]
        public void RemoveBook()
        {
            Library<Book> library = new Library<Book>();

            Book book = new Book("1989", new Author("George Orwell"), Book.Genres.Romance);

            library.Add(book);
            int count = library.Count();

            Assert.Equal(1, count);

            library.Remove(book);

            count = library.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void GetSetBookTitle()
        {
            Book book = new Book("Harry Potter", new Author("J.K. Rawling"), Book.Genres.Fantasy);
            Assert.Equal("Harry Potter", book.Title);
        }

        [Fact]
        public void GetSetBookAuthor()
        {
            Book book = new Book("Harry Potter", new Author("J.K. Rawling"), Book.Genres.Fantasy);
            Assert.IsType<Author>(book.writer);
        }

        [Fact]
        public void LibraryCount()
        {
            Library<Book> library = new Library<Book>();
            library.Add(new Book("Harry Potter", new Author("J.K. Rawling"), Book.Genres.Fantasy));
            library.Add(new Book("Harry Potter", new Author("J.K. Rawling"), Book.Genres.Fantasy));
            library.Add(new Book("Harry Potter", new Author("J.K. Rawling"), Book.Genres.Fantasy));
            library.Add(new Book("Harry Potter", new Author("J.K. Rawling"), Book.Genres.Fantasy));

            int count = library.Count();
            Assert.Equal(4, count);
        }
    }
}
