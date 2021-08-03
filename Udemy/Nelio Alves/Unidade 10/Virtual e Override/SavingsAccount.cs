using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_e_Override
{
    class SavingsAccount : Account
    {
        public double interestRate { get; protected set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            this.interestRate = interestRate;
        }

        public void UpdateBalance()
        {
            this.Balance += Balance * this.interestRate;
        }
        //implementada sobrescrita para não descontar 5 reais pelo saque
        public override void withdraw(double amount)
        {
            this.Balance -= amount;
        }
    }
}
