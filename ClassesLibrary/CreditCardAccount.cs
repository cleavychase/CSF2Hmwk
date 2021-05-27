using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields
        private int _accountNumber;
        private Customer _customerInfo;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        //properties
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public Customer CustomerInfo
        {
            get { return _customerInfo; }
            set { _customerInfo = value; }
        }
        public bool IsPastDue
        {
            get { return _isPastDue; }
            set { _isPastDue = value; }
        }
        public decimal AnnualInterestRate
        {
            get { return _annualInterestRate; }
            set { _annualInterestRate = value; }
        }
        //ctors - Make a default ctor and FQCTOR
        public CreditCardAccount(int accountNumber, Customer customerInfo, bool isPastDue, decimal annualInterestRate)
        {
            //Prop = param;
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;


        }
        public CreditCardAccount()
        {

        }
        public override string ToString()
        {
            return string.Format("Account Number: {0} \n" + "Customer Info: {1}\n" +
                "Past due: {2}\n" +
                "Interest Rate: {3}", AccountNumber, CustomerInfo, IsPastDue, AnnualInterestRate);

        }
    }
}
