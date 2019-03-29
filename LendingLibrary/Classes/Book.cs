using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author writer { get; set; }
        public enum Genres
        {
            Horror,
            History,
            Romance,
            Psychology
        }
    }
}
