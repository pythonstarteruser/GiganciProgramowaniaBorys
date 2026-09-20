namespace Lekcja_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Powiedzonko");
        Console.WriteLine("2. Informacja dnia");
        Console.WriteLine("3. ASCII-art");
        Console.WriteLine("4. Ciekawy fakt");

        string wybor = (Console.ReadLine());

        // if (wybor == 1)
        // {
        //     Console.WriteLine("Dobra robota, młody programisto!");
        // }
        // else if (wybor == 2)
        // {
        //     Console.WriteLine("Dziś jest świetny dzień na naukę C#!");
        // }
        // else if (wybor == 3)
        // {
        //     Console.WriteLine("(^_^)");
        // }
        // else if (wybor == 4)
        // {
        //     Console.WriteLine("Fakt: komputery KOCHAJĄ instrukcje warunkowe!");
        // }
        // else
        // {
        //     Console.WriteLine("Błędny wybór");
        // }

        switch (wybor)
        {
            case "jeden":
                Console.WriteLine("Dobra robota, młody programisto!");
                break;
            case "dwa":
                Console.WriteLine("Dziś jest świetny dzień na naukę C#!");
                break;
            case "trzy":
                Console.WriteLine("(^_^)");
                break;
            case "cztery":
                Console.WriteLine("Fakt: komputery KOCHAJĄ instrukcje warunkowe!");
                break;
            default:
                Console.WriteLine("Błędny wybór");
                break;
        }
    }
}
