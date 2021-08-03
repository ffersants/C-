using System;
using System.Collections.Generic;
using System.Linq;

namespace Func___Método_Select__
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();

            produtos.Add(new Product("Televisão", 5000));
            produtos.Add(new Product("Bike", 1200));
            produtos.Add(new Product("Lâmpada", 20.50));
            produtos.Add(new Product("Armário", 800));

            List<double> resultado = produtos.Select(AddDiscount).ToList();

            resultado.ForEach(i => Console.WriteLine(i));
        }

        static double AddDiscount(Product p)
        {
            return p.price - p.price/100 * 5;
        }
    }
}
