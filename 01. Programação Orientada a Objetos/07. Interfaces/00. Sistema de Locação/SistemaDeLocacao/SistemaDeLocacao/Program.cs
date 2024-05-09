using SistemaDeLocacao.Entities;
using SistemaDeLocacao.Services;
using System.Globalization;

namespace SistemaDeLocacao {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira os dados do aluguel: ");
            Console.WriteLine();
            Console.Write("Modelo do carro: ");
            string modeloCarro = Console.ReadLine();
            Console.Write("Entrada (dd/MM/yyyy hh:mm): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Saída (dd/MM/yyyy hh:mm): ");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Insira o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine());
            Console.Write("Insira o preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine());

            AluguelDeCarros aluguelDeCarros = new AluguelDeCarros(inicio, fim, new Veiculo(modeloCarro));

            ServicoDeAluguel servicoDeAluguel = new ServicoDeAluguel(precoHora, precoDia);
            servicoDeAluguel.ProcessarFatura(aluguelDeCarros);

            Console.WriteLine();

            Console.WriteLine(aluguelDeCarros.Fatura);


        }
    }
}