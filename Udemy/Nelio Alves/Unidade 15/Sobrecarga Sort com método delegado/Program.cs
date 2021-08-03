using System;
using System.Collections.Generic;

namespace Sobrecarga_Sort_com_método_delegado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> Produtos = new List<Produto>();
            
            Produto televisao = new Produto("Televisao 4K", 4000, true);
            Produto bicicleta = new Produto("Bike aro 29", 1500.50, true);
            Produto armario = new Produto("Armário 3 portas", 1700, false);
            
            Produtos.Add(televisao);
            Produtos.Add(bicicleta);
            Produtos.Add(armario);
            //método 1
            /*
            Comparison<Produto> filter = filterLogic;
         
            static int filterLogic(Produto p1, Produto p2)
                {
                    return p1.price.CompareTo(p2.price);
                }
            */

            //método 2 - expressão lambda
            //tipo de dado inferido pelo C#, retorno implícito
            Comparison<Produto> filter = (p1, p2) => p1.price.CompareTo(p2.price);

            Produtos.Sort(filter);
           
        }
    }
}
