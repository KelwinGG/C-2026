 using static System.Console;

 using System; // Biblioteca principal do C#

class Program
{
    static void Main()
    {
        // ================================
        // DECLARAÇÃO DE VARIÁVEIS
        // ================================
        
        int totalTuristas = 0; // Armazena o total atual de turistas no parque
        string opcao;          // Armazena a opção digitada (entrada/saida/sair)

        // ================================
        // TÍTULO DO SISTEMA
        // ================================

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo de controle de fluxo carros");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parque Nacional os Lençóis Maranhenses\n");
        Console.ResetColor();

        Console.WriteLine("Bem-vindo ao aplicativo de controle de fluxo de carros!");

        // ================================
        // LOOP PRINCIPAL DO SISTEMA
        // ================================

        while (true) // Loop infinito até o usuário digitar "sair"
        {
            Console.WriteLine("\nDigite o fluxo de carro (entrada/saida)");
            Console.Write("ou sair para encerrar a aplicação: ");
            
            opcao = Console.ReadLine().ToLower(); // Converte para minúsculo

            // ================================
            // OPÇÃO SAIR
            // ================================

            if (opcao == "sair")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSaindo do aplicativo...");
                Console.ResetColor();
                break; // Encerra o loop
            }

            // ================================
            // VALIDAÇÃO DE ENTRADA
            // ================================

            if (opcao != "entrada" && opcao != "saida")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Por favor, digite 'entrada' ou 'saida'.");
                Console.ResetColor();
                continue; // Volta para o início do loop
            }

            // ================================
            // SOLICITA NÚMERO DE TURISTAS
            // ================================

            Console.Write("Digite o número de turistas: ");
            int numeroTuristas;

            // Valida se o usuário digitou número válido
            if (!int.TryParse(Console.ReadLine(), out numeroTuristas) || numeroTuristas < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número inválido!");
                Console.ResetColor();
                continue;
            }

            // ================================
            // PROCESSAMENTO ENTRADA
            // ================================

            if (opcao == "entrada")
            {
                totalTuristas += numeroTuristas; // Soma ao total

                Console.WriteLine($"\nEntrada registrada em: {DateTime.Now}");
                Console.WriteLine($"Entrada de {numeroTuristas} turistas registrada.");
            }
            else // PROCESSAMENTO SAÍDA
            {
                // Evita que o total fique negativo
                if (numeroTuristas > totalTuristas)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Não há turistas suficientes no parque para essa saída.");
                    Console.ResetColor();
                    continue;
                }

                totalTuristas -= numeroTuristas; // Subtrai do total

                Console.WriteLine($"\nSaída registrada em: {DateTime.Now}");
                Console.WriteLine($"Saída de {numeroTuristas} turistas registrada.");
            }

            // ================================
            // EXIBE TOTAL ATUAL
            // ================================

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total de turistas no parque: {totalTuristas}");
            Console.ResetColor();
        }

        // ================================
        // FINALIZAÇÃO
        // ================================

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo encerrado.");
        Console.ResetColor();
    }
}