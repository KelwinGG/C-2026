
namespace Atividade3
{
    internal class Aluno
    {
        public string NomeDoAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Resultado;
        public double NotaFinal()
        {
            return Resultado = Nota1 + Nota2 + Nota3  ;
        }

        public void AprovadoOuReprovado()
        {
            if (Resultado < 60) 
            {
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
        
    }
}
