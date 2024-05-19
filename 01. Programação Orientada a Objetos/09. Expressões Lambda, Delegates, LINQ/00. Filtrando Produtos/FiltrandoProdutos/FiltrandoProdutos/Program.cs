using FiltrandoProdutos.Entities;
using System.Globalization;

namespace FiltrandoProdutos {
    internal class Program {
        static void Main(string[] args) {

            List<Produto> produtos = new List<Produto>();

            string path = @"D:\Bibliotecas do Windows\Downloads\in.txt";

            using (StreamReader sr = File.OpenText(path)) {

                while (!sr.EndOfStream) {
                    string[] linha = sr.ReadLine().Split(',');
                    string nome = linha[0];
                    double preco = double.Parse(linha[1], CultureInfo.InvariantCulture);
                    produtos.Add(new Produto(nome, preco));
                }
            }

            var media = produtos.Select(produto => produto.Preco).Average();
            Console.WriteLine($"Preço médio: R$ {media.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();

            var nomes = produtos.Where(produto => produto.Preco < media).OrderByDescending(produto => produto.Nome).Select(produto => produto.Nome);

            foreach (var produto in nomes) {
                Console.WriteLine(produto);
            }
        }
    }
}