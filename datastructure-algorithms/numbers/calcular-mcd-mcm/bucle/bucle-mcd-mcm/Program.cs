Console.WriteLine("C# Programa para MCD y MCM");

Console.Write("Dame el primer número: ");

int primero = int.Parse(Console.ReadLine());

Console.Write("Dame el segundo número: ");

int segundo = int.Parse(Console.ReadLine());

int mcd = ConsegirMcd(primero, segundo);

int mcm = ConsegirMcm(primero, segundo);

Console.WriteLine();
Console.WriteLine($"MCD de {primero} y {segundo}: {mcd}");
Console.WriteLine($"MCM de {primero} y {segundo}: {mcm}");


static int ConsegirMcd(int primero, int segundo)
{
    while (primero != segundo)
    {
        if (primero > segundo)
            primero -= segundo;

        if (primero < segundo)
            segundo -= primero;
    }

    return primero;
}

static int ConsegirMcm(int primero, int segundo)
{
    return (primero * segundo) / ConsegirMcd(primero, segundo);
}