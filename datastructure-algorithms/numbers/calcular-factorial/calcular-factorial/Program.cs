Console.Write("ingrese el número: ");
int num = int.Parse(Console.ReadLine());

int factorial = num;

int resultado = CalcularWhile(num,factorial);

Console.WriteLine($"El factorial de {num} es: {resultado}");

//-----------------------------------------------------------

//Bucle for
static int CalcularFor(int num, int factorial)
{
    for (int i = 1; i < num; i++)
    {
        factorial *= i;
    }
    return factorial;
}

//Recusividad

static int CalcularRecursividad( int num)
{
    switch (num)
    {
        case < 3:
            return num;
        default:
            Console.WriteLine(num);
            return num * CalcularRecursividad(num - 1);
    }
}

//Bucle While

static int CalcularWhile(int num, int factorial)
{
    num--;

    while(num > 1) 
    {
        factorial *= num;
        num--;
    }

    return factorial;
}