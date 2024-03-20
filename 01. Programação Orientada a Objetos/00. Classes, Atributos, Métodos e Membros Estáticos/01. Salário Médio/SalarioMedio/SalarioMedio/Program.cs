using System;

namespace SalarioMedio {
    internal class Program {
        static void Main(string[] args) {
            
            Funcionario primeiroFuncionario = new Funcionario();
            Funcionario segundoFuncionario = new Funcionario();

            double salarioMedio;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            primeiroFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            primeiroFuncionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            segundoFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            segundoFuncionario.Salario = double.Parse(Console.ReadLine());

            salarioMedio = (primeiroFuncionario.Salario + segundoFuncionario.Salario) / 2;

            Console.WriteLine();

            Console.WriteLine("Salário médio = {0}", salarioMedio);

        }
    }
}