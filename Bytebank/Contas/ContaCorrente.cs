using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank.Titular;

namespace Bytebank
{
    //código omitido

    namespace bytebank
    {
        public class ContaCorrente
        {
            public int numero_agencia;
            public string conta;          
            public double saldo;

            public Cliente titular;
            public void Depositar(double valor)
            {
                this.saldo += valor;
            }
            public bool Sacar(double valor)
            {
                if (valor <= this.saldo)
                {
                    this.saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool Transferir(double valor, ContaCorrente destino)
            {
                if(this.saldo < valor)
                {
                    return false;
                }
                else
                {
                    this.Sacar(valor);
                    destino.Depositar(valor);
                    return true;
                }
                
            }
            public double ObterSaldo()
            {
                return this.saldo;
            }
            public void DefinirSaldo(double valor)
            {
                if (valor < 0)
                {
                    return;
                }
                else
                {
                    this.saldo = valor;
                }
            }
        }
    }
}
