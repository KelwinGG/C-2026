


namespace terreno;

internal class Terreno
{
    //campo 
    public double largura, comprimento, valor;


    //metodo 
    public double Area()
    {
        return largura * comprimento;

    }

    public double Preco()
    {
        return Area() * valor;
    }


    public void Saida()
    {
        Console.WriteLine($"A area do terreno é:  {Area()}");
        Console.WriteLine($"O preço do terreno é: R${Preco()}");
    }
}