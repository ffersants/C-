using System;

namespace Modificado_de_parametro___Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int toBeTripled = 50;
            Calculadora.Triple(ref toBeTripled);
            Console.WriteLine(toBeTripled);
        }
    }
}
