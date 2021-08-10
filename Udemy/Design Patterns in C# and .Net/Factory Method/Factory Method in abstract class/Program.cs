using Factory_Method_in_abstract_class.Classes.Base;
using Factory_Method_in_abstract_class.Factory.Base;
using System;

namespace Factory_Method_in_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeFactory = new FactoryBike();
            IVehicle bike = bikeFactory.FMethod("Azul", "Bicicleta");
        }
    }
}
