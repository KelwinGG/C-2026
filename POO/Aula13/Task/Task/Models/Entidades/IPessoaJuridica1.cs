namespace Task.Models.Entidades
{
    internal interface IPessoaJuridica1
    {
        int Funcionarios { get; set; }

        double FuncionariosTT(int Pessoas, double Renda);
        double Imposto();
    }
}