namespace AluguelDeQuartos {
    internal class Pessoa {

        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return string.Format("{0}, {1}", Nome, Email);
        }
    }
}
