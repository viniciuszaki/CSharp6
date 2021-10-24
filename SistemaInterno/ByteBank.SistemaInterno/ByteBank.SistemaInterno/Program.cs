using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123,123345);

            Console.WriteLine(conta.Saldo);

            conta.Sacar(10);
            string nome = "guilherme";

            Console.ReadLine();
        }
    }
}
