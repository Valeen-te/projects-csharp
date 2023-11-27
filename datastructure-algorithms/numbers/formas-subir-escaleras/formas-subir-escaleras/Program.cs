
using System.Timers;

Console.Write("Dime el número de escaleras: ");

int escaleras = int.Parse(Console.ReadLine());

int a = 0;

int b = 1;

int c = 0;

for(int i = 1; i <= escaleras; i++)
{
    c = a + b;

    if (i != 1)
    {
        b = a;
    }

    a = c;
}

Console.WriteLine($"\nEl número de formas de subir las escaleras es: {c}");