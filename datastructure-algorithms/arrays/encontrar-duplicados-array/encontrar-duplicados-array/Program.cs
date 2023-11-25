int[] array = {4,2,5,2,6,4,7,8,9,3,7 };

Console.WriteLine("Array:");

ImprimirArray(array);

EncontrarDuplicados(array);


static void ImprimirArray(int[] array)
{
    foreach( int i in array )
        Console.Write( i + " " );
    Console.WriteLine();
}


static void EncontrarDuplicados (int[] array )
{
    for( int i = 0; i < array.Length; i++)
    {
        for( int j = i + 1; j < array.Length; j++)
        {
            if(array[j] == array[i])
            {
                Console.WriteLine($"El valor {array[j]} está duplicado");
            }
        }
    }
}