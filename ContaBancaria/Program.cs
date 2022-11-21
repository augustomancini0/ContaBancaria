
using ContaBanco;
using System;
using System.Globalization;

namespace ExConta
{
    class program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o numero da conta : ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do  da conta : ");
            string titular = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Havera Deposito Inicial? (S/N) : ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 'S' || resposta == 's')
            {
                Console.WriteLine();
                Console.Write("Entre con o valor do deposito inicial : ");
                double depositoinicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoinicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
                Console.WriteLine("Dados da conta : ");
                Console.WriteLine(conta);
            }

            Console.Write("Entre com um valor para deposito : ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados : ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para Saque : ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine();
            Console.Write("Dados Atualizados : ");
            Console.WriteLine(conta);

        }
    }
}