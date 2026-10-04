// String Poprawe_haslo = "tajnehasło";
// Console.WriteLine("Podaj swoje hasło: ");
// string haslo = Console.ReadLine().Trim();

// while (Poprawe_haslo != haslo)
// {
//     Console.WriteLine("Niepoprawne hasło, spróbuj ponownie: ");
//     Console.WriteLine("Podaj swoje hasło: ");
//     haslo = Console.ReadLine();

// }
// int pozycja = 0;
// Random r = new Random();

// while (pozycja < 32)
// {
//     Console.WriteLine($"Stoisz na pozycji: {pozycja}");
//     Console.WriteLine("Wciśnij Enter aby rzucić kostką");
//     Console.ReadLine();
//     int rzut = r.Next(0, 6);

//     pozycja += rzut;
//     Console.Write($"Idziesz {rzut} do przodu");

// }
// Console.WriteLine("Doszedłęś do mety");
Console.WriteLine("Podaj liczbę: ");
int n = int.Parse(Console.ReadLine());
for (int i = 2; i < n; i += 2)
{
    Console.WriteLine(i);
}





