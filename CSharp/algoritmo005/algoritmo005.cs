namespace CSharp.algoritmo005;

public class Algoritmo005
{
    public static void Executar()
    {
        Console.WriteLine("Pegar os ingredientes");
        Console.Write("Está de roupa branca? (s/n): ");
        string? roupaBranca = Console.ReadLine();

        if (roupaBranca?.ToLower() == "s")
        {
            Console.WriteLine("Colocar avental");            
        }

        Console.Write("Tem batedeira? (s/n): ");
        string? temBatedeira = Console.ReadLine();

        if (temBatedeira?.ToLower() == "s")
        {
            Console.WriteLine("Bater os ingredientes na batedeira");
        } else
        {
            Console.WriteLine("Bater os ingredientes à mão");
        }

        Console.WriteLine("Colocar a massa na forma");
        Console.WriteLine("Colocar a forma no forno");
        Console.WriteLine("Aguardar o tempo necessário");
        Console.WriteLine("Retirar o bolo");
    }
}