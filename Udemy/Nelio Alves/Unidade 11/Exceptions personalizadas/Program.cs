using System;

namespace Exceptions_personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool someErroOccurred = false;
            try
            {
                Console.Write("Número do quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Data de entrada: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de saída: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reserva1 = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine($"Reserva realizada para um total de {reserva1.totalDays()} dias!");
            } 
            //trata a execeção lançada da classe para datas inválidas
            catch(Exception e)
            {
                Console.WriteLine("Falha ao instanciar classe Reservation -> " + e.Message);
                someErroOccurred = true;
            }
            //trata a tentativa de formatação de inputs inválidos
            catch(FormatException e)
            {
                Console.WriteLine("O input fornecito é inválido -> " + e.Message);
                someErroOccurred = true;
            }
        }
    }
}
