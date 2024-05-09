namespace SistemaDeLocacao.Services {
    internal class BrasilTaxaServico {

        public double Taxa(double quantia) {

            if (quantia <= 100) {
                return quantia * 0.2;
            } else {
                return quantia * 0.15;
            }
        }
    }
}
