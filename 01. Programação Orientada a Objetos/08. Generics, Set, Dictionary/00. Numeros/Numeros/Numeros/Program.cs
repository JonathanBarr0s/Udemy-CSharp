using Numeros.Services;

namespace Numeros {
    internal class Program {
        static void Main(string[] args) {
            
            ServicoImpressao<string> servicoImpressao = new ServicoImpressao<string>();

            Console.Write("Quantos valores? ");
            int quantidadeValores = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeValores; i++) {
                
                string valor = Console.ReadLine();
                servicoImpressao.AdicionarValores(valor);
            }

            Console.WriteLine();
            servicoImpressao.Imprimir();
            servicoImpressao.Primeiro();
        }
    }
}