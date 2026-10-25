namespace lekcja12;

class Program
{
    static int GetPercent(int current, int max)
    {
        if (max <= 0)
        {
            return 0;
        }

        return current * 100 / max;
    }

    static void CharacterInfo(string nick, int currentHp, int maxHp, string doswiadczenie, int levelDoswiadczenia, int inteligencja, int currentMana, int maxMana)
    {
        int hpPercent = GetPercent(currentHp, maxHp);
        int manaPercent = GetPercent(currentMana, maxMana);

        Console.WriteLine("Karta Postaci");
        Console.WriteLine($"Nick: {nick}");
        Console.WriteLine($"Życie: {hpPercent}% ({currentHp} / {maxHp})");
        Console.WriteLine($"Mana: {manaPercent}% ({currentMana} / {maxMana})");
        Console.WriteLine($"Doświadczenie: {doswiadczenie}, poziom: {levelDoswiadczenia}");
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
        int maxMana = 1000;
        int currentMana = 900;

        CharacterInfo(nick, currentHp, maxHp, doswiadczenie, levelDoswiadczenia, inteligencja, currentMana, maxMana);
    }
}
