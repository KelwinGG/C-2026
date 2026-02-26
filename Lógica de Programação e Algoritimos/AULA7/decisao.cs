
 using static System.Console;
 double resultado = 10 ;
//entrada de dados 
System.Console.WriteLine("Digite um número para ser dividido por 2 :");
double entrada = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite um numero para dividir :");
double senai = double.Parse(Console.ReadLine());

//processamento de dados 
if ((entrada > 0 ) & (senai > 0))
{
    resultado = 2 / entrada;
}

if (entrada > 0)
{
    resultado =  2/  entrada;
}
else if (entrada == 0 )
{
    resultado = 2 - entrada;
}
else
{
    resultado = 2 + entrada;
}
//saida de dados 
System.Console.WriteLine($"O resultado é {resultado}");