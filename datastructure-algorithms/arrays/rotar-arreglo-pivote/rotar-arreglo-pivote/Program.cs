int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int pivote = 3;

Console.WriteLine("Arreglo inicial:");

ImprimirMatriz(array);

int[] arrayRotada = RotarMatriz(array, pivote);

Console.WriteLine("Arreglo final:");

ImprimirMatriz(arrayRotada);

static void ImprimirMatriz(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static int[] RotarMatriz(int[] array, int pivote)
{
    if (pivote < 0 || array == null)
    {
        throw new Exception("Argumento invalido");
    }

    int longitud = array.Length;

    int[] arrayRotada = new int[longitud];

    for (int i = 0; i < longitud; i++)
    {
        int nuevaPosicion = (i + pivote) % longitud;

        arrayRotada[nuevaPosicion] = array[i];
    }

    return arrayRotada;
}