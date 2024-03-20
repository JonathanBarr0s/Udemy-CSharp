using System;

namespace DadosDoFuncionario {
    internal class Program {
        static void Main(string[] args) {
            
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: R$ ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: R$ ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Funcionário: {0}", funcionario);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: {0}", funcionario);
        }
    }
}