 using static System.Console;

//Declaração de variavel 
int numero;
//entrada de dados 
numero = int.Parse(ReadLine());
//processamento de dados 
for (int i = 0; i<999999999999999; i++)
{
    System.Console.WriteLine($"{numero}X{i+1} = {numero * (i+1)}");
}
