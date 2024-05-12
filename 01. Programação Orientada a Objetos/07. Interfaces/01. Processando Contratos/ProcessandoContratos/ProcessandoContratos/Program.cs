using ProcessandoContratos.Entities;
using ProcessandoContratos.Services;
using System.Globalization;

namespace ProcessandoContratos {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira os dados do contrato");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/aaaa): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: R$ ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Insira o número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            ServicoContrato servicoContrato = new ServicoContrato(new Paypal());
            servicoContrato.ProcessandoContrato(contrato, parcelas);

            Console.WriteLine();
            Console.WriteLine("Parcelas:");
            Console.WriteLine(contrato.ToString());
        }
    }
}