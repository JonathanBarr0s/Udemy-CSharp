using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidoDeCompra.Entities.Enums;

namespace PedidoDeCompra.Entities {
    internal class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Item.Remove(item);
        }
        public double Total() {
            double sum = 0;
            foreach (var item in Item) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment.ToString()}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine($"Client: {Client.name} ({Client.BirthDate.ToShortDateString()}) - {Client.email}");
            sb.AppendLine();
            sb.AppendLine("Order items:");
            foreach (var item in Item) {
                sb.AppendLine($"{item.Product.Name}, ${item.Price:F2}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal():F2}");
            }
            sb.AppendLine($"Total price: ${Total():F2}");

            return sb.ToString();
        }
    }
}
