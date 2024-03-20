using System;

namespace SenhaInvalida {
    internal class Program {
        static void Main(string[] args) {

            int senha = 2002;
            int senhaDigitada = 0;

            Console.Write("Digite a senha: ");
            senhaDigitada = int.Parse(Console.ReadLine());

            while (senhaDigitada != senha) {

                Console.WriteLine("Senha Invalida");

                Console.WriteLine();

                Console.Write("Digite a senha: ");
                senhaDigitada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}