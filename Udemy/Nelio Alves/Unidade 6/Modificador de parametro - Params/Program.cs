using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Soma(5, 3, 8));
        }

        static int Soma(params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            return total;
        }
    }

   
 
}
