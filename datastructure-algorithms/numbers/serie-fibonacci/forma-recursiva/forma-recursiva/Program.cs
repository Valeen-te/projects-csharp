Console.Write("Ingresa la longitud de la serie Fibonacci: ");

int Longitud = int.Parse(Console.ReadLine());

Console.WriteLine("\nLa longitud de la serie Fibonacci es: ");

for (int i = 0; i < Longitud; i++)
{
    Console.Write(CalcularFibacci(7) + " ");
}

static int CalcularFibacci(int longitud)
{
    if (longitud < 2)
    {
        Console.Write(longitud);
        return longitud;
    }
    else
    {
        return CalcularFibacci(longitud - 1) + CalcularFibacci(longitud - 2);
    }
}