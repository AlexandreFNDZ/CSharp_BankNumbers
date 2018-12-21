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
            Console.ReadLine();
        }
    }
}
