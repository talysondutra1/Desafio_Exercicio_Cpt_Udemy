using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Desafio_Exercicio_Cpt_Udemy
{
     class Conta
    {
        public string Titular { get; set; }
        public int Numero { get; private set; }   
        public double Saldo {  get; private set; }      
        public Conta (string nome, int numero) { 
            Titular = nome;
            Numero = numero;            
        }
        public Conta (string nome, int numero, double saldo) : this(nome, numero) 
        {
                Saldo = saldo;
        }
        public string Nome
        {
            get { return Titular; }
            set 
            {
                if (value != null && value.Length > 1) 
                {
                    Titular = value;
                }
            }
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
            return "conta " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
