

namespace Master
{
    internal class ContaPoupanca : Conta
    {
        private double rendimento;

        public double RendimentoConta
        {
            get { return rendimento; }
            set { rendimento = value; }
        } 

        public ContaPoupanca(int numeroConta, double saldoConta, Pessoa dadosCliente, double rendimento) : base(numeroConta, saldoConta, dadosCliente)
        {
            RendimentoConta = rendimento;
        }

        public void Consulta()
        {
            Console.WriteLine($"Dados do cliente : \n " +
                $"\t Nome: {DadosCliente}\n" +
                $"\t Saldo : {SaldoConta}");
        }
    }
}
