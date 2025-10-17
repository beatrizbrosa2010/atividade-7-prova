class Program
{
    static void Main()
    {
        Console.Write("Número inicial: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Número final: ");
        int fim = int.Parse(Console.ReadLine());

        for (int i = inicio; i <= fim; i++)
        {
            Console.WriteLine($"\nTabuada do {i}:");
            for (int j = 1; j <= 10; j++)
                Console.WriteLine($"{i} x {j} = {i * j}");
        }
    }
}
