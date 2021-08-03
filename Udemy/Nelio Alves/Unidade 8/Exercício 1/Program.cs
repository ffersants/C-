using Exercício_1.Classes;
using Exercício_1.Enums;
using System;
using System.Globalization;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();

            Console.WriteLine("Enter worker data");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many contracts to this worker? ");
            int totalContracts = int.Parse(Console.ReadLine());

            Worker Fernando = new Worker(name, WorkerLevel.Senior, salary);

            for(int i = 0; i < totalContracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int totalHours = int.Parse(Console.ReadLine());
                Fernando.addContract(date, valuePerHour, totalHours);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            DateTime doIncomeStartingIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(doIncomeStartingIn);
            decimal bonus = Fernando.income(doIncomeStartingIn);
            decimal total = ((decimal)Fernando.BaseSalary + bonus);
            Console.WriteLine(total.ToString("F2"));
        }
    }
}
