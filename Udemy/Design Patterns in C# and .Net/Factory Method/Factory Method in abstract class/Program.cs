using Factory_Method_in_abstract_class.Classes.Base;
using Factory_Method_in_abstract_class.Classes;
using System;

namespace Factory_Method_in_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeFactory = new Bike.Factory();
            var bike = bikeFactory.FMethod("Azul", "Bicicleta");
            Console.WriteLine(bike.color);

        }
    }
}
