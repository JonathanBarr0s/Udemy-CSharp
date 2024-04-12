using PedidoDeCompra.Entities;
using PedidoDeCompra.Entities.Enums;
using System.Diagnostics.Metrics;

namespace PedidoDeCompra {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string clienteName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clienteName, clientEmail, birthDate);
            Order order = new Order(DateTime.Now, OrderStatus.Processing, client);

            Console.WriteLine();           

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            Enum status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int quantityOfItems = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= quantityOfItems; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(quantity, productPrice, product);
                order.AddItem(item);
            }

            Console.WriteLine(order);
        }
    }
}