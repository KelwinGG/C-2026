

namespace Banco
{
    internal class ContaBancaria
    {
        //campos
        private int numero;
        private string titular;
        private double saldo;


        public ContaBancaria(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero , titular)
        {
            this.saldo = saldo;
        }

        
        //metodo 
        public void Deposito(double quantia)
        {
            saldo += quantia;
        }

        public void Saque(double quantia)
        {
            saldo -= quantia;
        }
        public void Dados()
        {
            Console.WriteLine("Dados da conta cadastrada ");
            Console.WriteLine($"\tNumero da conta: {numero}\n +" +
                $"\tNumero da conta: {numero} \n +" +
                $"\tSaldo da conta:  R$ {saldo}");
        }
    }
}
