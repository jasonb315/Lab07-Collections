using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Library<T> : IEnumerable
    {
        T[] numbers = new T[5];
        int count = 0;

        public void Add(T number)
        {
            if( count == numbers.Length )
            {
                Array.Resize( ref numbers, numbers.Length * 2 );
            }
            numbers[count++] = number;
        }

        public void Remove(T number)
        {
            T[] temp = new T[count];
            int counter = 0;

            foreach( T b in numbers )
            {
                if( !b.Equals(numbers) )
                {
                    temp[counter] = b;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            numbers = temp;

            if (counter != count)
            {
                Array.Resize( ref numbers, ( numbers.Length - 1 ));
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
                yield return numbers[i];
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
