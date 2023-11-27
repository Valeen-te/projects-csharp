
using System.Timers;

Console.Write("Dime el número de escaleras: ");

int nroEscaleras = int.Parse(Console.ReadLine());

int resultado = ContarFormas(nroEscaleras);

Console.WriteLine($"\nEl número de formas de subir las escaleras es: {resultado}");


//forma iterativa
static int ContarEscaleras(int n)
{

    if (n <= 3) return n;

    int a = 2;

    int b = 1;

    for (int i = 3; i <= n; i++)
    {
        int c = a;

        a = a + b;

        b = c;
    }

    return a;
}

//forma recursiva
static int ContarFormas(int n)
{
    switch (n)
    {
        case <= 3:
            return n;
        default:
            return ContarFormas(n - 1) + ContarFormas(n - 2);
    }
}