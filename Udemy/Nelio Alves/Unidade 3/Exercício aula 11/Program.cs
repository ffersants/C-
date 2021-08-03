using System;
using System.Globalization;

namespace Exercício_aula_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int totalRooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (tudo na mesma linha):");
            string[] allData = Console.ReadLine().Split(' ');

            string lastName = allData[0];
            int age = int.Parse(allData[1]);
            double altura = double.Parse(allData[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu último nome é {lastName}, você tem {age} anos e {altura} de altura!");

            Console.WriteLine(fullName);
            Console.WriteLine(totalRooms);
            Console.WriteLine(productPrice);
        }
    }
}
