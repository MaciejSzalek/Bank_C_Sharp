using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class SavingAccount
    {
        public string accountNumber;
        public decimal balance;
        public string firstName;
        public string lastName;
        public string pesel;

        public SavingAccount(string accountNumber, decimal balance, string firstName, string lastName, string pesel)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.firstName = firstName;
            this.lastName = lastName;
            this.pesel = pesel;
        }

        public string GetFullName()
        {
            return string.Format("{0} {1}", firstName, lastName);
        }

        public string GetBalance()
        {
            return balance.ToString() + " pln";
        }
    }
}
