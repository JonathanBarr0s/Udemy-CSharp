using System;

namespace ContaAPagar {
    internal class Program {
        static void Main(string[] args) {

            double cachorroQuente = 4;
            double xSalada = 4.5;
            double xBacon = 5;
            double torradaSimples = 2;
            double refrigerante = 1.5;

            int codigo = 0;
            int quantidade = 0;
            double conta = 0;

            Console.Write("Digite o código: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1) {
                conta = cachorroQuente * quantidade;
            } else if (codigo == 2) {
                conta = xSalada * quantidade;
            } else if (codigo == 3) {
                conta = xBacon * quantidade;
            } else if (codigo == 4) {
                conta = torradaSimples * quantidade;
            } else if (codigo == 5) {
                conta = refrigerante * quantidade;
            }

            Console.WriteLine();

            Console.WriteLine("Total: R$ " + conta);

        }
    }
}

