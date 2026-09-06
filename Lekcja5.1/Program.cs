namespace Lekcja_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj ocenę z matematyki:");
        double matematyka = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj ocenę z fizyki:");
        double fizyka = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj ocenę z chemii:");
        double chemia = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj swoją frekwencję w procentach:");
        double frekwencja = double.Parse(Console.ReadLine());
        double srednia = (matematyka + fizyka + chemia) / 3;

        Console.WriteLine($"Twoja średnia końcowa wynosi: {srednia:F2}");

        bool stypendium = srednia >= 4.5 && frekwencja >= 80;
        string komunikat = stypendium
            ? "Gratulacje! Twoja średnia jest wystarczająca do uzyskania stypendium."
            : "Niestety, Twoja średnia jest za niska do uzyskania stypendium.";

        Console.WriteLine(komunikat);
    }
}