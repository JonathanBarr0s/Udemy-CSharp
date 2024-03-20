namespace ContaBancaria {
    internal class Banco {

        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Banco(int numeroConta, string titular) {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public Banco(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double saldo) {
            Saldo += saldo;
        }

        public void Saque(double saldo) {
            Saldo -= saldo + 5;
        }

        public override string ToString() {
            return string.Format("Conta {0}, Titular: {1}, Saldo: $ {2:F2}", NumeroConta, Titular, Saldo);
        }
    }
}
