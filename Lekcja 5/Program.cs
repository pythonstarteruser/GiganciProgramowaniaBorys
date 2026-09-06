namespace Lekcja_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj Swoje Imię:");
        string imie = Console.ReadLine();
        Console.WriteLine("$ Cześć {imie}!");
        Console.WriteLine("Jak się dziś czujesz w skali od 0 do 100");
        int samopoczucie = int.Parse(Console.ReadLine());
    }
}
