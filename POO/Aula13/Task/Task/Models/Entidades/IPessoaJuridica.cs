namespace Task.Models.Entidades
{
    internal interface IPessoaJuridica
    {
        double FuncionariosTT(int Pessoas, double Renda);
        double Imposto();
    }
}