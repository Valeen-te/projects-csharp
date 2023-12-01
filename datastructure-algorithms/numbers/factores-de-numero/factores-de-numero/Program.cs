Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("\nFactores: ");
for (int i = 1; i <= numero; i++)
{
    if(numero % i == 0)
    {
        Console.WriteLine(i);
    }
}