using ContaBancaria.Entities.Exceptions;

namespace ContaBancaria.Entities {
    internal class Account {

        private int Number { get; set; }
        private string Holder { get; set; }
        private double Balance { get; set; }
        private double WhithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double whithdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WhithdrawLimit = whithdrawLimit;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
        public void Withdraw(double amount) {

            if (amount > WhithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");
            } else if (amount > Balance) {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
        public override string ToString() {
            return $"New balance: R$ {Balance.ToString("F2")}";
        }
    }
}
