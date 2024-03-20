using System;

namespace ParOuImpar {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (numero % 2  == 0 ) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }


        }
    }
}