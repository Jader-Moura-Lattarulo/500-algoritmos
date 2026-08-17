using CSharp.services;


while (true)
{
    int maiorAlgoritmo = AlgoritmoManager.ObterMaiorAlgoritmo();

    Console.Write(
        $"Qual algoritmo você deseja executar? (000 até {maiorAlgoritmo:D3}): "
    );

    string? entrada = Console.ReadLine();

    if (entrada?.ToLower() == "sair")
    {
        Console.WriteLine("Encerrando...");
        break;
    }

    if (!int.TryParse(entrada, out int numeroAlgoritmo))
    {
        Console.WriteLine("Entrada inválida");
        Console.WriteLine();
        continue;
    }

    if (numeroAlgoritmo < 0 || numeroAlgoritmo > maiorAlgoritmo)
    {
        Console.WriteLine(
            $"Não temos esse algoritmo. Escolha de 000 até {maiorAlgoritmo:D3} ou digite \"sair\" para sair."
        );
        Console.WriteLine();
        continue;
    }

    AlgoritmoManager.Executar(numeroAlgoritmo);

    Console.WriteLine();
}