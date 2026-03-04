using static System.Console;
try{
//declaração de variaveis 
int visitantes = 0, contagem = 0;
double altura_max = 0, altura_min = 0 , alturas = 0;
// entrada de dados 
System.Console.WriteLine("Digite o numero de vistantes :");
visitantes = int.Parse(ReadLine());
System.Console.WriteLine("Digite a altura maxima: ");
altura_max = double.Parse(ReadLine());
System.Console.WriteLine("Digite a altura minima: ");
altura_min = double.Parse(ReadLine());
// PROCESSAMNETO DE DADOS 
for(int i = 0 ; i<visitantes; i++)
{
    System.Console.WriteLine($"Digite a altura da pessoa n° {i+1}");
    alturas = int.Parse(ReadLine());

    if (( alturas >= altura_min) & (alturas <= altura_max))
    {
        contagem++;
        System.Console.WriteLine("Pessoa pode entrar ");
    }

}
}
catch (Exception ex)
{
    System.Console.WriteLine($"Digite um valor valido , ERRO: {ex.Message}");
}