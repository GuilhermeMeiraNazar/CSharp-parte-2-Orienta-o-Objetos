using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciador_de_solucoes;

namespace Gerenciador_de_solucoes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = 100;
            Console.Write(conta.Saldo);

            Cliente cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.CPF = "8464656";
            cliente.Profissao = "Desenvolvedor";

            Console.ReadLine();

        }
    }
}