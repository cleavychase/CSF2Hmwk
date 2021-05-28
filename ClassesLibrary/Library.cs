using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields -- N/A

        //props
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        //ctors
        public Library(List<Book> books, string libraryName, string streetAddress, string city,  string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }
        public Library()
        {

        }
        //methods
        public override string ToString()
        {
            //when dealing with writing collections out in a ToString(), it's best to build a string that will display the info.
            //for each collection (curriculum and roster), we will build a string variable to hold the desited info for each book or student
            string booksNeeded = "";

            foreach (Book book in Books)
            {
                booksNeeded += book + "\n";
            }
            //above we loop through each collection and assign the variable an added value for each book/student from the List being passed through in the property. we do this so that we ca actually see the bookTitles or studentName in their respective place in the return below.

            //below we replace directly calling the property value for curriculum and roster with their respective strings.

            return string.Format("\nBooks: {0}\t\tLibrary Name: {1}\n" +
                "Street Address: {2}\n" +
                "City: {3}\n" +
                "State: {4}\n" +
                "Zip: {5}\n",
                booksNeeded, LibraryName, StreetAddress, City, State, Zip);
        }
    }
}
