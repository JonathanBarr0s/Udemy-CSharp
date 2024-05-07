namespace ProcessandoArquivos {
    internal class Estoque {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Estoque(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total() {
            return Price * Quantity;
        }
    }
}
