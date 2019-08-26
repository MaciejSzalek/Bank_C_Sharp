using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class AccountsManager
    {
        private IList<Account> _accounts;

        public AccountsManager()
        {
            _accounts = new List<Account>();
        }

        public void AddMoney(string accountNum, decimal value)
        {
            Account account = GetAccount(accountNum);
            account.ChangeBalance(value);
        }

        public void TakeMoney(string accountNum, decimal value)
        {
            Account account = GetAccount(accountNum);
            account.ChangeBalance(-value);
        }

        public void CloseMonth()
        {
            foreach (SavingsAccount account in _accounts.Where(a => a is SavingsAccount))
            {
                account.AddInterest(0.04M);
            }

            foreach(BillingAccount account in _accounts.Where(x => x is BillingAccount))
            {
                account.TakeCharge(5.0M);
            }
        }

        public IEnumerable<string> ListOfCustomers()
        {
            return _accounts.Select(a => string.Format("First Name: {0} | Last Name: {1} | PESEL: {2}", a.FirstName, a.LastName, a.Pesel)).Distinct();
        }

        public Account GetAccount(string accountNum)
        {
            return _accounts.Single(a => a.AccountNumber.Equals(accountNum));
        }

        public IEnumerable<Account> GetAllAccountsFor(string firstName, string lastName, string pesel)
        {
            return _accounts.Where(a => a.FirstName.Equals(firstName) && a.LastName.Equals(lastName) && a.Pesel.Equals(pesel));
        }

        public SavingsAccount CreateSavingsAccount(string firstName, string lastName, string pesel)
        {
            ulong id = GenerateId();
            SavingsAccount account = new SavingsAccount(id, firstName, lastName, pesel);
            _accounts.Add(account);

            return account;
        }

        public BillingAccount CreateBillingAccount(string firstName, string lastName, string pesel)
        {
            ulong id = GenerateId();
            BillingAccount account = new BillingAccount(id, firstName, lastName, pesel);
            _accounts.Add(account);

            return account;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _accounts;
        }

        private ulong GenerateId()
        {
            ulong id = 1;
            if(_accounts.Any())
            {
                id = _accounts.Max(a => a.Id) + 1;
            }
            return id;
        }
    }
}
