using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_e_Override
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //método a ser sobrescrito em subclasses
        public virtual void withdraw(double amount)
        {
            this.Balance -= amount + 5.0;
        }

        public void deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
