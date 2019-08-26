using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    abstract class Account
    {
        public ulong Id { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; set; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Pesel { get; }

        public Account(ulong id, string firstName, string lastName, string pesel)
        {
            this.Id = id;
            AccountNumber = GenerateAccountNumber(id);
            Balance = 0.0M;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Pesel = pesel;
        }

        public void ChangeBalance(decimal value)
        {
            Balance += value;
        }

        public abstract string TypeName();

        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public string GetBalance()
        {
            return string.Format("{0} pln", Balance);
        }

        private string GenerateAccountNumber(ulong id)
        {
            string accountNumber = string.Format("94{0:D10}", id);
            return accountNumber;
        }
    }
}
