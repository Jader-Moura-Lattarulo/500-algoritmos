namespace CSharp.algoritmo007;

public class Algoritmo007
{
    public static void Executar()
    {
        Console.WriteLine("Ler a prova.");
        Console.Write("Quantas questões tem na prova? ");

        int numeroDeQuestoes = int.Parse(Console.ReadLine()!);
        int contadorDeQuestoes = 1;
        int tempoParaProva = 60;

        while (numeroDeQuestoes > 0 && tempoParaProva > 0)
        {
            Console.Write($"Você sabe responder a {contadorDeQuestoes}ª questão? (s/n): ");
            String? resposta = Console.ReadLine();

            if (resposta?.ToLower() == "s")
            {
                Console.WriteLine($"Questão: {contadorDeQuestoes} respondida");
                tempoParaProva -= 3;
            } else
            {
                Console.WriteLine($"Você pulou a questão: {contadorDeQuestoes}");
                tempoParaProva -= 1;
            }

            contadorDeQuestoes++;
            numeroDeQuestoes--;
        }

        if (tempoParaProva <= 0)
        {
            Console.WriteLine("O tempo acabou.");
            Console.WriteLine("Entregar a prova.");
        }
        else if (numeroDeQuestoes <= 0)
        {
            Console.WriteLine("Você terminou a prova.");
            Console.WriteLine("Entregar a prova.");
        }
    }
}

