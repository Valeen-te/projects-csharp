int[] array = { 4, 1, 7, 3, 6, 8, 2, 9, 5 };

MostrarArray(array);

MoverNumeros(array, 0, array.Length - 1);

MostrarArray(array);

static void MoverNumeros(int[] arr, int min, int max)
{
    int pivote = arr[max];

    int i = min;

    for (int j = 0; j < arr.Length - 1; j++)
    {
        if (arr[j] > pivote)
        {
            i++;
            int temp = arr[j];
            arr[j] = arr[max];
            arr[max] = temp;
        }
    }
}

static void MostrarArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}