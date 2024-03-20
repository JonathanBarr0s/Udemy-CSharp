namespace ConversorDeMoeda {
    class ConversorDeDolar {

        public double CotacaoDolar;
        public double IOF = 0.06;
        public double DolaresComprados;

        public double Conversao() {

            return (CotacaoDolar * DolaresComprados) * (1 + IOF);

        }

    }
}
