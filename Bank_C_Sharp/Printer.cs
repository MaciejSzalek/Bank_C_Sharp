using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class Printer : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Account  number: {0}", account.AccountNumber);
            Console.WriteLine("Type: {0}", account.TypeName());
            Console.WriteLine("Balance: {0}", account.GetBalance());
            Console.WriteLine("Account owner: {0}", account.GetFullName());
            Console.WriteLine("PESEL: {0}", account.Pesel);
            Console.WriteLine();
        }
    }
}
