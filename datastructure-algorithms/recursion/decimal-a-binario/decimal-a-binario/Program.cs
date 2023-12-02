int num;
string resultado;

Console.Write("Ingrese un número: ");

num = int.Parse(Console.ReadLine());

resultado = ObterneBinario(num);

Console.WriteLine($"El binario equivalente al número es: {resultado}");

static string ObterneBinario(int num)
{
    if (num == 1)
    {
        return num.ToString();
    }
    else
    {
        return ObterneBinario(num / 2) + (num % 2);
    }
}