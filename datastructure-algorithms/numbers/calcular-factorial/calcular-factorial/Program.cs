Console.Write("ingrese el número: ");
int num = int.Parse(Console.ReadLine());

int factorial = num;

for (int i = 1; i < num; i++)
{
    factorial = factorial * i;
}

Console.WriteLine($"El factorial de {num} es: {factorial}");