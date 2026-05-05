namespace Task.Models.Entidades
{
    internal class PessoaFisica : Contribuinte
    {
        private double gastosSaude;

        public double GastosSaude
        {
            get { return gastosSaude; }
            set { gastosSaude = value < 0 ? 0 : value; }
        }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
            : base(nome, rendaAnual)
        {
            this.gastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            double imposto;

            if (RendaAnual < 20000.0)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }

            imposto -= GastosSaude * 0.5;

            return imposto;
        }
    }
}
