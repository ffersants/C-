using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_e_Override
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; protected set; }

        BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                this.Balance += amount;
            }
        }
    }
}
