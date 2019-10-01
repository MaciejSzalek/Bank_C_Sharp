using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class MainMenuPrinter
    {
        public static void Print()
        {
            Console.Clear();
            Console.WriteLine("Select action:");
            Console.WriteLine("1 - Customer accounts list");
            Console.WriteLine("2 - Add billing account");
            Console.WriteLine("3 - Add sevings account");
            Console.WriteLine("4 - Add money");
            Console.WriteLine("5 - Take money");
            Console.WriteLine("6 - Customers list");
            Console.WriteLine("7 - Accounts list");
            Console.WriteLine("8 - Close month");
            Console.WriteLine("0 - Finish");
        }
    }
}
