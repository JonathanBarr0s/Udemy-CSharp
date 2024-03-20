using System;

namespace DadosDoRetangulo {
    internal class Program {
        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();          
            
            Console.Write("Digite a largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            retangulo.Altura= double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("AREA = {0}", retangulo.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = {0}", retangulo.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = {0}", retangulo.Diagonal().ToString("F2"));

        }
    }
}