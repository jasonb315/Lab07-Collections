using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Library<T> : IEnumerable
    {
        T[] books = new T[10];
        int count = 0;

        /// <summary>
        ///     Add a book to the library
        /// </summary>
        /// <param name="book">Book book</param>
        public void Add(T book)
        {
            if( count == books.Length )
            {
                Array.Resize( ref books, books.Length * 2 );
            }
            books[count++] = book;
        }

        /// <summary>
        ///     Remove a book from the library
        /// </summary>
        /// <param name="book">Book book</param>
        public void Remove(T book)
        {

            T[] temp = new T[count];

            int counter = 0;

            foreach( T b in books)
            {
                if( b != null && !b.Equals(book) )
                {
                    temp[counter] = b;
                    counter++;
                }
            }

            books = temp;

            if (counter != count)
            {
                Array.Resize( ref books, books.Length - 1 );
                count -= 1;
            }

        }

        /// <summary>
        ///     Return the number of books in the library
        /// </summary>
        /// <returns>int book count</returns>
        public int Count()
        {
            return count;
        }

        /// <summary>
        ///     Ienumerator yeilds book by index
        /// </summary>
        /// <returns>IEnumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for( int i = 0 ; i < count ; i++ )
            {
                yield return books[i];
            }
        }

        // Magic. Don't Touch.
        // C# 1.0 support
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
