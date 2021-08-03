using System;

namespace Primeiros_exercícios___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1;

            Console.WriteLine("Digite o nome da pessoa:");
            string pessoa1Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa:");
            int pessoa1Idade = int.Parse(Console.ReadLine());

            pessoa1 = new Pessoa(pessoa1Nome, pessoa1Idade);

            Console.WriteLine("Digite o nome da pessoa:");
            string pessoa2Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa:");
            int pessoa2Idade = int.Parse(Console.ReadLine());

            Pessoa pessoa2 = new Pessoa(pessoa2Nome, pessoa2Idade);

            if(pessoa1.age > pessoa2.age)
            {
                Console.WriteLine($"{pessoa1.name} é {pessoa1.age - pessoa2.age} anos mais velho(a) que {pessoa2.name}!");
            } else
            {
                Console.WriteLine($"{pessoa2.name} é {pessoa2.age - pessoa1.age} anos mais velho(a) que {pessoa1.name}!");
            }
        }
    }
}
