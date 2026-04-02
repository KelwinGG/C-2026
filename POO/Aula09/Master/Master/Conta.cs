

namespace Master
{
    internal class Conta : IOperecao
    {
//campo
        private Pessoa cliente;
        private int numero;
        private double saldo;


        //propriedade
        public int NumeroConta 
        {
            get { return numero; }
            set { numero = value; }
        }  
        
        public double SaldoConta 
        {
            get { return saldo; }
            set { saldo = value; }
        }

        

        public Pessoa DadosCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Conta(int numeroConta, double saldoConta, Pessoa dadosCliente)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
            DadosCliente = dadosCliente;
        }



        public void Deposito(double qtd)
        {
            throw new NotImplementedException();
        }

        public void Saque(double qtd)
        {
            throw new NotImplementedException();
        }
    }
}
