using Pagamentos.Entities;
using System.Collections.Generic;
using System;

namespace Pagamentos {
    internal class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numberOfEmployees; i++) {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced == 'y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    OutSourcedEmployee outSourcedEmployee = new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(outSourcedEmployee);
                } else {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }

                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees) {
                Console.WriteLine($"{employee.Name} - R$ {employee.Payment().ToString("F2")}");
            }
        }
    }
}