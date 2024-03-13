using System;

namespace NumerosImpares {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < (numeroDigitado + 1); i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}