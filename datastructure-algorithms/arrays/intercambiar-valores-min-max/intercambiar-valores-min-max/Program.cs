using System;

int[] array = { 5,9,6,8,3,2,4,1,7 };

Console.WriteLine("Array inicial:");

ImprimirArray(array);

int indiceMinimo = 0;

int indiceMaximo = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < array[indiceMinimo])
        indiceMinimo = i;

    if (array[i] > array[indiceMaximo])
        indiceMaximo = i;
}

int temp = array[indiceMinimo];

array[indiceMinimo] = array[indiceMaximo];

array[indiceMaximo] = temp;

Console.WriteLine("Array final:");


ImprimirArray(array);



static void ImprimirArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}