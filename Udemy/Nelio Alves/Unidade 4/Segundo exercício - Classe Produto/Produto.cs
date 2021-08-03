using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_exercício___Classe_Produto
{
    class Produto
    {
        public string name;
        public double price;
        public int quantity;
        public Produto(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void AdicionarProdutos(int total)
        {
            this.quantity += total;
        }

        public void RemoverProdutos(int total)
        {
            this.quantity -= total;
        }
    }
}
