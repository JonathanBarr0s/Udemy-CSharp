using System;

namespace Matriz {
    internal class Program {
        static void Main(string[] args) {

            string[] tamanhoMatriz = new string[1];

            Console.Write("Digite o tamanho da matriz: ");
            tamanhoMatriz = Console.ReadLine().Split(' ');

            double[,] matriz = new double[int.Parse(tamanhoMatriz[0]), int.Parse(tamanhoMatriz[1])];

            Console.WriteLine();

            for (int i = 0; i < int.Parse(tamanhoMatriz[0]); i++) {
                Console.Write("Digite os valores da linha {0} da matriz: ", i);
                string[] valores = Console.ReadLine().Split(" ");

                for (int j = 0; j < int.Parse(tamanhoMatriz[1]); j++) {

                    matriz[i, j] = int.Parse(valores[j]);

                }
            }

            Console.WriteLine();

            Console.Write("Digite um número que pertence a matriz: ");
            int buscarNumero = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] posicaoNumeroBuscado = new int[2];

            for (int linha = 0; linha < int.Parse(tamanhoMatriz[0]); linha++) {
                for (int coluna = 0; coluna < int.Parse(tamanhoMatriz[1]); coluna++) {
                    if (matriz[linha, coluna] == buscarNumero) {
                        posicaoNumeroBuscado[0] = linha;
                        posicaoNumeroBuscado[1] = coluna;
                        Console.WriteLine("Position: {0},{1}", posicaoNumeroBuscado[0], posicaoNumeroBuscado[1]);
                        if (posicaoNumeroBuscado[1] - 1 >= 0) {
                            Console.WriteLine("Left: {0}", matriz[posicaoNumeroBuscado[0], (posicaoNumeroBuscado[1] - 1)]);
                        }
                        if (posicaoNumeroBuscado[1] + 1 < int.Parse(tamanhoMatriz[1])) {
                            Console.WriteLine("Right: {0}", matriz[(posicaoNumeroBuscado[0]), (posicaoNumeroBuscado[1] + 1)]);
                        }
                        if (posicaoNumeroBuscado[0] - 1 >= 0) {
                            Console.WriteLine("Up: {0}", matriz[(posicaoNumeroBuscado[0] - 1), posicaoNumeroBuscado[1]]);
                        }
                        if (posicaoNumeroBuscado[0] + 1 < int.Parse(tamanhoMatriz[0])) {
                            Console.WriteLine("Down: {0}", matriz[(posicaoNumeroBuscado[0] + 1), posicaoNumeroBuscado[1]]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}