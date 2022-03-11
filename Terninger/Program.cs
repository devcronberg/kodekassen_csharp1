Console.WriteLine("10 tilfældige terninger");
Console.WriteLine("-----------------------");

// Tilfældighedsgenerator
Random rnd = new Random();

// Tæl til 10
for (int i = 0; i < 10; i++)
{
    // tilfældigt tal mellem 1-6
    int værdi = rnd.Next(1, 7);
    // Tekst til at skrive ud
    string txt = $"[ {værdi} ]";
    // Udskriv
    Console.WriteLine(txt);
}
