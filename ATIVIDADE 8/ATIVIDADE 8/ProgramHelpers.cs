internal static class ProgramHelpers
{
    private static void Main(Console console)
    {
        string[] nomes = { "Ana", "Bruno", "Carla", "Diego", "Fernanda" };

        Console.Write("Digite um nome para pesquisar: ");
        string nomeBusca = Console.ReadLine();

        bool encontrado = false;

        foreach (string nome in nomes)
        {
            if (nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase)) ;
            {
                encontrado = true;
                break;
            }
        }
        if (encontrado)
        {
            Console.WriteLine("$ O nome {nomeBusca} foi encontrado no vetor: ");
        }
        else
        {
            Console.WriteLine("$ O nome {nomeBusca} nao esta no vetor.");
        }
    }
}