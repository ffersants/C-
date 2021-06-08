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

            employees.Find(x => x.id == employeeID);
        }
    }
}
