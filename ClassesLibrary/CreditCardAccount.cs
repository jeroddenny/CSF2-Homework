using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields
        private int _accountNumber;
        private Customer _customerInfo;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        //props
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }



        //ctor
        public CreditCardAccount() { }

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = false;
            AnnualInterestRate = annualInterestRate;
        }


        //methods
        public override string ToString()
        {
            return string.Format($"Account Number: {AccountNumber}\n{CustomerInfo}\nBalance: {Balance:c} \nPast Due? {(IsPastDue ? "Yes" : "No")}\nAnnual Interest Rate: {AnnualInterestRate:p}");
        }

    }
}
