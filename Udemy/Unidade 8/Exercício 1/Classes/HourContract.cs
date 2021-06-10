using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1.Classes
{
    class HourContract
    {
        public DateTime Datee { get; private set; }
        private double valuePerHour { get; set; }
        private int hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.Datee = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public decimal totalValue()
        {
            return (decimal)valuePerHour * hours;
        }
    }
}
