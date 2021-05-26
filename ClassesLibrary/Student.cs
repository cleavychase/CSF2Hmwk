using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _iD;
        private float _gPA;
        

       
        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        public float GPA
        {
            get { return _gPA; }
            set { _gPA = value; }
        }
        //ctors - Make a default ctor and FQCTOR
        public Student(string firstName, string lastName, string iD, float gPA)
        {
            //Prop = param;
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            GPA = gPA;
        }//end of Fully Qualified CTOR (FQCTOR) - we used every property in the creation of the object
        public Student()
        {

        }
        //methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("First Name: {0}\n" +
                "Last Name: {1}\n" +
                "Student ID: {2}\n" +
                "GPA {3}\n",
                FirstName,
                LastName,
                ID,
                GPA);
        }
        }
}
