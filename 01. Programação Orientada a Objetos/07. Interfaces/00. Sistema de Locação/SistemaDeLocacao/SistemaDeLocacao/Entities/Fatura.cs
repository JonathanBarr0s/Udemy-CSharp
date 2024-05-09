using System.Text;

namespace SistemaDeLocacao.Entities {
    internal class Fatura {

        public double Preco { get; set; }
        public double Taxa { get; set; }
        public double Total {
            get {
                return Preco + Taxa;
            }
        }


        public Fatura(double preco, double taxa) {
            Preco = preco;
            Taxa = taxa;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Fatura:");
            sb.AppendLine("Preço: R$ " + Preco.ToString("F2"));
            sb.AppendLine("Taxa: R$ " +  Taxa.ToString("F2"));
            sb.AppendLine("Total: R$ " +  Total.ToString("F2"));
            return sb.ToString();
        }
    }
}
