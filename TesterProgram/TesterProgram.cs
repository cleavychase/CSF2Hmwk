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
        }
    }
}
