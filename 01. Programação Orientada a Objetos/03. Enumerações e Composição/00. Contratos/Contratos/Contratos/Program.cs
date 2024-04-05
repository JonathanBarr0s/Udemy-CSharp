using System;
using Contratos.Entities;
using Contratos.Entities.Enums;

namespace Contratos {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Department dept = new Department(department);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int contractCount = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= contractCount; i++) {
                Console.WriteLine("Enter #{0} contract data: ", i);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
                Console.WriteLine();
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string period = Console.ReadLine();
            int month = int.Parse(period.Substring(0, 2));
            int year = int.Parse(period.Substring(3));

            Console.WriteLine();

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for {0}: {1}", period, worker.Income(year, month).ToString("F2"));
        }
    }
}