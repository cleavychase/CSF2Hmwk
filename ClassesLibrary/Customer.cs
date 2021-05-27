using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesLibrary
{
    public class Customer
    {//fields
        private string _customerId;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInfo;

        //properties
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
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
        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set { _contactInfo = value; }
        }
        //ctors - Make a default ctor and FQCTOR
        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInfo)
        {
            //Prop = param;
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;


        }
        public Customer()
        {

        }
        //end of Fully Qualified CTOR (FQCTOR) - we used every property in the creation of the object
        public override string ToString()
        {
            return string.Format("Customer ID: {0} \n" + "First Name: {1}\n" +
                "Last Name: {2}\n" +
                "Contact Info: {3}", CustomerId, FirstName, LastName, ContactInfo);

        }
    }
}
