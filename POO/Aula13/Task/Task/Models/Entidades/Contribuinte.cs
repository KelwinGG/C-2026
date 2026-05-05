using Task.Models.Contracts;

namespace Task.Models.Entidades
{
    internal abstract class Contribuinte : Iimposto
    {
        // Nome precisa ser acessível de fora (ex: Program.Main), então torna-se público.
        public string Nome { get; protected set; }

        // RendaAnual permanece protegida para uso por classes derivadas.
        protected double RendaAnual { get; set; }

        // Construtor protegido para que apenas classes derivadas possam instanciar.
        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        // Assinatura do método abstrato conforme a interface Iimposto.
        public abstract double Imposto();
    }
}
