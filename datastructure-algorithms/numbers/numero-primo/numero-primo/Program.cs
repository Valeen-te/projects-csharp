Console.Write("Dame un número: ");

int numero = int.Parse(Console.ReadLine());

int contador = 0;

for (int i = numero - 1; i > 0; i--)
{
    if (numero % i == 0)
    {
        contador++;
    }
}

if(contador > 1)
{
    Console.WriteLine($"\nEl número {numero} no es primo");
}
else
{
    Console.WriteLine($"\nEl número {numero} es primo");
}