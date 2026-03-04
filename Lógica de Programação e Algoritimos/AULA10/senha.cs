 using static System.Console;
 // declaração de variaveis 
 const int SENHAFIXA = 2002;
 int senha, contagem = 0 ;
 //entrada de dados 
 System.Console.WriteLine("Digite a senha: ");
 senha = int.Parse (ReadLine());
 //processamento de dados 
 while (senha != SENHAFIXA)
{
   
    contagem++;
    System.Console.WriteLine("Senha incorreta, digite novamente: ");
    senha = int.Parse(ReadLine());
    Beep ( 1500 , 500);
    
}

System.Console.WriteLine("Acesso permitito !");
