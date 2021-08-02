using System;

namespace Builder___Agora_vai
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();

            Director service = new Director(builder);
            service.make();

            Artigo e = builder.pegarResultado();
            Console.WriteLine(e.titulo);
        }
    }
}
