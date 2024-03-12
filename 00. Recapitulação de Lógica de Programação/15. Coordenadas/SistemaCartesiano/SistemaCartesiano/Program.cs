using System;

namespace SistemaCartesiano {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o valor de X e depois o de Y:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0) {
                    Console.WriteLine();
                    Console.WriteLine("primeiro");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine();
                    Console.WriteLine("segundo");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine();
                    Console.WriteLine("terceiro");
                } else if (x > 0 && y < 0) {
                    Console.WriteLine();
                    Console.WriteLine("quarto");
                }

                Console.WriteLine();
                Console.WriteLine("Digite o valor de X e depois o de Y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}