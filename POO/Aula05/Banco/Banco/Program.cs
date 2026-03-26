using Banco;
using static System.Console;
using static System.Globalization.CultureNotFoundException;
using static System.ConsoleColor;
using System.Drawing;


ForegroundColor = White;
Title = "Abertura de conta";
Title = "Coin Base";
ResetColor();
BackgroundColor = Blue;

ContaBancaria conta;

Console.WriteLine("Abertura de conta - Nika Investment");
Write("Entre com um número de conta: ");
int numero = int.Parse(ReadLine());
Write("Entre com o nome do titular: ");
string nome = ReadLine();
Console.WriteLine("Deseja começar com um deposito inicial? (s/n) ");
char resposta = char.Parse(ReadLine().ToLower());


if (resposta == 's')
{
    Write("Entre com o valor de depósito inicial: R$ ");
    double deposito = double.Parse(ReadLine());
     conta = new ContaBancaria(numero,nome,deposito);
}
else
{
     conta = new ContaBancaria (numero, nome);
}

conta.Dados();

Console.WriteLine("Entre com um valor para depósito: R$");
double quantia = double.Parse(ReadLine());
conta.Deposito(quantia);
conta.Dados();
Console.WriteLine("Entre com um valor para saque: R$ ");
quantia = double.Parse(ReadLine());
conta.Saque(quantia);
conta.Dados();

ReadKey();


















































for (int i =0; i< 10000;  i++)
{
    Beep(800, 500);
}