namespace CSharp.algoritmo006;

public class Algoritmo006
{
    public static void Executar()
    {
        Console.WriteLine("Pegar faca, bacia e batatas.");
        Console.WriteLine("Colocar água na bacia.");

        Console.Write("Quantas batatas você tem? ");
        int qtdBatatas = int.Parse(Console.ReadLine()!);
        int todasBatatas = qtdBatatas;
        int batataDescascando = 1;

        while (qtdBatatas > 0)
        {
            Console.WriteLine($"Descascando a {batataDescascando}ª batata.");
            qtdBatatas--;
            batataDescascando++;
        }
        batataDescascando--;

        Console.WriteLine($"Todas as {todasBatatas} foram descascadas");
    }
}