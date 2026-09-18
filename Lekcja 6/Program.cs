using System.Collections.Concurrent;
using System.Linq;

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
        // string haslo = ("ABRAKADABRA");
        // Console.WriteLine("Podaj Hasło");
        // string wpiszhaslo = Console.ReadLine().Trim();
        // if (haslo == wpiszhaslo)
        // {
        //     Console.WriteLine("Zostałeś Poprawnie zalogowany");

        // }
        // else
        // {
        //     Console.WriteLine("Hasło jest Niepoprawne. Spróbuj Ponownie.");
        // Console.WriteLine("Podaj ocenę z matematyki:");
        // double matematyka = double.Parse(Console.ReadLine());

        // Console.WriteLine("Podaj ocenę z fizyki:");
        // double fizyka = double.Parse(Console.ReadLine());

        // Console.WriteLine("Podaj ocenę z chemii:");
        // double chemia = double.Parse(Console.ReadLine());
        // Console.WriteLine("Podaj swoją frekwencję w procentach:");
        // double frekwencja = double.Parse(Console.ReadLine());
        // double srednia = (matematyka + fizyka + chemia) / 3;

        // Console.WriteLine($"Twoja średnia końcowa wynosi: {srednia:F2}");

        // bool czerwonypasek = srednia >= 5.0 && frekwencja >= 70;
        // string komunikat = czerwonypasek
        //     ? "Gratulacje! Twoja średnia jest wystarczająca do uzyskania czerwonego paska."
        //     : "Niestety, Twoja średnia jest za niska do uzyskania czerwonego paska.";

        // Console.WriteLine(komunikat);
        // Console.ReadKey();
        // string poprawnehaslo = "12345678@!Mn";
        // Console.WriteLine("Podaj Hasło:");
        // string haslo = Console.ReadLine();


        // if (haslo == poprawnehaslo)
        // {
        //     Console.WriteLine("Zostałeś poprawnie zalogowany do password security checker.");

        //     bool dlugosc = haslo.Length >= 8;
        //     bool wielkaLitera = haslo.Any(char.IsUpper);
        //     bool malaLitera = haslo.Any(char.IsLower);
        //     bool cyfra = haslo.Any(char.IsDigit);
        //     bool znakSpecjalny = haslo.Any(ch => !char.IsLetterOrDigit(ch));

        //     Console.WriteLine("Czy Hasło jest bezpieczne");

        //     if (dlugosc)
        //         Console.WriteLine("Jest dobrze. Hasło ma co najmniej 8 znaków");
        //     else
        //         Console.WriteLine("Jest źle. Hasło ma mniej Niż 8 znaków");
        //     if (wielkaLitera)
        //         Console.WriteLine("Jest dobrze. Hasło zawiera wielką literę");
        //     else
        //         Console.WriteLine("Jest źle. Brak wielkiej litery");
        //     if (znakSpecjalny)
        //         Console.WriteLine("Jest dobrze. Hasło zawiera znak specjalny");
        //     else
        //         Console.WriteLine("Jest źle. Brak znaku specjalnego");
        //     if (malaLitera)
        //         Console.WriteLine("Jest dobrze. Hasło zawiera małą literę");
        //     else
        //         Console.WriteLine("Jest źle. Brak małej litery");
        //     if (cyfra)
        //         Console.WriteLine("Jest dobrze. Hasło zawiera cyfrę");
        //     else
        //         Console.WriteLine("Jest źle. Brak cyfry");

        // }
        // else
        // {
        //     bool dlugosc = haslo.Length >= 8;
        //     bool wielkaLitera = haslo.Any(char.IsUpper);
        //     bool malaLitera = haslo.Any(char.IsLower);
        //     bool cyfra = haslo.Any(char.IsDigit);
        //     bool znakSpecjalny = haslo.Any(ch => !char.IsLetterOrDigit(ch));

        //     Console.WriteLine("Czy Hasło jest bezpieczne");

        //     if (dlugosc)
        //         Console.WriteLine("Jest dobrze. Hasło ma co najmniej 8 znaków");
        //     else
        //         Console.WriteLine("Jest źle. Hasło ma mniej Niż 8 znaków");
        //     if (wielkaLitera)
        //         Console.WriteLine("Jest dobrze. Hasło zawiera wielką literę");
        //     else
        //         Console.WriteLine("Jest źle. Brak wielkiej litery");
        //     if (znakSpecjalny)
        //         Console.WriteLine("Jest dobrze. Hasło zawiera znak specjalny");
        //     else
        //         Console.WriteLine("Jest źle. Brak znaku specjalnego");
        //     if (malaLitera)
        //         Console.WriteLine("Jest dobrze. Hasło zawiera małą literę");
        //     else
        //         Console.WriteLine("Jest źle. Brak małej litery");
        //     if (cyfra)
        //         Console.WriteLine("Jest dobrze. Hasło zawiera cyfrę");
        //     else
        //         Console.WriteLine("Jest źle. Brak cyfry");
    }


}




