using System;

namespace Sobrescrever_um_método_herdado_de_superclasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 classeFilha = new Class2("Classe filha nome");
            Class1 classePai = new Class1("Essa é a classe pai", true);
            Console.WriteLine(classeFilha.toBeOverwritten());
            Console.WriteLine(classePai.toBeOverwritten());
        }
    }
}
