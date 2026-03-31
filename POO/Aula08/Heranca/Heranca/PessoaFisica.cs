using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class PessoaFisica
    {
        private int numero;
        private string titular;
        private double saldo;



        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }




        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }

        public PessoaFisica(double saldoConta, string titularConta, int numeroConta)
        {
            SaldoConta = saldoConta;
            TitularConta = titularConta;
            NumeroConta = numeroConta;
        }

        public PessoaFisica(string titularConta, int numeroConta) : this(numeroConta, titularConta, 0)
        {

            SaldoConta = 0;
        }
        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
        public void Deposito(double quantia)
        { 
          SaldoConta += quantia; 
        }

        public override string ToString()
        {
            return $"Dados do cliente " +
                $"\n \t Numero da conta: {NumeroConta}" +
                $"\n \t Titular da conta: {TitularConta}" +
                $"\n \t Saldo da conta: {SaldoConta:C}";
        }
    }
}
