using System;

int[] arreglo = { 2, 5, 1, 7, 3, 9, 4, 6, 8};

Console.WriteLine("Arreglo desordenado: ");

Print(arreglo);

HeapSort(arreglo);

Console.WriteLine("Arreglo ordenado: ");

Print(arreglo);

void HeapSort(int[] arr)
{
    int n = arr.Length - 1;

    

    for (int  j = arr.Length - 1; j >= 0; j--)
    {
        for (int i = arr.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, i, n);
        }

        mover(arr);

        n--;
    }
}

void Heapify(int[]arr,int raiz,int ultimo)
{
    int mayor = raiz;
    int izquierda = raiz * 2 + 1;
    int derecha = raiz * 2 + 2;

    if (izquierda < ultimo && arr[izquierda] < arr[mayor])
    {
        mayor = izquierda;
    }
    if (derecha < ultimo && arr[derecha] < arr[mayor])
    {
        mayor = derecha;
    }

    if (mayor != raiz)
    {
        int swap = arr[raiz];
        arr[raiz] = arr[mayor];
        arr[mayor] = swap;
        Heapify(arr, mayor, ultimo);
    }
}

static void Print(int[] arr)
{
    foreach(int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void mover(int[] arr)
{
    int temp = arr[0];

    for(int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i + 1];
    }

    arr[arr.Length - 1] = temp;
}