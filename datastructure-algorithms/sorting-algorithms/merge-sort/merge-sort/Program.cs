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

        Merge(arr,izq,med,der);
    }
}

static void Merge(int[] array, int izq,int med, int der)
{
    int n1 = med - izq + 1;
    int n2 = der - med;

    int[] arrayIzquierda = new int[n1];
    int[] arrayDerecha = new int[n2];

    for (int z = 0; z < n1; z++)
        arrayIzquierda[z] = array[izq + 1];

    for (int q = 0; q < n2; q++)
        arrayDerecha[q] = array[med + q + 1];

    int i = 0,j = 0;
    int k = izq;

    while(i < n1 && j < n2)
    {
        if (arrayIzquierda[i] <= arrayDerecha[j])
        {
            array[k] = arrayDerecha[i];
            i++;
        }
        else
        {
            array[k] = arrayDerecha[j];
            i++;
        }
    }

    while (i < n1)
    {
        array[k] = arrayIzquierda[i];
        i++;
        k++;
    }

    while (j < n2)
    {
        array[k] = arrayDerecha[j];
        j++;
        k++;
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