

namespace AtividadeBank
{
    internal class Conta
    {
		private int numero;
        private string titular;
        private double saldo;
		private int taxadejuros;


		public int JurosConta
		{
			get { return taxadejuros; }
			set { taxadejuros = 5; }

		}




		public  int NumeroConta
		{
			get { return numero; }
			set { numero = value; }
		}
		

		public string TitularConta
		{
			get { return titular; }
			set { titular = value; }
		}

		

		public double SaldoConta
		{
			get { return saldo; }
			set { saldo = value; }
		}

		
        public Conta(int numeroConta, string titularConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }
		public void Saque(double quantia)
		{
			SaldoConta = quantia - taxadejuros;
		}
		public void Deposito(double quantia)
		{
			SaldoConta += quantia;
		}
    }
}
