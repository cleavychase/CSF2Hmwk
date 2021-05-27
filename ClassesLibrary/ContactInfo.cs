using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        //fields
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _eMail;
    
    public string StreetAddress
    {
        get { return _streetAddress; }
        set { _streetAddress = value; }
    }
    public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }
        //ctors - Make a default ctor and FQCTOR
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string eMail)
        {
            //Prop = param;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            EMail = eMail;

        }//end of Fully Qualified CTOR (FQCTOR) - we used every property in the creation of the object
        public ContactInfo()
        {

        }
        //methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Street Address: {0}\n" +
                "City: {1}\n" +
                "State: {2}\n" +
                "Zip: {3}\n" +
                "Phone: {4}\n" +
                "Email: {5}",
                StreetAddress,
                City,
                State,
                Zip,
                Phone,
                EMail
                );
        }
    }
}
