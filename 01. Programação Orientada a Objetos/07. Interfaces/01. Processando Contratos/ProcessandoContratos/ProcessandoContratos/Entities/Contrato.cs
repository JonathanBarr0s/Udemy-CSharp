using System.Text;

namespace ProcessandoContratos.Entities {
    internal class Contrato {

        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public Prestacao Prestacao { get; set; }

        List<Prestacao> prestacoes = new List<Prestacao>();

        public Contrato(int numero, DateTime data, double valorTotal) {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
        }

        public void adicionarPrestacao(Prestacao prestacao) {
            prestacoes.Add(prestacao);
        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();

            foreach (var prestacao in prestacoes) {
                sb.AppendLine(prestacao.DataPrestacao.ToShortDateString() + " - R$ " + prestacao.Quantia.ToString("F2"));
            }

            return sb.ToString();
        }
    }
}
