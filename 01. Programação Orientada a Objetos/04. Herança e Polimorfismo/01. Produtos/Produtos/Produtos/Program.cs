using Produtos.Entities;

namespace Produtos {
    internal class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numberOfProducts; i++) {

                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                int price = int.Parse(Console.ReadLine());

                if (productType == 'i') {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    ImportedProduct importedProduct = new ImportedProduct(name, price, customsFee);
                    list.Add(importedProduct);
                } else if (productType == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    UsedProduct usedProduct = new UsedProduct(name, price, manufactureDate);
                    list.Add(usedProduct);
                } else {
                    Product product = new Product(name, price);
                    list.Add(product);
                }

                Console.WriteLine();

            }

            Console.WriteLine("PRICE TAGS:");
            Console.WriteLine();
            foreach (var item in list) {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}