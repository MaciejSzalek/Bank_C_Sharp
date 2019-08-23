using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class Program
    {
        static readonly string name = "Name: Bank C#";
        static readonly string author = "Author: Maciej Szałek";
        static Printer printer = new Printer();

        static void Main(string[] args)
        {
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();

            SavingAccount savingAccount = new SavingAccount("940000000001", 0.0M, "Maciek", "Szalek", "90232093201");
            SavingAccount savingAccount2 = new SavingAccount("940000000002", 0.0M, "John", "Smith", "85022093000");

            BillingAccount billingAccount = new BillingAccount(savingAccount.accountNumber,
                savingAccount.balance,
                savingAccount.firstName,
                savingAccount.lastName,
                savingAccount.pesel);
       
            printer.Print(savingAccount);
            printer.Print(savingAccount2);
            printer.Print(billingAccount);

            Console.ReadKey();
        }
    }
}
