using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Loggin
    {
        //fields
        private string _userName;
        private string _passWord;
        

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
        

            //ctors - Make a default ctor and FQCTOR
        public Loggin(string userName, string passWord)
        {
            //Prop = param;
            UserName = userName;
            PassWord = passWord;
            
        }//end of Fully Qualified CTOR (FQCTOR) - we used every property in the creation of the object
        public Loggin()
        {

        }
        //methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Username: {0}\n" +
                "Password: {1}\n",
                UserName,
                PassWord
                );
        }
    }
}
