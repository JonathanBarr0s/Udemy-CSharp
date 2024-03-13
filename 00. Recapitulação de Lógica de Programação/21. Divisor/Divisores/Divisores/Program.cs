using System;

namespace Divisores {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            int entrada = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= entrada; i++) {

                if (entrada % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}