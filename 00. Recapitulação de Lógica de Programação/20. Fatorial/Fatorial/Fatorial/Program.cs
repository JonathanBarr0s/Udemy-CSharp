using System;

namespace Fatorial {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            int entrada = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= entrada; i++) {
                fatorial *= i;
            }

            Console.WriteLine();

            Console.WriteLine(fatorial);

        }
    }
}