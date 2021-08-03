using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_personalizadas
{
    class Reservation
    {
        public int roomNumber { get; private set; }
        public DateTime checkin { get; private set; }

        public DateTime checkout { get; private set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new Exception("A data de saída deve ser após a data de entrada.");
            }
            this.roomNumber = roomNumber;
            this.checkin = checkin;
            this.checkout = checkout;

        }

        public override string ToString()
        {
            return $"Room number -> {roomNumber} \nCheck in -> {checkin} \nCheck out -> {checkout}";
        }

        public int totalDays()
        {
            TimeSpan time = this.checkout.Subtract(this.checkin);
            return (int) time.Days;
        }
    }
}
