using System;
using System.Collections.Generic;

namespace Lista_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Employe > employees = new List<Employe>();
            Console.Write("How many employees will be registrered? ");
            int[] totalEmployes = new int[int.Parse(Console.ReadLine())];

            for(int i = 0; i < totalEmployes.Length; i++)
            {
                Console.WriteLine("Eployee #" + (i + 1));
                
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employe(id, name, salary));
                
            }

            Console.Write("Enter the employee id that will have salary increased: ");
            int employeeID = int.Parse(Console.ReadLine());

            while(!employees.Exists(x => x.id == employeeID))
            {
                Console.WriteLine("\nUser not found!\n");

                Console.Write("Please, Enter the employee id that will have salary increased: ");
                employeeID = int.Parse(Console.ReadLine());
            }

            int employeeIndex = employees.FindIndex(x => x.id == employeeID);

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());

            employees[employeeIndex].increaseSalary(percentage); 

            Console.WriteLine("Updated list of employes:");

            foreach(Employe i in employees)
            {
                Console.WriteLine($"{i.id}, {i.name}, {i.salaray}");
            }


        }
    }
}
