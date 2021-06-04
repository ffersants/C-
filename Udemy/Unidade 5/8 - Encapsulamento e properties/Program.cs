using System;

namespace _8___Encapsulamento_e_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            produto1.Nome = "Mesa";
            Console.WriteLine(produto1.Nome);

           /* 
            USO DE MÉTODOS GETTERS E SETTERS
            
            produto1.SetNome("Mesa");
            Console.WriteLine(produto1.GetNome());
           
           */
        }
    }
}
