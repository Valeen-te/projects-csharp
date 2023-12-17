int[] Numeros = { 55, 46, 78, 89, 33, 25, 12, 5, 38 };

Console.WriteLine("Array números desordenados: ");

foreach(int i in Numeros)
{
    Console.Write(i + " ");
}

for (int i = 0; i < Numeros.Length; i++)
{
    int min = i;

    for (int j = i + 1;  j < Numeros.Length; j++)
    {
        if (Numeros[min] > Numeros[j])
        {
            min = j;
        }
    }
    int temp = Numeros[i];
    Numeros[i] = Numeros[min];
    Numeros[min] = temp;
}

Console.WriteLine("\nArray números ordenados: ");

foreach (int i in Numeros)
{
    Console.Write(i + " ");
}