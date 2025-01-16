using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Desafio
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInical) : this(numero, titular)
        {
            Deposito(depositoInical);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Dados Atualizados: \n"
                + "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", valor do saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + " Reais";
        }
    }
}
