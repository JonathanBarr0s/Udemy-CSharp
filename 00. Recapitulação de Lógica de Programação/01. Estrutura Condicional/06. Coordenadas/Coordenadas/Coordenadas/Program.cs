using System;

namespace Coordenadas {
    internal class Program {
        static void Main(string[] args) {

            double coordenadaX = 0;
            double coordenadaY = 0;

            Console.Write("Digite o valor para X: ");
            coordenadaX = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor para Y: ");
            coordenadaY = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (coordenadaX > 0 && coordenadaY > 0) {
                Console.WriteLine("Q1");
            } else if (coordenadaX < 0 && coordenadaY > 0) {
                Console.WriteLine("Q2");
            } else if (coordenadaX < 0 && coordenadaY < 0) {
                Console.WriteLine("Q3");
            } else if (coordenadaX > 0 && coordenadaY < 0) {
                Console.WriteLine("Q4");
            } else if (coordenadaX == 0 && coordenadaY == 0) {
                Console.WriteLine("Origem");
            }
        }
    }
}

