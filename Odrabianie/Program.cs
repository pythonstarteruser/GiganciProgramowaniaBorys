// for (int i = 1; i <= 7; i++)
// {
//     int wynik = (int)Math.Pow(2, i);
//     Console.WriteLine($"2^{i} = {wynik}");
// 
// string[] gry = { "Minecraft", "Roblox", "Omori", "Project Sekai. Hatsune Miku Colorful Stage" };
// Console.WriteLine(gry[0]);
// Console.WriteLine(gry[1]);
// Console.WriteLine(gry[2]);
// Console.WriteLine(gry[3]);
int[] potegi = new int[7];
int wynik = 1;
int suma = 0;
for (int i = 0; i < potegi.Length; i++)
{
    wynik *= 2;
    potegi[i] = wynik;
    suma += wynik;
}
for (int i = 0; i < potegi.Length; i++)
{
    Console.WriteLine($"potegi[{i}] = {potegi[i]}");
}
Console.WriteLine($"Suma Wszystkich potęg wynosi: {suma}");
