using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class SmallPrinter : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Account  number: {0}", account.AccountNumber);
            Console.WriteLine("Account owner: {0}", account.GetFullName());
        }
    }
}
