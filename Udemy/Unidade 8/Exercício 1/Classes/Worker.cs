using Exercício_1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1.Classes
{
    class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalary { get; private set; }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        List<HourContract> allContracts = new List<HourContract>();

        public void addContract(DateTime date, double valuePerHour, int hours)
        {
            allContracts.Add(new HourContract(date, valuePerHour, hours));
        }

        public void removeContract()
        {

        }

        public decimal income(DateTime period)
        {
            Console.WriteLine();

            List<HourContract> contractsFiltered = allContracts.FindAll(x => x.Datee.Month == period.Month && x.Datee.Year == period.Year);
            decimal montante = 0;
            foreach (HourContract i in contractsFiltered)
            {
                Console.WriteLine(i.totalValue());
                montante += i.totalValue();
            }
            
            return montante;
        }
    }
}
