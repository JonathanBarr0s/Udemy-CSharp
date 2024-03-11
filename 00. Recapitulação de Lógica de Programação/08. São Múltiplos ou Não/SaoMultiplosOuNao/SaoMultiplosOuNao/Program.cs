using System;

namespace SaoMultiplosOuNao {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double segundoNumero = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (primeiroNumero % segundoNumero == 0 || segundoNumero % primeiroNumero == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}