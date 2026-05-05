

namespace Estudantes.Classes.Dados.Entidades
{
    internal class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int RA { get; set; }

        public string Curso { get; set; }   
        public Aluno()
        {
        }

        public Aluno(string nome, int rA, string curso)
        {
            Nome = nome;
            RA = rA;
            Curso = curso;
        }
        //metodo
        public void ExibirDados()
        {
            Console.WriteLine(" --Dados do aluno-- ");
            Console.WriteLine($"Nome do aluno:{Nome}");
            Console.WriteLine($"RA: {RA}");
            Console.WriteLine($"Curso matriculado : {Curso}");
        }

    }
}
