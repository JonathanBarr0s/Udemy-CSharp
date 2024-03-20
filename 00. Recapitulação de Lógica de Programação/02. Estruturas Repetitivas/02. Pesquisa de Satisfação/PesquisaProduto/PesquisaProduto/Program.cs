using System;

namespace PesquisaProduto {
    internal class Program {
        static void Main(string[] args) {

            int contagemAlcool = 0;
            int contagemGasolina = 0;
            int contagemDiesel = 0;

            int codigoFinalizar = 4;

            int codigoDigitado = int.Parse(Console.ReadLine());

            while (codigoDigitado != codigoFinalizar) {

                if (codigoDigitado == 1) {
                    contagemAlcool++;
                } else if (codigoDigitado == 2) {
                    contagemGasolina++;
                } else if (codigoDigitado == 3) {
                    contagemDiesel++;
                }

                codigoDigitado = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contagemAlcool);
            Console.WriteLine("Gasolina: " + contagemGasolina);
            Console.WriteLine("Diesel: " + contagemDiesel);
        }
    }
}