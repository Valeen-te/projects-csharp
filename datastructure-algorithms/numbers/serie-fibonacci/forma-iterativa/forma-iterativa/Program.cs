Console.Write("Ingrese la longitud de la serie fibonacci: ");

int longitud = int.Parse(Console.ReadLine());

Console.WriteLine("\nLa serie fibonnacci es:");

int a = 0, b = 0, r = 0;

for (int i = 0; i < longitud; i++)
{
    if(i == 1)
    {
        b = 1;
    }

    r = a + b;

    b = a;

    a = r;

    Console.Write(r + " ");
}