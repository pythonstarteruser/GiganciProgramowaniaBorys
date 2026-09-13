namespace Lekcja_6;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Podaj liczbę: ");
        // int liczba = int.Parse(Console.ReadLine());
        // if (liczba > 5)
        // {
        //     Console.WriteLine("Liczba jest większa niż 5");
        // }
        // else if (liczba == 5)
        // {
        //     Console.WriteLine("Liczba jest równa 5");
        // }
        // else
        // {
        //     Console.WriteLine("Liczba jest mniejsza niż 5");
        string haslo = ("ABRAKADABRA");
        Console.WriteLine("Podaj Hasło");
        string wpiszhaslo = Console.ReadLine();
        if (haslo == wpiszhaslo)
        {
            Console.WriteLine("Zostałeś Poprawnie zalogowany");
        
        }
        else
        {
            Console.WriteLine("Hasło jest Niepoprawne. Spróbuj Ponownie.");
        }

        }
    }

