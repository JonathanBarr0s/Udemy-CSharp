namespace RegistroDeAcesso.Entities {
    internal class RegistroLog {

        public string Nome { get; set; }
        public DateTime Instante { get; set; }

        public override int GetHashCode() {
            return Nome.GetHashCode();
        }

        public override bool Equals(object? obj) {
            if (!(obj is RegistroLog)) {
                return false;
            }
            RegistroLog outro = obj as RegistroLog;
            return Nome.Equals(outro.Nome);
        }
    }
}
