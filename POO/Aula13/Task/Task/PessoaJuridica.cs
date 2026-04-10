

using Task.Models;

namespace Task
{
    internal class PessoaJuridica : Contribuinte 
    {
		private int funcionarios;

        

        public int Funcionarios
		{
			get { return funcionarios; }
			set { funcionarios = value; }
		}

        public static int FuncionariosT (int Pessoas)
        {

            if (Pessoas <= 10 )
            {
                int descontop = FuncionariosT * 0.15;
                int valorfinal = FuncionariosT - descontop;
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
