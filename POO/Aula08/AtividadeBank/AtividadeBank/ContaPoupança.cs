

namespace AtividadeBank
{
    internal class ContaPoupança : Conta
    {

        private double TaxadeJuros;

        public double taxadejuros
        {
            get { return TaxadeJuros; }
            
        }
        public void AtualizacaodeSaldo( )
        {
            Console.WriteLine($"R${SaldoConta}");
        }
        
        public override void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }

        public ContaPoupança(int numeroConta, string titularConta, double saldoConta) : base(numeroConta, titularConta, saldoConta)
        {
        }
        
    }
}
