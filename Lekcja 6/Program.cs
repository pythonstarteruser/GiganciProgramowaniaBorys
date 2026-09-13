namespace Lekcja_6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());
        if (liczba > 5)
        {
            Console.WriteLine("Liczba jest większa niż 5");
        }
        else if (liczba == 5)
        {
            Console.WriteLine("Liczba jest równa 5");
        }
        else
        {
            Console.WriteLine("Liczba jest mniejsza");
        }
    }
}
