int[] numeros = new int[100];

for (int i = 0; i < numeros.Length; i++)
{
    if (i + 1 != 72)
    {
        numeros[i] = i + 1;
    }
}

int total = NumeroMaximó(numeros.Length);

for (int i = 0; i < numeros.Length; i++ )
{
    total -= numeros[i];
}

Console.WriteLine("El número faltante es: " + total);

static int NumeroMaximó(int num)
{
    return (num * (num + 1)) / 2;
}