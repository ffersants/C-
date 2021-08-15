using Factory_Method_in_abstract_class.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_in_abstract_class.Factory
{
    abstract class FactoryMethod
    {
        abstract public IVehicle FMethod(string color, string vehicleType);

    }
}
