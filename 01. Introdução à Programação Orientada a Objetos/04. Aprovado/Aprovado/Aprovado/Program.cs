using System;

namespace Aprovado {
    internal class Program {
        static void Main(string[] args) {
            
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a nota do primeiro trimestre: ");
            aluno.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do segundo trimestre: ");
            aluno.NotaSegundoTrimestre = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do terceiro trimestre: ");
            aluno.NotaTerceiroTrimestre = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(aluno);

        }
    }
}