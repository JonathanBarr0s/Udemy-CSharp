using System.Globalization;

namespace Maior.Entities {
    class Produto : IComparable {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public int CompareTo(object obj) {
            Produto other = obj as Produto;
            return Preco.CompareTo(other.Preco);
        }

        public override string ToString() {
            return Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}