char[] letras = new char[] { 'a','c','f','h','b','e','d','g','j','i' };

ImprimirArray(letras);

Array.Sort(letras);
Array.Reverse(letras);

Console.WriteLine();

ImprimirArray(letras);

static void ImprimirArray(char[] letras)
{
    foreach (char c in letras)
    {
        Console.Write($"{c} ");
    }
}