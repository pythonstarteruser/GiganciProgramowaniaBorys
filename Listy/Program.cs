namespace Listy;

class Program
{
    static void Main(string[] args)
    {
        // List<string> inventory = new List<string>();
        // inventory.Add("Laptop");
        // inventory.Add("Klawiatura");

        // foreach (var item in inventory)
        // {
        //     Console.WriteLine(item);
        // }
        string[] items = { "Hi-Fi", "Router", "Monitor", "Laptop" };
        List<string> inventory = new List<string>();
        AddItem(inventory, items, 2);
        PrintList("Ekwipunek Gracza", inventory);

    }
    static void AddItem(List<string> inventory, string[] items, int index)
    {
        if (index < 0 || index >= items.Length)
        {
            Console.WriteLine("Nieprawidłowy indeks przedmiotu!");
            return;
        }


        string item = items[index];
        inventory.Add(item);
        Console.WriteLine($"Dodano do ekwipunku: {item}");
    }
    static void PrintList(string header, List<string> list)
    {
        Console.WriteLine("\n=== " + header + " ===");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
