namespace Task.Models
{
    abstract internal class Contribuinte
    {
		private string nome;
		private double rendaanual;

		public double RendaAnual
		{
			get { return rendaanual; }
			set { rendaanual = value; }
		}


		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		 public void Imposto()
		{
			
		}
	}
}
