using System;
using System.Globalization;

namespace Custom_exceptions
{
    class  Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número do quarto: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Digite a data de entrada (DD/MM/AAAA): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

            Console.Write("Digite a data de saída (DD/MM/AAAA): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

            Reservation reserva1 = new Reservation(roomNumber, checkin, checkout);
            
            TimeSpan duration = checkout.Subtract(checkin);
            Console.WriteLine("Reserva de: " + (int) duration.TotalDays);
        }
    }
}
