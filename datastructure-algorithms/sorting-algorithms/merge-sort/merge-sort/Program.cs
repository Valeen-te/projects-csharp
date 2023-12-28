int[] array = { 4, 6, 9, 1, 7, 5, 3, 0, 2, 8 };

Console.WriteLine("Antes:");

MostrarArray(array);

MergeSort(array, 0, array.Length - 1);

Console.WriteLine("Despues:");

MostrarArray(array);


static void MergeSort(int[] arr, int izq, int der)
{
    if (izq < der)
    {
        int med = (izq + der) / 2;

        MergeSort(arr, izq, med);

        MergeSort(arr, med + 1, der);
    }
}

static void Merge()
{

}

static void MostrarArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}