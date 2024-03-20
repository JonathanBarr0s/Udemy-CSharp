namespace Aprovado {
    class Aluno {

        public string Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiroTrimestre;

        public double NotaFinal() {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
        }

        public override string ToString() {

            if(NotaFinal() >= 60) {
                return string.Format("NOTA FINAL = {0:F2} \nAPROVADO", NotaFinal());
            } else {
                return string.Format("NOTA FINAL = {0:F2} \nREPROVADO\nFALTARAM {1:F2} PONTOS", NotaFinal(), (60 - NotaFinal()));
            }

        }

    }
}
