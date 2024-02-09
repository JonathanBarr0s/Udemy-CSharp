using System;
using System.Globalization;

namespace CalculoDeArea {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite os valores de A, B e C: ");
            string[] dados = Console.ReadLine().Split(' ');

            double a = double.Parse(dados[0], CultureInfo.InvariantCulture);
            double b = double.Parse(dados[1], CultureInfo.InvariantCulture);
            double c = double.Parse(dados[2], CultureInfo.InvariantCulture);

            double areaTrianguloRetangulo = (a * c) / 2;
            double areaCirculo = Math.PI * Math.Pow(c, 2);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = (b * b);
            double areaRetangulo = (a * b);

            Console.WriteLine();

            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));


        }
    }
}