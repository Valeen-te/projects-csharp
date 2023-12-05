int[] array = { 4, 1, 7, 3, 6, 8, 2, 9, 5 };

Console.WriteLine("Array original: ");

MostrarArray(array);

Quicksort(array, 0, array.Length - 1);

Console.WriteLine("Array ordenado: ");

MostrarArray(array);

static void Quicksort(int[] array,int min, int max)
{
    if (min < max)
    {
        int particionIndice = Particion(array, min, max);
        Quicksort(array, min, particionIndice - 1);
        Quicksort(array, particionIndice + 1, max);
    }
}

static int Particion(int[] array, int min, int max)
{
    int pivote = array[max];

    int i = min - 1;

    for (int j = min; j <= max; j++)
    {
        if (array[j] < pivote)
        {
            i++;
            Cambio(array, i, j);
        }
    }

    Cambio(array, i + 1, max);

    return i + 1;
}

static void Cambio(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

static void MostrarArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}