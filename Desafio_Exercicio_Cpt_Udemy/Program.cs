using Desafio;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Informe o número da conta: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o titular da conta: ");
            string t = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Informe o valor do depósito inicial (S/N): ");
                double di = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(n, t, di);
            }
            else
            {
                conta = new ContaBancaria(n, t);
            }

            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Informe o valor para depóstito: ");
            double df = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(df);

            Console.WriteLine();
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Informe o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Deseja realizar uma nova operação (s/n)? ");
            resp = char.Parse(Console.ReadLine());

            while (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Qual operação você quer fazer? S para saque e D para deposito:");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 's' || resposta == 'S')
                {
                    Console.WriteLine("Qual o valor do saque? ");
                    df = double.Parse(Console.ReadLine());
                    conta.Saque(df);
                    Console.WriteLine(conta);
                }
                else
                {
                    Console.WriteLine("Qual o valor do depósito? ");
                    df = double.Parse(Console.ReadLine());
                    conta.Deposito(df);
                    Console.WriteLine(conta);
                }

                Console.WriteLine();
                Console.WriteLine("Deseja realizar uma nova operação (s/n)? ");
                resp = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Obrigado, volte sempre!");
        }
    }
}