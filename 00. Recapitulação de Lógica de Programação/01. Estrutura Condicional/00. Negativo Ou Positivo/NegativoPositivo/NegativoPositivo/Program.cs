using System;

namespace NegativoPositivo {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            Double number = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (number < 0) {
                Console.WriteLine("NEGATIVO");
            } else {
                Console.WriteLine("POSITIVO");
            }
        }
    }
}
