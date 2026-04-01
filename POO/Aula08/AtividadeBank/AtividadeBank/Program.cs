using AtividadeBank;
using static System.Console;


Console.WriteLine("Escolha qual conta deseja abrir: \n " +
    "\t1 - Conta Comum" +
    "\t2 - Conta Poupança" +
    "\t3 - Conta Empresa");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1 :
        Conta conta;
        Console.WriteLine("Digite o titular da conta: ");
        string titular = Console.ReadLine();
        Console.WriteLine("Digite o numero da conta: ");
        int numero  = int.Parse(Console.ReadLine());
        Console.WriteLine("Deseja fazer deposito inicial (s/n) ");
        char escolha = char .Parse(Console.ReadLine().ToLower());
        if (escolha == 's')
        {
            Console.WriteLine("Digite o deposito inicial: ");
            double deposito = double.Parse(ReadLine());
            conta = new Conta(numero, titular, deposito);
        }
        else
        {
            conta = new Conta (numero, titular);
        }
        break;

}
