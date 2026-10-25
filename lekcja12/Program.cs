namespace lekcja12;

class Program
{
    static void CharacterInfo(string nick, int currentHp, int maxHp, string doswiadczenie, int levelDoswiadczenia, int inteligencja)
    {
        Console.WriteLine("Karta Postaci");
        Console.WriteLine($"Nick: {nick}");
        Console.WriteLine($"Życie: {currentHp} / {maxHp}");
        Console.WriteLine($"Doświadczenie: {doswiadczenie} lvl: {levelDoswiadczenia}");
        Console.WriteLine($"Inteligencja: {inteligencja}");
    }

    static void Main(string[] args)
    {
        string nick = "TechnologyGuy";
        int maxHp = 100;
        int currentHp = 100;
        string doswiadczenie = "Programowanie";
        int levelDoswiadczenia = 10;
        int inteligencja = 130;

        CharacterInfo(nick, currentHp, maxHp, doswiadczenie, levelDoswiadczenia, inteligencja);
    }
}
