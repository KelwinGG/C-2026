 using static System.Console;


 Dictionary<string, string > pessoas = new Dictionary<string, string>()
 
{
    {"Maria", "564.454.456-44" },
    {"João", "324.567.890-12" },
    {"Pedro", "456.789.012-34" }

};

 pessoas.Add ("Clodoaldo" , "543.210.987-65" );
Console.WriteLine(pessoas["Clodoaldo"]);
System.Console.WriteLine($"Tamanho = {pessoas.Count()}");
Console.WriteLine(pessoas["Maria"]);
System.Console.WriteLine($"Tamanho = {pessoas.Count()}");
Console.WriteLine(pessoas["João"]);
System.Console.WriteLine($"Tamanho = {pessoas.Count()}");
Console.WriteLine(pessoas["Pedro"]);
System.Console.WriteLine($"Tamanho = {pessoas.Count()}");

