using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Sort_com_método_delegado
{
    class Produto
    {
        public string name;
        public double price;
        public bool availble;

        public Produto(string name, double price, bool availble)
        {
            this.name = name;
            this.price = price;
            this.availble = availble;
        }

        public override string ToString()
        {
            return $"\nProduto: {name} \nPreco: {price} \nDisponivel: {availble}\n\n";
        }
    }
}
