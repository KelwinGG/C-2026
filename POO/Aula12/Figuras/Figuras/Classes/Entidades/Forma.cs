
using Figuras.Classes.Contratos;
using Figuras.Classes.Enumerados;

namespace Figuras.Classes.Entidades
{
    abstract internal class Forma : IArea
    {
        /// <summary>
        /// Cores disponiveis Vermelho,Azul,Amarelo e Rosa
        /// </summary>
        //Campo
        private Cor cor;
        

        //propriedades
        protected Cor CorDaForma
        {
            get { return cor; }
            set { cor = value; }
        }
        // 
        public Forma(Cor corDaForma)
        {
            CorDaForma = corDaForma;
        }

        //Metodo
        abstract public double Area();
        
    }
}
