﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    //código omitido

    namespace bytebank
    {
        public class ContaCorrente
        {
            public int numero_agencia;
            public string conta;
            public string titular;
            public double saldo;
            public void Depositar(double valor)
            {
                this.saldo += valor;
            }
            public void Sacar(double valor)
            {
                this.saldo -= valor;
            }
        }
    }
}
