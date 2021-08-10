using Factory_Method_in_abstract_class.Classes;
using Factory_Method_in_abstract_class.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_in_abstract_class.Factory.Base
{
    class FactoryBike : FactoryMethod
    {
        public override IVehicle FMethod(string color, string vehicleType)
        {
            IVehicle bike = new Bike();
            bike.color = color;
            bike.vehicleType = vehicleType;
            return bike;
        }
    }
}
