using System;
using System.Globalization;

namespace CalculoValor {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite o código da primeira peça, o número e o valor unitário: ");
            string[] dadosPeca1 = Console.ReadLine().Split(' ');

            Console.Write("Digite o código da segunda peça, o número e o valor unitário: ");
            string[] dadosPeca2 = Console.ReadLine().Split(' ');

            int quantidadePeca1 = int.Parse(dadosPeca1[1]);
            double valorUnitarioPeca1 = double.Parse(dadosPeca1[2], CultureInfo.InvariantCulture);

            int quantidadePeca2 = int.Parse(dadosPeca2[1]);
            double valorUnitarioPeca2 = double.Parse(dadosPeca2[2], CultureInfo.InvariantCulture);

            double totalAPagar = (quantidadePeca1 * valorUnitarioPeca1) + (quantidadePeca2 * valorUnitarioPeca2);

            Console.WriteLine();
            Console.Write("VALOR A PAGAR: R$ " + totalAPagar.ToString("F2"));
        }
    }
}