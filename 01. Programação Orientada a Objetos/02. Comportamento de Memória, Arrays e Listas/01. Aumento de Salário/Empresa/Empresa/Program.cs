using System;

namespace Empresa {
    internal class Program {
        static void Main(string[] args) {

            List<Empregado> listaEmpregados = new List<Empregado>();

            Console.Write("Quantos funcionários serão cadastrados? ");
            int quantidadeNovosCadastros = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= quantidadeNovosCadastros; i++) {
                Console.WriteLine("Funcionário nº {0}:", i);
                Console.Write("Identidade: ");
                int identidade = int.Parse(Console.ReadLine());

                Empregado verificandoSeIdJaExiste = listaEmpregados.Find(id => id.Id == identidade);

                if (verificandoSeIdJaExiste == null) {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Salário: ");
                    double salario = int.Parse(Console.ReadLine());
                    listaEmpregados.Add(new Empregado(identidade, nome, salario));
                    Console.WriteLine();
                } else {
                    while (verificandoSeIdJaExiste != null) {
                        Console.WriteLine();
                        Console.Write("Este ID já existe, digite outro: ");
                        identidade = int.Parse(Console.ReadLine());
                        verificandoSeIdJaExiste = listaEmpregados.Find(id => id.Id == identidade);
                        Console.WriteLine();
                    }
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Salário: ");
                    double salario = int.Parse(Console.ReadLine());
                    listaEmpregados.Add(new Empregado(identidade, nome, salario));
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            Console.Write("Informe o ID do funcionário que terá aumento salarial: ");
            int idFuncionarioAumento = int.Parse(Console.ReadLine());

            Empregado verificarSeIdExiste = listaEmpregados.Find(id => id.Id == idFuncionarioAumento);

            if (verificarSeIdExiste != null) {
                Console.Write("Digite a porcentagem de aumento: ");
                double porcentagemAumentoSalarial = double.Parse(Console.ReadLine());
                verificarSeIdExiste.AumentoSalario(porcentagemAumentoSalarial);
            } else {
                while (verificarSeIdExiste == null) {
                    Console.WriteLine();
                    Console.Write("Este ID não existe, digite outro: ");
                    idFuncionarioAumento = int.Parse(Console.ReadLine());
                    verificarSeIdExiste = listaEmpregados.Find(id => id.Id == idFuncionarioAumento);
                }
                Console.Write("Digite a porcentagem de aumento: ");
                double porcentagemAumentoSalarial = double.Parse(Console.ReadLine());
                verificarSeIdExiste.AumentoSalario(porcentagemAumentoSalarial);
            }

            Console.WriteLine();

            foreach (Empregado item in listaEmpregados) {
                Console.WriteLine(item);
            }
        }
    }
}