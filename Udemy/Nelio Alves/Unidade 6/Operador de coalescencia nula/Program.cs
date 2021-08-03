using System;

namespace Operador_de_coalescencia_nula
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int? y = null;
            int z = y ?? x;
            Console.WriteLine(z);
        }
    }
}
