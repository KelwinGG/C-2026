using static System.Console;
try{
    
    System.Console.WriteLine("Digite o primeiro valor: ");
    int a = int.Parse(ReadLine());
    System.Console.WriteLine("Digite o segundo valor:");
    int b = int.Parse(ReadLine());
    System.Console.WriteLine("Digite o terceiro valor: ");
    int c = int.Parse(ReadLine()) ;

    //numero 1 
    bool resultadoa = a == c ;
    System.Console.WriteLine($"O primeiro valor é igual ao terceiro valor ?{resultadoa} ");
    //numero 2 
    bool resultadob = b != a;
    System.Console.WriteLine($"O segundo valor é diferente do primeiro valor ?{resultadob} ");
    //numero 3 
    bool resultadoc = b>c;
    System.Console.WriteLine($"O segundo valor é maior que o terceiro valor ?{resultadoc} ");
    //numero 4 
    bool resultadoe = a <= c ;
    System.Console.WriteLine($"O primeiro valor é menor ou igual ao terceiro valor? {resultadoe}");
    

    // segunda etapa 
    bool etapaa = resultadoa & resultadoc;
    System.Console.WriteLine($"Se a primeira pergunta e a pergunta 3 são verdadeiros? {etapaa} ");
    bool etapab = resultadob | resultadoe;
    System.Console.WriteLine($"Entre a segunda pergunta é a quarta pergunta pelo menos ums é verdadeira? {etapab}");
    bool etapac = !resultadoa;
    System.Console.WriteLine($"Se a negação da primeira pergunta é verdadeira {etapac}");

}
catch (Exception)
{
    System.Console.WriteLine("Para de ser bot e coloca o um numero e seja um pit monster  ");
}