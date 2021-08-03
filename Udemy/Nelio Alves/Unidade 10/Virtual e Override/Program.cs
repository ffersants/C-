using System;

namespace Virtual_e_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1, "Fernando", 100);
            Account acc2 = new SavingsAccount(2, "Jaqueline", 500, 0.01);

            acc1.withdraw(50);
            acc2.withdraw(50);

            Console.WriteLine(acc1.Balance);
            //não recebe taxa de 5 reais por saque, em razão de ser SavingsAccount que sobrescreveu
            //o método da classe pai Account, removendo a taxa cobrada
            Console.WriteLine(acc2.Balance);
        }
    }
}
