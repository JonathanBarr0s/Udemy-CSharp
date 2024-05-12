namespace ProcessandoContratos.Entities {
    internal class Prestacao {

        public DateTime DataPrestacao { get; set; }
        public double Quantia { get; set; }

        public Prestacao(DateTime dataPrestacao, double quantia) {
            DataPrestacao = dataPrestacao;
            Quantia = quantia;
        }
    }
}
