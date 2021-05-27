using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n------Student Info------\n\n");
            
            Student s1 = new Student();
            s1.FirstName = "Caitlin";
            s1.LastName = "Chase";
            s1.ID = "1234";
            s1.GPA = 4.03f;

            
            Console.WriteLine(s1);

            Student s2 = new Student("John", "Batman", "0000", 2.5f);

            Console.WriteLine(s2);

            Console.WriteLine("\n\n------Vehicle Info------\n\n");

            Vehicle v1 = new Vehicle();
            v1.Make = "Ford";
            v1.Model = "Focus";
            v1.Year = 2006;
            v1.Weight = 2935;


            Console.WriteLine(v1);

            Vehicle v2 = new Vehicle("Jeep", "Cherokee", 1998, 4500);

            Console.WriteLine(v2);

            Console.WriteLine("\n\n------Loggin Info------\n\n");

            Loggin l1 = new Loggin();
            l1.UserName = "User1";
            l1.PassWord = "Pa55word";
            


            Console.WriteLine(l1);

            Loggin l2 = new Loggin("User2", "password");

            Console.WriteLine(l2);


            Console.WriteLine("\n\n------Contact Info------\n\n");

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "100 Main St";
            c1.City = "Independence";
            c1.State = "MO";
            c1.Zip = "64050";
            c1.Phone = "816.718.7420";
            c1.EMail = "email@internet.com";



            Console.WriteLine(c1);

            ContactInfo c2 = new ContactInfo("1212 Walnut Ave", "KC", "MO", "64111", "816.888.8888", "fake@madeup.com");

            Console.WriteLine(c2);

            Console.WriteLine("\n\n------Customer------\n\n");

            Customer cm1 = new Customer();
            cm1.CustomerId = "1234";
            cm1.FirstName = "Bonnie";
            cm1.LastName = "Parker";
            cm1.ContactInfo = c1;
            



            Console.WriteLine(cm1);

            Customer cm2 = new Customer("444", "Clyde", "Barrow", c2);

            Console.WriteLine(cm2);


            Console.WriteLine("\n\n------Credit Card Account------\n\n");

            CreditCardAccount cc1 = new CreditCardAccount();
            cc1.AccountNumber = 1234;
            cc1.CustomerInfo = cm1;
            cc1.IsPastDue = true;
            cc1.AnnualInterestRate = 3.4m;




            Console.WriteLine(cc1);

            CreditCardAccount cc2 = new CreditCardAccount(666, cm2, true, 2.8m);

            Console.WriteLine(cc2);


            Console.WriteLine("\n\n------Book------\n\n");

            Book bk1 = new Book();
            bk1.Title = "Breaking Dawn";
            bk1.Author = "Stephanie Meyers";
            bk1.NbrOfPages = 300;


            Console.WriteLine(bk1);

            Book bk2 = new Book("Cat in the Hat", "Dr. Suess", 12);

            Console.WriteLine(bk2);


            Console.WriteLine("\n\n------Library------\n\n");

            Library lb1 = new Library();
            List<Book> books = new List<Book>() { bk1, bk2 };
            lb1.LibraryName = "Trails West";
            lb1.StreetAddress = "100 Main";
            lb1.City = "Independence";
            lb1.State = "MO";
            lb1.Zip = "64050";

            Console.WriteLine(lb1);

            //Library lb2 = new Library();
            //lb2


            //Console.WriteLine(bk2);


            Console.WriteLine("\n\n------Song------\n\n");

            Song ss1 = new Song();
            ss1.Artist = "Cher";
            ss1.Title = "Turn Back Time";
            ss1.Genre = "Oldies";

            Console.WriteLine(ss1);

            Song ss2 = new Song("Juice", "Lizzo","Pop");

            Console.WriteLine(ss2);


        }
    }
}
