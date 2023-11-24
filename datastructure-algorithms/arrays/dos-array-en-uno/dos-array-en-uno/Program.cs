
int[] array1 = { 5, 6, 7, 8, 9 };
int[] array2 = { 0, 1, 2, 3, 4, 0, 0, 0, 0, 0 };

ImprimirArray(array1);
ImprimirArray(array2);

int numMax = array1.Length;
int posicion = 0;

for (int i = numMax; i < array2.Length; i++)
{
    array2[i] = array1[posicion];
    posicion++;
}

ImprimirArray(array2);

static void ImprimirArray(int[] array)
{
    foreach (int i in array) Console.Write(i);

    Console.WriteLine("\n");
}

