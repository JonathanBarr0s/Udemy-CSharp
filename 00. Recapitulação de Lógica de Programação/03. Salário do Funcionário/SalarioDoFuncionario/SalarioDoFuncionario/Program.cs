using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            int numeroDoFuncionario, horasTrabalhadas;
            double valorDaHora, salario;

            Console.Write("Digite seu número de funcionário: ");
            numeroDoFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor que recebe por hora: ");
            valorDaHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorDaHora;

            Console.WriteLine();

            Console.WriteLine("NUMBER = " + numeroDoFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}