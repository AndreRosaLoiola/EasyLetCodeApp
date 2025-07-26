namespace TwoSumApp;

public static class UserInterface
{
    public static void ShowWelcomeMessage()
    {
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("|               Olá, recrutador!                      |");
        Console.WriteLine("|                                                     |");
        Console.WriteLine("|  Esta é a minha solução orientada a objetos         |");
        Console.WriteLine("|  para o desafio Two Sum.                            |");
        Console.WriteLine("|_____________________________________________________|");
    }

    public static int[] ReadNumbers()
    {
        Console.Write("Digite os números separados por vírgula (ex: 2,7,11,15): ");
        string input = Console.ReadLine();
        return input.Split(',').Select(int.Parse).ToArray();
    }

    public static int ReadTarget()
    {
        Console.Write("Digite o valor alvo (target): ");
        return int.Parse(Console.ReadLine());
    }

    public static void ShowResult(int[] indices, int[] numbers, int target)
    {
        Console.WriteLine($"Índices encontrados: [{indices[0]}, {indices[1]}]");
        Console.WriteLine($"Justificativa: {numbers[indices[0]]} + {numbers[indices[1]]} = {target}");
    }

    public static void ShowError(string message)
    {
        Console.WriteLine($"Erro: {message}");
    }

    public static void WaitBeforeExit()
    {
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
