using System.Reflection;

namespace CSharp.services;

public static class AlgoritmoManager
{
    public static int ObterMaiorAlgoritmo()
    {
        string diretorio = ObterDiretorioProjeto();

        var algoritmos = Directory
        .GetDirectories(diretorio, "algoritmo*")
        .Select(Path.GetFileName)
        .Where(nome =>
            int.TryParse(
                nome!.Replace("algoritmo", ""),
                out _
            )
        ).Select(nome =>
            int.Parse(
            nome!.Replace("algoritmo", "")
            )
        )
        .ToList();
        return algoritmos.Count > 0 ? algoritmos.Max() : 0;
    }

    public static void Executar(int numeroAlgoritmo)
    {
        string nomeClasse = $"Algoritmo{numeroAlgoritmo:D3}";

        var tipo = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(tipo => tipo.Name == nomeClasse);

        if (tipo == null)
        {
            Console.WriteLine(
                "O algoritmo existe, mas sua implementação não foi encontrada."
            );

            return;
        }

        var metodo = tipo.GetMethod("Executar");

        if (metodo == null)
        {
            Console.WriteLine(
                "O algoritmo não possui um método Executar()."
            );

            return;
        }

        metodo.Invoke(null, null);
    }

    private static string ObterDiretorioProjeto()
    {
        DirectoryInfo? diretorio = new DirectoryInfo(
            AppContext.BaseDirectory
        );

        while (diretorio != null)
        {
            string arquivoProjeto = Path.Combine(
                diretorio.FullName,
                "CSharp.csproj"
            );

            if (File.Exists(arquivoProjeto))
            {
                return diretorio.FullName;
            }

            diretorio = diretorio.Parent;
        }

        throw new DirectoryNotFoundException(
            "Não foi possível encontrar a raiz do projeto C#."
        );
    }
}