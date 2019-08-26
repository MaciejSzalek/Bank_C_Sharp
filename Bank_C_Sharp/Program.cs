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

        static void Main(string[] args)
        {
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();

            AccountsManager manager = new AccountsManager();

            manager.CreateBillingAccount("John", "Smith", "1234567890");
            manager.CreateSavingsAccount("John", "Smith", "1234567890");
            manager.CreateSavingsAccount("Mark", "Smith", "1234567890");
            manager.CreateSavingsAccount("Aaaaa", "Bbbbb", "0987654321");

            IList<Account> accounts = (IList<Account>)manager.GetAllAccounts();

            Printer printer = new Printer();
        
            foreach(Account account in accounts)
            {
                printer.Print(account);
            }

            IEnumerable<string> users = manager.ListOfCustomers();

            foreach(string user in users)
            {
                Console.WriteLine(user);
            }
   
            Console.ReadKey();
        }
    }
}
