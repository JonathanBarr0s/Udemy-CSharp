using System;

namespace DivisaoEmSequencia {
    internal class Program {
        static void Main(string[] args) {

            int[] divisoes = new int[2];
            
            Console.Write("Digite a quantidade: ");
            int quantidadeDigitada = int.Parse(Console.ReadLine());
            string[] resultados = new string[quantidadeDigitada];

            Console.WriteLine();

            for (int i = 0; i < quantidadeDigitada; i++) {
                Console.Write("Digite os números separados por espaço: ");
                string[] entrada = Console.ReadLine().Split(' ');

                int a = int.Parse(entrada[0]);
                int b = int.Parse(entrada[1]);

                if (b == 0) {
                    resultados[i] = "divisao impossivel";
                } else {
                    double conta = (double)a / (double)b;
                    resultados[i] = conta.ToString();
                }
            }

            Console.WriteLine();

            for (int i = 0;i < quantidadeDigitada;i++) {
                Console.WriteLine(resultados[i]);
            }
        }
    }
}