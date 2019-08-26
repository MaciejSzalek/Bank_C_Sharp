using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class SavingsAccount : Account
    {
        public SavingsAccount(ulong id, string firstName, string lastName, string pesel)
            : base(id, firstName, lastName, pesel)
        {
        }

        public void AddInterest(decimal interest)
        {
            Balance += Balance * interest;
        }

        public override string TypeName()
        {
            return "SAVINGS ACCOUNT";
        }
    }
}
