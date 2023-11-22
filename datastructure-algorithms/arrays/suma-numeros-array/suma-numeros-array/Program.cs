Console.WriteLine("Dame un número");

int obtenerNumero = int.Parse(Console.ReadLine());

int[] arrayNumeros = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.Write("Array: ");

foreach (int i in arrayNumeros)
{
    Console.Write(i + " ");
}

Console.WriteLine(sumaArray(arrayNumeros, obtenerNumero));

static string sumaArray(int[] array, int num)
{
    if (num > -1)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (j != i)
                {
                    if (array[j] + array[i] == num)
                    {
                        return $"\nLos números {array[j]} y {array[i]} del array suman: {num}";
                    }
                }
            }
        }
        return $"\nno hay suma en el array que de {num}";
    }
    else
    {
        return "\nel número no puede ser negativo";
    }
}




