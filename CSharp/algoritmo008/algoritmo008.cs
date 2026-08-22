namespace CSharp.algoritmo008;

public class Algoritmo008
{
    public static void Executar()
    {
        Console.WriteLine("Qual será a palavra do jogo? ");
        string palavra = Console.ReadLine()!.ToLower();

        int lacunasVazias = palavra.Length;
        int partesCorpo = 0;
        int maximoPartesCorpo = 6;

        Console.WriteLine();
        Console.WriteLine("Montar o diagrama do jogo.");

        while (lacunasVazias > 0 && partesCorpo < maximoPartesCorpo)
        {
            Console.Write("Digite uma letra: ");
            string letra = Console.ReadLine()!.ToLower();

            if (palavra.Contains(letra))
            {
                Console.WriteLine("Acertou uma letra!");
                lacunasVazias--;
            } 
            else
            {
                Console.WriteLine("Errou!");
                partesCorpo++;    
            }

            Console.WriteLine($"Lacunas vazias: {lacunasVazias}");
            Console.WriteLine($"Partes do corpo: {partesCorpo}/{maximoPartesCorpo}");
            Console.WriteLine();
        }

        if (lacunasVazias == 0)
        {
            Console.WriteLine("Parabéns! Você acertou a palavra.");
        }
        else
        {
            Console.WriteLine("Fim de jogo! O corpo foi completado na forca.");
        }
    }
}