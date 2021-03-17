using System;
using System.Globalization;

namespace Exercio_curso_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria c;
            
            Console.WriteLine("Nome do Titular");
            string Nome = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Numero da conta");
            int NumerodaConta = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Havera deposito inicial? S/N");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'S')
            {
                Console.WriteLine("Entre com o valor do deposito");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(NumerodaConta, Nome, DepositoInicial);

            }
            else
            {
                c = new ContaBancaria(NumerodaConta, Nome);
            }

            
            
            
            //
             
            //
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(c);
            Console.WriteLine("--------------------------------------------------");
            //
            Console.WriteLine("Valor do proximo deposito:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(c.Saldo);
            Console.WriteLine("--------------------------------------------------");
            //
            Console.WriteLine("Valor do saque:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valor);
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(c.Saldo);

        }
    }
}
