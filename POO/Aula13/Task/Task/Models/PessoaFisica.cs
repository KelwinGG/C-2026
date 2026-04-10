

namespace Task.Models
{
    internal class PessoaFisica : Contribuinte
    {
		private double gastosaude;

		public double GastoSaude
		{
			get { return gastosaude; }
			set { gastosaude = -0.5 ; }
		}
		public static double CauculoImposto (double Renda, double imp)
		{
			
			if (Renda <= 20000)
			{
				double desconto = Renda * 0.15;
				double valorfinal = Renda - desconto;
				return valorfinal;
				
			}

			else
			{
                double desconto1 = Renda * 0.25;
                double valorfinal1 = Renda - desconto1;
				return valorfinal1;
            }
		}
	}
}
