using System;

namespace PessoaMaisVelha {
    internal class Program {
        static void Main(string[] args) {

            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primeiraPessoa.nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segundaPessoa.nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (primeiraPessoa.idade > segundaPessoa.idade) {

                Console.WriteLine("Pessoa mais velha: {0}", primeiraPessoa.nome);

            } else {
                Console.WriteLine("Pessoa mais velha: {0}", segundaPessoa.nome);
            }
        }
    }
}