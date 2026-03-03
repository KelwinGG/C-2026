using static System.Console;

int npessoas, amax, amin, ps1, resultado = 0;


System.Console.Write("Digite o numero de pessoas: ");
npessoas = int.Parse(ReadLine());
System.Console.Write("Digite a altura miníma (cm): ");
amin = int.Parse(ReadLine());
System.Console.Write("Digite a altura maxíma (cm): ");
amax = int.Parse(ReadLine());

for (int i = 0; i <npessoas ; i++)
{
    System.Console.Write("Digite a sua altura: ");
    ps1 = int.Parse(ReadLine());
    if (ps1 > amax)
    {
        System.Console.WriteLine("Você é muito alto ");
        resultado++;
    }
    else if (ps1 < amin)
    {
        System.Console.WriteLine("Você é muito pequeno");
        resultado++;
    }
    else
    {
        System.Console.WriteLine("Você está na altura correta");
    }
}
WriteLine($"{resultado} pessoas que estão entre {amin} e {amax} cm de altura.");