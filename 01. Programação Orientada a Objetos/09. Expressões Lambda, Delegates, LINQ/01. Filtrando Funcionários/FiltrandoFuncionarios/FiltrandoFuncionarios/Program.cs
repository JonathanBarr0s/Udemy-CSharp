using System.Globalization;

namespace FiltrandoFuncionarios {
    internal class Program {
        static void Main(string[] args) {

            List<Funcionarios> funcionarios = new List<Funcionarios>();

            string path = @"D:\Bibliotecas do Windows\Downloads\in.txt";

            using (StreamReader sr = File.OpenText(path)) {

                while (!sr.EndOfStream) {
                    string[] linha = sr.ReadLine().Split(',');
                    string nome = linha[0];
                    string email = linha[1];
                    double salario = double.Parse(linha[2], CultureInfo.InvariantCulture);

                    funcionarios.Add(new Funcionarios(nome, email, salario));
                }
            }

            Console.Write("Digite o sálario: R$ ");
            double filtroSalario = double.Parse(Console.ReadLine());

            var filtrandoPorSalario = funcionarios.Where(funcionario => funcionario.Salario > filtroSalario).OrderBy(funcionario => funcionario.Email).Select(funcionario => funcionario.Email);

            Console.WriteLine();

            Console.WriteLine($"Email de pessoas cujo salário é superior a R$ {filtroSalario.ToString("F2")}:");

            foreach (var funcionario in filtrandoPorSalario) {
                Console.WriteLine(funcionario);
            }

            var soma = funcionarios.Where(funcionario => funcionario.Nome[0] == 'M').Select(funcionario => funcionario.Salario).Sum();
            
            Console.WriteLine();
            
            Console.Write("Soma do salário das pessoas cujo nome começa com 'M': R$ ");
            Console.WriteLine(soma.ToString("F2"));
        }
    }
}