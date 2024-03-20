using System;

namespace TestesDeMatematica {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            int entrada = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= entrada; i++) {

                int quadrado = i * i;
                int cubo = quadrado * i;

                Console.WriteLine("{0} {1} {2}", i, quadrado, cubo);

            }
        }
    }
}