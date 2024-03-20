using System;

namespace AreaDoCirculo {
    internal class Program {
        static void Main(string[] args) {

            double area, raio;

            Console.Write("Qual o valor do raio? ");
            raio = double.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine();

            Console.WriteLine("A = " + area.ToString("F4"));

        }
    }
}