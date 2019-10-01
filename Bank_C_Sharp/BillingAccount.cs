using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C_Sharp
{
    class BillingAccount : Account
    {
        public BillingAccount(ulong id, string firstName, string lastName, string pesel)
            : base(id, firstName, lastName, pesel)
        {
        }

        public void TakeCharge(decimal value)
        {
            Balance -= value;
        }

        public override string TypeName()
        {
            return "BILLING ACCOUNT";
        }
    }
}
