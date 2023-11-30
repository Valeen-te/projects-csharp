Console.WriteLine("C# Programa para MCD y MCM");

Console.Write("Dame el primer número: ");

int primero = int.Parse(Console.ReadLine());

Console.Write("Dame el segundo número: ");

int segundo = int.Parse(Console.ReadLine());

int mcd = CalcularMcd(primero, segundo);

int mcm = CalcualrMcm(primero, segundo);

Console.WriteLine($"\nEl MCD entre {primero} y {segundo} es: {mcd}");
Console.WriteLine($"El MCM entre {primero} y {segundo} es: {mcm}");


static int CalcularMcd(int primero, int segundo)
{
    if (primero > segundo)
        primero = primero % segundo;
    else
        segundo = segundo % primero;

    if (segundo == 0)
    {
        return primero;
    }
    else if (primero == 0)
    {
        return segundo;
    }
    else 
    { 
        return CalcularMcd(primero,segundo);
    }
}

static int CalcualrMcm(int primero, int segundo)
{
    return (primero * segundo) / CalcularMcd(primero, segundo);
}