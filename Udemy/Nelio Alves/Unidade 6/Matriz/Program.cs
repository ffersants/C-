using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nomes = new string[3,2];

            //retorna o número de linhas
            Console.WriteLine(nomes.Rank);

            Console.WriteLine(nomes.GetLength(0));
        }
    }
}
