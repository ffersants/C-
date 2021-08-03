using System;

namespace RefactoringGuru_example
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteBuilder builder = new ConcreteBuilder();
            Director director = new Director();
            director.Biulder = builder;

            director.BuildFullFeaturedProduct();

            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}
