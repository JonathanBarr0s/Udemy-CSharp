using System;
using System.Globalization;

namespace ConversorDeMoeda {
    internal class Program {
        static void Main(string[] args) {

            ConversorDeDolar conversor = new ConversorDeDolar();

            Console.Write("Qual é a cotação do dólar? ");
            conversor.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
          
            Console.Write("Quantos dólares você vai comprar? ");
            conversor.DolaresComprados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine(string.Format("Valor a ser pago em reais = {0:F2}", conversor.Conversao(), CultureInfo.InvariantCulture));

        }
    }
}