

using Figuras.Classes.Enumerados;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
		private double largura;
		private double altura;

        protected double Largura
		{
			get { return largura; }
			set { largura = value; }
		}
        protected double Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		//Construtar
        public Retangulo(Cor corDaForma, double largura , double altura) : base(corDaForma)
        {
			Altura = altura;
			Largura= largura;
        }
		/// <summary>
		/// Calcula a area da forma usando as dimensões atuais.
		/// </summary>
		/// <returns>O valor da area calculada com base na largura e altura do retangulo </returns>
        public override double Area()
        {
            return Largura * Altura;
        }


	}
}
