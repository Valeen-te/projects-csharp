Console.Write("Ingrese un número: ");

int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Es divisible entre 2");
}
else
{
    Console.WriteLine("No es divisible entre 2");
}