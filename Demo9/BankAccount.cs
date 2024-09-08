using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo9
{
    public class BankAccount
    {
        protected string _accountNumber;
        private string _accountName;
        private decimal _balance;

        // getter and setter

        // method
        public string GetAccountNumber()
        {
            return _accountNumber;
        }
    }
}