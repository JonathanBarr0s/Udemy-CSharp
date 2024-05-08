using System.Globalization;

namespace ProcessandoArquivos {
    internal class Program {
        static void Main(string[] args) {

            string caminhoArquivoBase = @"D:\Bibliotecas do Windows\Downloads\Arquivo.txt";

            try {

                string caminhoNovaPasta = Path.GetDirectoryName(caminhoArquivoBase) + @"\out";
                string caminhoNovoArquivo = caminhoNovaPasta + @"\summary.txt";

                Directory.CreateDirectory(caminhoNovaPasta);

                using (File.Create(caminhoNovoArquivo)) { }

                string[] readAllLines = File.ReadAllLines(caminhoArquivoBase);

                using (StreamWriter sw = File.AppendText(caminhoNovoArquivo)) {

                    foreach (var line in readAllLines) {
                        string[] aux = line.Split(",");

                        Estoque estoque = new Estoque(aux[0], double.Parse(aux[1], CultureInfo.InvariantCulture), int.Parse(aux[2], CultureInfo.InvariantCulture));

                        sw.WriteLine(aux[0] + "," + estoque.Total());
                    }
                }

            } catch (Exception exception) {

                Console.WriteLine("Ocorreu o seguinte erro: " + exception);
            }

        }
    }
}