using static System.Console;
using static System.Linq.Enumerable;
try {
int n;
System.Console.WriteLine("Quantos números voçê vai digitar? ");
n = int.Parse(ReadLine());
if ( n < 0)
{
    System.Console.WriteLine("Valor invalido, digite somente números positivos ");
}
else if (n > 10)
{
    System.Console.WriteLine("Máximo de valores para digitar igual ou maior que 10 ");
    System.Console.WriteLine("Tente Novamente! ");
}
else
{
    int [] numeros = new int [n];
    for (int i = 0 ; i<numeros.Length ; i++)
    {
        System.Console.WriteLine($"Digite o {i + 1 }° número");
         numeros[i] = int.Parse(ReadLine());
         
    }
    System.Console.WriteLine("Números negativos: ");
    foreach (int item in Range(0, numeros.Length))
    {
        if (numeros[item] < 0)
        {
            System.Console.WriteLine(numeros[item]);
        }
    }
}
}
catch (Exception ex)
{
    System.Console.WriteLine("Digite apenas números " + ex.Message );
}