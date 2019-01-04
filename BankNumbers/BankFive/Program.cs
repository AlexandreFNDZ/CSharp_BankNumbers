using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFive
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(007, 12345);

            Console.WriteLine(conta.Numero);


            ConversorMoeda converter = new ConversorMoeda("https://www.banknumbers.com/conversor?moedaDestino=real&moedaOrigem=dolar&valor=500");

            string moedaOrigem = converter.GetValor("moedaOrigem");
            Console.WriteLine("Moeda de origem: " + moedaOrigem);

            string moedaDestino = converter.GetValor("moedaDestino");
            Console.WriteLine("Moeda de destino: " + moedaDestino);

            string valor = converter.GetValor("valor");
            Console.WriteLine("Valor a converter: " + valor);

            Console.ReadLine();
        }
    }
}
