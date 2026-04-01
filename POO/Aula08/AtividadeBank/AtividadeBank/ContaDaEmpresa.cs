

namespace AtividadeBank
{

    internal class ContaDaEmpresa : Conta
    {
		private double limitedeempresa;

        public ContaDaEmpresa(int numeroConta, string titularConta, double saldoConta) : base(numeroConta, titularConta, saldoConta)
        {
        }

        public double LimitedeEmpresa
		{
			get { return limitedeempresa; }
            set { limitedeempresa = value; }
		}

        public void Emprestimo(double qtd)
        {
            limitedeempresa += qtd;
            SaldoConta -= qtd;
        }


	}
}
