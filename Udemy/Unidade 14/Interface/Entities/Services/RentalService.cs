using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities.Services
{
    class RentalService
    {
        public double pricePerHour { get; private set; }
        public double pricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay)
        {
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
        }

        private BrazilTaxServices _brazilTaxServices = new BrazilTaxServices();
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan durantion = carRental.finish.Subtract(carRental.start);
            double basicPayment = 0.0;

            if(durantion.TotalHours <= 12.0)
            {
                basicPayment = pricePerHour * Math.Ceiling(durantion.TotalHours);
            } 
            else
            {
                basicPayment = pricePerDay * Math.Ceiling(durantion.TotalDays);
            }

            double tax = _brazilTaxServices.Tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);

        }
    }
}
