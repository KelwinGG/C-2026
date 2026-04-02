

namespace Master
{
    internal class ContaPJ : Conta
    {
		//campo
		private double limite;


        //propriedade
        public double LimiteConta
		{
			get { return limite; }
			set { limite = value; }
		}

        public ContaPJ(int numeroConta, double saldoConta, Pessoa dadosCliente) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }

        public void Emprestimo(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd; 
        }
	}
}
