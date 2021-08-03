using System;

namespace Exercício_2___Aula_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            
            Console.Write("Salário bruto: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            double taxes = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {name}, R$ {salary}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double toIncrease = double.Parse(Console.ReadLine());

            salary = toIncrease / 100 * salary;

            Console.WriteLine($"Dados atualizados: {name}, $ {salary}");
        }
    }
}
