using System.Security.Cryptography;
using System.Text;

namespace Numeros.Services {
    internal class ServicoImpressao<T> {

        public T[] valores = new T[10];
        public int contador = 0;

        public ServicoImpressao() {
        }

        public void AdicionarValores(T valor) {

            valores[contador] = valor;
            contador++;
        }

        public void Primeiro() {
            Console.WriteLine("Primeiro: " + valores[0]);
        }

        public void Imprimir() {

            Console.Write("[");

            for (int i = 0; i <= contador - 2; i++) {
                Console.Write(valores[i] + ", ");
            }

            Console.WriteLine(valores[contador - 1] + "]");
        }
    }
}
