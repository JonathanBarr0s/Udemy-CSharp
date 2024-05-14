namespace ContagemDeVotos {
    internal class Program {
        static void Main(string[] args) {

            string path = @"D:\Bibliotecas do Windows\Downloads\in.txt";

            try {

                Dictionary<string, int> candidatosEVotos = new Dictionary<string, int>();

                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] linha = sr.ReadLine().Split(',');
                        string nome = linha[0];
                        int votos = int.Parse(linha[1]);

                        if (candidatosEVotos.ContainsKey(nome)) {
                            candidatosEVotos[nome] += votos;
                        } else {
                            candidatosEVotos[nome] = votos;
                        }
                    }
                }

                foreach (var candidato in candidatosEVotos) {
                    Console.WriteLine(candidato.Key + ": " + candidato.Value);
                }

            } catch (Exception exception) {

                Console.WriteLine("Erro: " + exception.Message);
            }
        }
    }
}