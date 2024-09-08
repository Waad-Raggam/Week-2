using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo9
{
    public class SavingAccount : BankAccount
    {
        public int interestRate;
        public int GetInterestRate()
        {
            return interestRate;
        }

        // protected field => can can access
        public void GetAccountInformation()
        {
            Console.WriteLine($"Account information: {_accountNumber}");

        }

        // private field => child cant access
        // public void GetAccountName()
        // {
        //     Console.WriteLine($"Account information: {_accountName}");

        // }
    }
}