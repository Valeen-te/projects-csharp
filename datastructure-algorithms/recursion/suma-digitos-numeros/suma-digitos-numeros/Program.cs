
int num, result;

Console.Write("Ingresa un número: ");

num = int.Parse(Console.ReadLine());

result = SumaDigitos(num);

Console.WriteLine($"La suma de los digitos de {num} es {result}");

static int SumaDigitos(int num)
{
    if (num < 10)
    {
        return num;
    }
    else
    {
        return num % 10 + SumaDigitos(num/10);
    }
}