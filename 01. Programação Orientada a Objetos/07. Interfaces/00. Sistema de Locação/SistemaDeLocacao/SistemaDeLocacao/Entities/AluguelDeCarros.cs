namespace SistemaDeLocacao.Entities {
    internal class AluguelDeCarros {

        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelDeCarros(DateTime inicio, DateTime fim, Veiculo veiculo) {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
        }
    }
}
