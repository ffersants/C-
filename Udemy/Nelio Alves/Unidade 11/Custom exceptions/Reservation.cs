using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_exceptions
{
    class Reservation
    {
        private int roomNumber { get; set; }
        private DateTime checkin { get; set; }
        private DateTime checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            this.roomNumber = roomNumber;
            this.checkin = checkin;
            this.checkout = checkout;
        }

        public void updateDates(DateTime checkin, DateTime checkout)
        {
            this.checkin = checkin;
            this.checkout = checkout;
        }

        public override string ToString()
        {
            return $"Room number -> {this.roomNumber} \nCheck In -> {this.checkin} \nCheck Out -> {this.checkout}";
        }
    }
}
