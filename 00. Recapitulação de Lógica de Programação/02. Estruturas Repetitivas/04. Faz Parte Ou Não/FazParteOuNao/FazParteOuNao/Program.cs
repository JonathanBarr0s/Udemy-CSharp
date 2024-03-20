using System;

namespace FazParteOuNao {
    internal class Program {
        static void Main(string[] args) {

            int contagemIn = 0;
            int contagemOut = 0;

            Console.Write("Digite as quantidades: ");
            int quantidadeDigitada = int.Parse(Console.ReadLine());
            int[] valores = new int[quantidadeDigitada];

            Console.WriteLine();

            for (int i = 0; i < quantidadeDigitada; i++) {
                Console.Write("Digite um número: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < quantidadeDigitada; i++) {
                if (valores[i] >= 10 && valores[i] <= 20) {
                    contagemIn++;
                } else {
                    contagemOut++;
                }
            }

            Console.WriteLine("{0} in", contagemIn);
            Console.WriteLine("{0} out", contagemOut);
        }
    }
}