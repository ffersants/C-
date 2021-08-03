using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas notas serão lidas:");
            int totalDeNotas = int.Parse(Console.ReadLine());

            double[] notas = new double[totalDeNotas];
            double total = 0;
            for(int i = 0; i < totalDeNotas; i++)
            {
                Console.Write("Digite a nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());

                total += notas[i];
            }
            Console.WriteLine(notas);

            Console.WriteLine("A média de notas é: " + (total / totalDeNotas).ToString("F2"));
        }
    }
}
