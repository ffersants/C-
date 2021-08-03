using System;

namespace Condicional__functions__logical_operators_e_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHour = DateTime.Now.Hour;
            string greeting = decidesGreeting(currentHour);
            Console.WriteLine(greeting);
        }

        static string decidesGreeting(int currentHour)
        {
            string greeting;

            if(currentHour >= 5 && currentHour <= 11)
            {
                greeting = "Bom dia!";
            } else if(currentHour >= 12 && currentHour <= 18)
            {
                greeting = "Boa tarde!";
            } else
            {
                greeting = "Boa noite!";
            }

            return greeting;
        }
    }
}
