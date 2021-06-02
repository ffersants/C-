using System;

namespace Segundo_exercício___Classe_Produto
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto");
            
            Console.Write("Nome:");
            string productName = Console.ReadLine();

            Console.Write("Preço:");
            double productPrice = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque:");
            int productQuantity = int.Parse(Console.ReadLine());
            
            Produto produto1 = new Produto(productName, productPrice, productQuantity);

            Console.WriteLine($"Dados do produto: {produto1.name}, ${produto1.price}, {produto1.quantity} unidade(s), Total: ${produto1.price * produto1.quantity}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int toAdd = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(toAdd);

            Console.WriteLine($"Dados atualizados: {produto1.name}, ${produto1.price}, {produto1.quantity} unidade(s), Total: ${produto1.price * produto1.quantity}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int toRemove = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(toRemove);

            Console.WriteLine($"Dados atualizados: {produto1.name}, ${produto1.price}, {produto1.quantity} unidade(s), Total: ${produto1.price * produto1.quantity}");

        }
    }
}
