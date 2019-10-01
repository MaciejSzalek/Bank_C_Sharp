using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class BankManager
    {
        private AccountsManager _accountsManager;
        private IPrinter _printer;

        public BankManager()
        {
            _accountsManager = new AccountsManager();
            _printer = new Printer();
        }

        public void Run()
        {
            int action;
            do
            {
                MainMenuPrinter.Print();
                action = SelectedAction();

                switch(action)
                {
                    case 1:
                        CustomerAccountsList();
                        break;
                    case 2:
                        AddBillingAccount();
                        break;
                    case 3:
                        AddSevingsAccount();
                        break;
                    case 4:
                        AddMoney();
                        break;
                    case 5:
                        TakeMoney();
                        break;
                    case 6:
                        GetCustomersList();
                        break;
                    case 7:
                        GetAccountsList();
                        break;
                    case 8:
                        CloseMonth();
                        break;
                    default:                    
                        Console.WriteLine("unknown command");                 
                        break;

                }
            }
            while (action != 0);
        }

        private int SelectedAction() {
            Console.Write("Action: ");
            string action = Console.ReadLine();
            if(string.IsNullOrEmpty(action))
            {
                return -1;
            }
            return int.Parse(action);
        }

        private void CustomerAccountsList()
        {
            Console.Clear();
            CustomerData data = CustomerData.ReadCustomerData();
            Console.WriteLine();
            Console.WriteLine("Customer accounts {0} {1} {2}", data.FirstName, data.LastName, data.Pesel);

            foreach (Account account in _accountsManager.GetAllAccountsFor(data.FirstName, data.LastName, data.Pesel))
            {
                _printer.Print(account);
            }
            Console.ReadKey();
        }

        private void AddBillingAccount()
        {
            Console.Clear();
            CustomerData data = CustomerData.ReadCustomerData();
            Account billingAccount = _accountsManager.CreateBillingAccount(data.FirstName, data.LastName, data.Pesel);

            Console.WriteLine("New billing account created: ");
            _printer.Print(billingAccount);
            Console.ReadKey();
        }

        private void AddSevingsAccount()
        {
            Console.Clear();
            CustomerData data = CustomerData.ReadCustomerData();
            Account savingsAccount = _accountsManager.CreateSavingsAccount(data.FirstName, data.LastName, data.Pesel);

            Console.WriteLine("New savings account created: ");
            _printer.Print(savingsAccount);
            Console.ReadKey();
        }

        private void AddMoney()
        {
            string accountNo;
            decimal value;

            Console.WriteLine("Add money");
            Console.Write("Enter accoun number: ");
            accountNo = Console.ReadLine();
            Console.Write("Enter value");
            value = decimal.Parse(Console.ReadLine());
            _accountsManager.AddMoney(accountNo, value);

            Account account = _accountsManager.GetAccount(accountNo);
            _printer.Print(account);
            Console.ReadKey();
        }

        private void TakeMoney()
        {
            string accountNo;
            decimal value;

            Console.WriteLine("Take money");
            Console.Write("Enter account number");
            accountNo = Console.ReadLine();
            Console.Write("Enter value: ");
            value = decimal.Parse(Console.ReadLine());
            _accountsManager.TakeMoney(accountNo, value);

            Account account = _accountsManager.GetAccount(accountNo);
            _printer.Print(account);
            Console.ReadKey();
        }

        private void GetCustomersList()
        {
            Console.Clear();
            Console.WriteLine("Customers list: ");
            foreach(string customer in _accountsManager.ListOfCustomers())
            {
                Console.WriteLine(customer);
            }
            Console.ReadKey();
        }

        private void GetAccountsList()
        {
            Console.Clear();
            Console.WriteLine("Accounts list: ");
            foreach(Account account in _accountsManager.GetAllAccounts())
            {
                _printer.Print(account);
            }
            Console.ReadKey();
        }

        private void CloseMonth()
        {
            Console.Clear();
            _accountsManager.CloseMonth();
            Console.WriteLine("Moth close");
            Console.ReadKey();
        }
    }
}
