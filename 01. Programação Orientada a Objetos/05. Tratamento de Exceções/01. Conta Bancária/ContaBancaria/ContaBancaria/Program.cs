using ContaBancaria.Entities;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            try {

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                account.Withdraw(withdraw);

                Console.WriteLine();
                Console.WriteLine(account);

            } catch (Exception exception) {

                Console.WriteLine();
                Console.WriteLine($"Withdraw error: {exception.Message}");
            }
        }
    }
}