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
        static readonly string author = "Author: Maciej Szalek";

        static void Main(string[] args)
        {
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();

            BankManager bankManager = new BankManager();
            bankManager.Run();

        }
    }
}
