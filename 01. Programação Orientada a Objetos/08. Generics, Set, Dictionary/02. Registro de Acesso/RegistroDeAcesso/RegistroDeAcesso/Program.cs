using RegistroDeAcesso.Entities;

namespace RegistroDeAcesso {
    internal class Program {
        static void Main(string[] args) {

            HashSet<RegistroLog> set = new HashSet<RegistroLog>();

            string path = @"D:\Bibliotecas do Windows\Downloads\in.txt";

            try {

                using (StreamReader sr = File.OpenText(path)) {

                    while (!sr.EndOfStream) {
                        string[] linha = sr.ReadLine().Split(' ');
                        string nome = linha[0];
                        DateTime instante = DateTime.Parse(linha[1]);
                        set.Add(new RegistroLog { Instante = instante, Nome = nome });
                    }
                    Console.WriteLine($"Total de usuários: {set.Count}");
                }

            } catch (IOException exception) {
                Console.WriteLine(exception.Message);
            }
        }
    }
}