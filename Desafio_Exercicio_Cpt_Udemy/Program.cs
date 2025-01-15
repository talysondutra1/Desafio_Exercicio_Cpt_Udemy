using Desafio_Exercicio_Cpt_Udemy;
using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.WriteLine("entre com o número da conta: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("entre com o titular da conta: ");
            string t = Console.ReadLine();
            Console.WriteLine("haverá depósito inicial (s/n)? ");
            char d = char.Parse(Console.ReadLine());

            if (d == 's' || d == 'S')
            {
                Console.WriteLine("entre com o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(t, n, valor);
            }
            else
            {       
                 conta = new Conta(t, n);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}