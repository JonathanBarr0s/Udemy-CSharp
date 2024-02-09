using System;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            double numero1, numero2, soma;

            Console.Write("Digite primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            soma = numero1 + numero2;

            Console.WriteLine();

            Console.WriteLine("SOMA = " + soma);

        }
    }
}