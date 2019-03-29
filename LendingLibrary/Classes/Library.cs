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

        public void Add(T book)
        {
            if( count == books.Length )
            {
                Array.Resize( ref books, books.Length * 2 );
            }
            books[count++] = book;
        }

        public void Remove(T book)
        {

            T[] temp = new T[count];

            int counter = 0;

            foreach( T b in books)
            {
                if( !b.Equals(book) )
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

        public int Count()
        {
            return count;
        }

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
