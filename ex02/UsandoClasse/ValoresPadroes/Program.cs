﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            Console.WriteLine(conta.titular);
            Console.ReadLine();

        }
    }
}