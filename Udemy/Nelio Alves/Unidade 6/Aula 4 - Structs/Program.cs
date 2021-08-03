using System;

namespace Aula_4___Structs
{
    struct Carro
    {
        public string marca, modelo, cor;

        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro p1 = new Carro("Toyota", "Corolla", "Branco");
            Carro p2 = p1;

            Console.WriteLine(p2.marca);
        }
    }
}
