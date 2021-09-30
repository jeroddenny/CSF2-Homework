using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Book
    {
        //fields
        private string _title;
        private string _author;
        private int _numberOfPages;

        //props
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }


        //ctor
        public Book() { }
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }
        //methods
        public override string ToString()
        {
            return string.Format($"Title: {Title}\nAuthor: {Author}\nNumber of Pages: {NumberOfPages}");
        }

    }
}
