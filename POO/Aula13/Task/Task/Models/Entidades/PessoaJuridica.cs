namespace Task.Models.Entidades
{
    internal class PessoaJuridica : Contribuinte
    {
        private int funcionarios;

        public int Funcionarios
        {
            get { return funcionarios; }
            set { funcionarios = value; }
        }

        public PessoaJuridica(string nome, double rendaAnual, int funcionarios)
            : base(nome, rendaAnual)
        {
            this.funcionarios = funcionarios;
        }

        public override double Imposto()
        {
            if (Funcionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}