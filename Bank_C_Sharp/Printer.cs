using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class Printer
    {
        public void Print(SavingAccount account)
        {
            Console.WriteLine("Account owner: {0}", account.GetFullName());
            Console.WriteLine("Account number: {0}", account.accountNumber);
            Console.WriteLine("Balance: {0}", account.GetBalance());
            Console.WriteLine("First name: {0}", account.firstName);
            Console.WriteLine("Last name: {0}", account.lastName);
            Console.WriteLine("PESEL: {0}", account.pesel);
            Console.WriteLine();           
        }

        public void Print(BillingAccount account)
        {
            Console.WriteLine("Account owner: {0}", account.GetFullName());
            Console.WriteLine("Account number: {0}", account.accountNumber);
            Console.WriteLine("Balance: {0}", account.GetBalance());
            Console.WriteLine("First name: {0}", account.firstName);
            Console.WriteLine("Last name: {0}", account.lastName);
            Console.WriteLine("PESEL: {0}", account.pesel);
            Console.WriteLine();
        }
    }
}
