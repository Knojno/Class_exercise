using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercio_curso_ContaBancaria
{
    class ContaBancaria
    {
        public int NumerodaConta { get; private set; }
        public string Nome { get; set; }

        public double Saldo { get; set; }

        public ContaBancaria(int numero, string nome)
        {
            NumerodaConta = numero;
            Nome = nome;

        }
        public ContaBancaria(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }



        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {
            Saldo -= valor;
            Saldo = Saldo - 5;

        }

        public override string ToString()
        {
            return "Conta: "+ NumerodaConta + " , " + "Nome: "+ Nome + " , " + "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
