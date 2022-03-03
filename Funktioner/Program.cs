// Kald af metode til at tælle
Tæl(5, 3, ConsoleColor.Cyan);
Tæl(3, 2, ConsoleColor.Red);

void Tæl(int antal, int skiftFarve,
    ConsoleColor farve)
{
    int t = 0;
    // Tæl til antal
    while (t <= antal)
    {
        // Hvis t <= skiftFarve så skriv med den ønskede farve
        if (t <= skiftFarve)
        {
            Console.ForegroundColor = farve;
        }
        else
        {
            // Ellers grå
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        // Udskriv
        Console.WriteLine(t);

        // Læg 1 til t
        t++;
    }
}