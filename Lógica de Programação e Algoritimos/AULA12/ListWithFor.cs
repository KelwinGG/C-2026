 using static System.Console;


 //declaração de variaveis 
 int n; 
 List<double> numeros = new List <double>();
 // entrada de dados 
 System.Console.WriteLine("Quantos numeros voçê vai digitar: ");
 n = int.Parse(ReadLine());

 for (int i = 0; i < n ; i++)
{
    Write("Digite um numero: ");
    numeros.Add(double.Parse(ReadLine()));

}
    Write("Valore : ");

for ( int i = 0; i < n; i++)
{
    Write($" {numeros[i]}");
}

System.Console.WriteLine($"Soma = {numeros.Sum()}");
System.Console.WriteLine($"Media = {numeros.Average()}");