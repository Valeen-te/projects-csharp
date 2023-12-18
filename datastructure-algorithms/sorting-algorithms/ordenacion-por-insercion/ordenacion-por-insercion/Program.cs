int[] arreglo = { 15, 12, 8, 18, 5, 2, 7 };

Console.WriteLine("Arreglo original: ");

MostrarArray(arreglo);

InsertionSort(arreglo);

Console.WriteLine("Arreglo ordenado: ");

MostrarArray(arreglo);

static void MostrarArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

static void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int valor = arr[i];
        int j = i - 1;
        while (j != -1 && arr[j] > valor)
        {
            arr[j + 1 ] = arr[j];
            j--;
            arr[j + 1] = valor;
        }

        arr[j + 1] = valor;
    }
}