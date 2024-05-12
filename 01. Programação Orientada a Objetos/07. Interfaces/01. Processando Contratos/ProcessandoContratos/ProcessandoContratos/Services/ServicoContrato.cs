using ProcessandoContratos.Entities;
using ProcessandoContratos.Services;

internal class ServicoContrato {

    private IPagamentoOnline pagamentoOnline;

    public ServicoContrato(IPagamentoOnline pagamentoOnline) {
        this.pagamentoOnline = pagamentoOnline;
    }

    public void ProcessandoContrato(Contrato contrato, int meses) {
        
        double valorParcela = contrato.ValorTotal / meses;

        for (int i = 1; i <= meses; i++) {

            double juros = pagamentoOnline.Juros(valorParcela, i);
            double taxaPagamento = pagamentoOnline.TaxaPagamento(valorParcela + juros);

            double quotaTotal = (valorParcela + juros) + taxaPagamento;

            DateTime quotaData = contrato.Data.AddMonths(i);

            Prestacao prestacao = new Prestacao(quotaData, quotaTotal);
            contrato.adicionarPrestacao(prestacao);
        }
    }
}