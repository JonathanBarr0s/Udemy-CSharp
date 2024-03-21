namespace Empresa {
    internal class Empregado {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Empregado(int id, string name, double salario) {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem) {
            Salario = Salario * (1 + (porcentagem / 100));
        }

        public override string ToString() {
            return string.Format("{0}, {1}, {2:F2}", Id, Name, Salario);
        }
    }
}
