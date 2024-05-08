using System.Globalization;

namespace ProcessandoArquivos {
    internal class Estoque {

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Estoque(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Total() {
            double total = Preco * Quantidade;
            return total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
