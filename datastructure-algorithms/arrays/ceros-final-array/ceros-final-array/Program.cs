int[] array = { 9, 7, 5, 0, 3, 4, 0, 6, 1, 2, 0, 8 };

Console.WriteLine("Array inicial:");
ImprimirArray(array);

MoverCeros(array);

Console.WriteLine("Array final:");
ImprimirArray(array);


static void ImprimirArray(int[] array)
{
    foreach ( int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void MoverCeros(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        if (array[i] == 0)
        {
            for (int j = i; j < array.Length - 1; j++)
            {
                int temp = array[j + 1];

                array[j + 1] = array[j];

                array[j] = temp;
            }
        }
    }
}