using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Library
    {
        //fields
        private List<Book> _books;
        private string _libraryName;
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;


        //props
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }


        //ctor
        public Library() { }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }
        public override string ToString()
        {
            string libraryBooks = "";

            foreach (Book book in Books)
            {
                libraryBooks += book + "\n";
            }

            return string.Format($"Books in Library: \n{libraryBooks} \nLibrary Name: {LibraryName}\n Street Address: {StreetAddress}\n City: {City}\n State: {State}\n Zip: {Zip}");
        }



        //methods
    }
}
