namespace CSharp.algoritmo003;

public class Algoritmo003
{
    public static void Executar()
    {
        Console.Write("A lâmpada está fora de alcance? (s/n): ");
        string? foraDeAlcance = Console.ReadLine();

        if (foraDeAlcance?.ToLower() == "s")
        {
            Console.WriteLine("Pegar a escada.");
        }

        Console.WriteLine("Pegar a lâmpada.");

        Console.WriteLine("A lâmpada está quente? (s/n): ");
        string? quente = Console.ReadLine();

        if (quente?.ToLower() == "s")
        {
            Console.WriteLine("Pegar pano.");
        }

        Console.WriteLine("Tirar lâmpada queimada.");
        Console.WriteLine("Colocar lâmpada boa.");
    }
}