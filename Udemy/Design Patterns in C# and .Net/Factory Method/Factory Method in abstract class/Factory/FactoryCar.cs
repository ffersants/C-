using Factory_Method_in_abstract_class.Classes;
using Factory_Method_in_abstract_class.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_in_abstract_class.Factory
{
    class FactoryCar : FactoryMethod
    {
        public override IVehicle FMethod(string color, string vehicleType)
        {
            IVehicle car = new Car();
            car.color = color;
            car.vehicleType = vehicleType;
            return car;
        }
    }
}
