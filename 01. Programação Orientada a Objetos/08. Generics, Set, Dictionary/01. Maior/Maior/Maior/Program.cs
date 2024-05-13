using System.Globalization;
using Maior.Services;
using Maior.Entities;

namespace Maior {
    class Program {
        static void Main(string[] args) {

            List<Produto> list = new List<Produto>();

            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                string[] aux = Console.ReadLine().Split(',');
                double preco = double.Parse(aux[1], CultureInfo.InvariantCulture);
                list.Add(new Produto(aux[0], preco));
            }

            Console.WriteLine();

            ServicoCalculo servicoCalculo = new ServicoCalculo();

            Produto p = servicoCalculo.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(p);
        }
    }
}