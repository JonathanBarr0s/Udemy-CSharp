using System;

namespace ImpostoDeRenda {
    internal class Program {
        static void Main(string[] args) {

            double salario = 0;
            double impostoAPagar = 0;

            Console.Write("Digite seu salário: R$ ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (salario <= 2000) {
                Console.WriteLine("Isento");
            } else if (salario >= 2000 && salario <= 3000) {
                impostoAPagar = (salario - 2000) * 0.08;
                Console.WriteLine("R$ " + impostoAPagar);
            } else if (salario >= 3000 && salario <= 4500) {
                impostoAPagar = (1000 * 0.08) + ((salario - 3000) * 0.18);
                Console.WriteLine("R$ " + impostoAPagar);
            } else if (salario >= 4500) {
                impostoAPagar = (1000 * 0.08) + (1500 * 0.18) + ((salario - 4500) * 0.28);
                Console.WriteLine("R$ " + impostoAPagar);
            }

        }
    }
}

