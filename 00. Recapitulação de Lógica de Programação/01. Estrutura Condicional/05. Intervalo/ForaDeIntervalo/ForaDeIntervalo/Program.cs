using System;

namespace ForaDeIntervalo {
    internal class Program {
        static void Main(string[] args) {

            double entrada = 0;

            Console.Write("Digite um número: ");
            entrada = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (entrada >= 0 && entrada <= 25) {
                Console.WriteLine("Intervalo 0,25");
            } else if (entrada >= 25 && entrada <= 50) {
                Console.WriteLine("Intervalo 25,50");
            } else if (entrada >= 50 && entrada <= 75) {
                Console.WriteLine("Intervalo 50,75");
            } else if (entrada >= 75 && entrada <= 100) {
                Console.WriteLine("Intervalo 75,100");
            } else { Console.WriteLine("Fora de intervalo"); }

        }
    }
}