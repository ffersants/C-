using System;

namespace Modificador_de_parametros___out
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Triple(3, out x);
            Console.WriteLine(x);
        }

        static void Triple(int multiplicado, out int result)
        {
            result = multiplicado * 3; 
        }
    }
}
