using System;
using Interface_and_abstract_class.Entities;
namespace Interface_and_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle retangulo = new Rectangle() { width = 7.0, height = 3.0, cor = Enums.Cor.Branco };
            Console.WriteLine(retangulo.Area());
        }
    }
}
