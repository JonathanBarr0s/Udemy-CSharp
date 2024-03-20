using System;

namespace TempoDeJogo {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite a hora inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora final: ");
            int horaFinal = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int tempoDeJogo = 0;

            if (horaInicial < horaFinal) {
                tempoDeJogo = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");

            } else {
                tempoDeJogo = 24 - (horaInicial - horaFinal);
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");
            }


        }
    }
}