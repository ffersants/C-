using System;
using System.Collections.Generic;

namespace Melhor_override_de_ToString_para_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Products produtosInPharmacy = new Products();

            produtosInPharmacy.addProducts("Dipirona");
            produtosInPharmacy.addProducts("Dorfflex");
            produtosInPharmacy.addProducts("Bepantol");
            produtosInPharmacy.addProducts("Jontex");
            produtosInPharmacy.addProducts("Neovlar");
            produtosInPharmacy.addProducts("Biotônico");
            
            //jeito ruim
            //foreach (string produto in produtosInPharmacy.allProducts) Console.WriteLine(produto);
            
            //jeito bom
            Console.WriteLine(produtosInPharmacy.ToString());
        }

        public class Products
        {
            public List<string> allProducts = new List<string>();
            public void addProducts(string product)
            {
                this.allProducts.Add(product);
            }
            //jeito bom
            public override string ToString()
            {
                return string.Join(Environment.NewLine, allProducts);
            }
        }
    }
}
