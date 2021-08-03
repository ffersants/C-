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
        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
            this._taxService = taxService;
        }

        
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

            double tax = _taxService.Tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);

        }
    }
}
