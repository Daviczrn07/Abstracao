using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao
{
    internal class ContaBancaria
    {
        public string Titular;
        public int NumeroConta;
        public double Saldo;

        public ContaBancaria(string titular, int numero, double saldo)
        {
            Titular = titular;
            NumeroConta = numero;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo não é suficiente.");
            }
        }
    }
}
