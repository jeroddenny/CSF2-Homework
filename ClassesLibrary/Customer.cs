using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields
        private string _customerID;
        private string _firstName;
        private string _lastName;
        private ContactInfo _customerInfo;



        //props
        public string CustomerID  { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public ContactInfo CustomerInfo  { get; set; }
        //ctor
        public Customer() { }

        public Customer(string customerID, string firstName, string lastName, ContactInfo customerInfo)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            CustomerInfo = customerInfo;
        }





        //methods

        public override string ToString()
        {
            return string.Format($"\nCutsomer ID: {CustomerID}\nFirst Name: {FirstName}\nLast Name: {LastName}\n{CustomerInfo}");
        }
    }
}
