using System;

namespace AluguelDeQuartos {
    internal class Program {
        static void Main(string[] args) {

            Pessoa[] quartos = new Pessoa[10];

            Console.Write("Quantos quartos serão alugados? ");
            int numeroQuartosAlugados = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numeroQuartosAlugados; i++) {
                Console.WriteLine("Aluguel #{0}:", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quartoEscolhido = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (quartos[quartoEscolhido] == null) {
                    quartos[quartoEscolhido] = new Pessoa(nome, email);
                } else {
                    while (quartos[quartoEscolhido] != null) {
                        Console.WriteLine("O quarto escolhido está ocupado, por favor escolha outro: ");
                        quartoEscolhido = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                    }
                    quartos[quartoEscolhido] = new Pessoa(nome, email);
                }
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine("{0}: {1}", i, quartos[i]);
                }
            }
        }
    }
}