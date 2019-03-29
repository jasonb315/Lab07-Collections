using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author writer { get; set; }
        public Genres genre { get; set; }
        public enum Genres
        {
            Horror,
            History,
            Romance,
            Psychology,
            Fantasy,
            scifi,
            theology
        }
        
        public Book(string title, Author w, Genres g)
        {
            Title = title;
            writer = w;
            genre = g;

        }
    }
}
