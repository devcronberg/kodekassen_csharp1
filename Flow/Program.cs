// Erklær variabel
int t = 1;

// Løkke indtil t = 10
while (t <= 10)
{
    // Hvis t <= 5 så skriv med rødt
    if (t <= 5)
    {
        Console.ForegroundColor = System.ConsoleColor.Red;
    }
    else
    {
        // Ellers grå
        Console.ForegroundColor = System.ConsoleColor.Gray;
    }
    // Udskriv
    Console.WriteLine(t);

    // Læg 1 til t
    t++;
}

