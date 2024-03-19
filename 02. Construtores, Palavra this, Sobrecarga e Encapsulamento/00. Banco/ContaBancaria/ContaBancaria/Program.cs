using System;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            Banco cliente;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                cliente = new Banco(numeroConta, titular, depositoInicial);
            } else {
                cliente = new Banco(numeroConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + cliente);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double transacao = double.Parse(Console.ReadLine());
            cliente.Deposito(transacao);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:\nDados da conta: " + cliente);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            transacao = double.Parse(Console.ReadLine());
            cliente.Saque(transacao);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:\nDados da conta: " + cliente);
        }
    }
}