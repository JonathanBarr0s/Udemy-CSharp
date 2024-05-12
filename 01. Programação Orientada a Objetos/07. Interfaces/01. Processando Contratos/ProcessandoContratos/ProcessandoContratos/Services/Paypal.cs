namespace ProcessandoContratos.Services {
    class Paypal : IPagamentoOnline {

        public double TaxaPagamento(double quantia) {
            return quantia * 0.02;
        }

        public double Juros(double quantia, int meses) {
            return (quantia * 0.01) * meses;            
        }
    }
}
