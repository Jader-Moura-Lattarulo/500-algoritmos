namespace CSharp.algoritmo004;

public class Algoritmo004
{
    public static void Executar()
    {
        Console.WriteLine("Vejo a previsão do tempo");
        Console.Write("Está sol? (s/n): ");
        string? estaSol = Console.ReadLine();

        if (estaSol?.ToLower() == "s")
        {
            Console.WriteLine("Vou à praia");
        } else if ( estaSol?.ToLower() == "n")
        {
            Console.WriteLine("Vou estudar");
        }

        Console.WriteLine("Almoçar");
        Console.WriteLine("Ver televisão");
        Console.WriteLine("Dormir");
    }
}