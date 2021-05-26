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
        }
    }
}
