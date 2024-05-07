using System.Globalization;

namespace ProcessandoArquivos {
    internal class Program {
        static void Main(string[] args) {

            string path = @"D:\Bibliotecas do Windows\Downloads\Arquivo.txt";
            string newPath = path + @"\out";

            try {

                string[] allLines = File.ReadAllLines(path);

                string sourceFolderPath = Path.GetDirectoryName(path);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.txt";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath)) {
                    foreach (string line in allLines) {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Estoque estoque = new Estoque(name, price, quantity);

                        sw.WriteLine(estoque.Name + "," + estoque.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            } catch (IOException exception) {

                Console.WriteLine("Ocorreu o seguinte erro: " + exception.Message);
            }

        }
    }
}