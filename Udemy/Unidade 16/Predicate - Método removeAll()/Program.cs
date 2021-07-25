using System;
using System.Collections.Generic;

namespace Predicate___Método_removeAll__
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

            produtos.RemoveAll((produto) => produto.price > 1000);

            produtos.ForEach(product => Console.WriteLine(product.ToString()));
        }
    }
}
