namespace DadosDoFuncionario {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += SalarioBruto * (porcentagem/100);
        }

        public override string ToString() {
            return string.Format("{0}, R$ {1:F2}", Nome, SalarioLiquido());
        }

    }
}
