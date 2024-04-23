using Impostometro.Entities;

namespace Impostometro {
    internal class Program {
        static void Main(string[] args) {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayer = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numberOfTaxPayer; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char individualOrCompany = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (individualOrCompany == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                } else {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");

            double sum = 0;
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name}: R$ {item.Tax().ToString("F2")}");
                sum += item.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: R$ {sum.ToString("F2")}");
        }
    }
}