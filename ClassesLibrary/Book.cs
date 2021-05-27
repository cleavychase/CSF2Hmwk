using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields
        private string _title;
        private string _author;
        private int _nbrOfPages;
        

        //properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public int NbrOfPages
        {
            get { return _nbrOfPages; }
            set { _nbrOfPages = value; }
        }
        public Book(string title, string author, int nbrOfPages)
        {
            //Prop = param;
            Title = title;
            Author = author;
            NbrOfPages = nbrOfPages;


        }
        public Book()
        {

        }
        public override string ToString()
        {
            return string.Format("Title: {0} \n" + "Author: {1}\n" +
                "Number of Pages: {2}\n", Title, Author, NbrOfPages);
        }

        }
}
