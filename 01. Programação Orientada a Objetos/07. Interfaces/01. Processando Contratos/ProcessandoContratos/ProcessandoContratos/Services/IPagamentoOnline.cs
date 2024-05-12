namespace ProcessandoContratos.Services {
    interface IPagamentoOnline {
        public double TaxaPagamento(double quantia);

        public double Juros(double quantia, int meses);
    }
}
