using SistemaDeLocacao.Entities;

namespace SistemaDeLocacao.Services {
    internal class ServicoDeAluguel {

        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private BrasilTaxaServico brasilTaxaServico = new BrasilTaxaServico();

        public ServicoDeAluguel(double precoPorHora, double precoPorDia) {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        public void ProcessarFatura(AluguelDeCarros aluguelDeCarros) {
            TimeSpan duracao = aluguelDeCarros.Fim.Subtract(aluguelDeCarros.Inicio);

            double preco = 0;
            if (duracao.TotalHours <= 12) {
                preco = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            } else {
                preco = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = brasilTaxaServico.Taxa(preco);
            aluguelDeCarros.Fatura = new Fatura(preco, taxa);
        }
    }
}
