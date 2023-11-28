Console.Write("Dime el dividendo: ");

int dividendo = int.Parse(Console.ReadLine());

Console.Write("Dime el divisor: ");

int divisor = int.Parse(Console.ReadLine());

ObtenerResiduo(dividendo, divisor);

static void ObtenerResiduo(int x, int y)
{
    if(y == 0)
    {
        Console.WriteLine("El dividendo no puede ser 0");
    }else if(x < y)
    {
        Console.WriteLine("El dividendo no puede ser menor que el divisor");
    }
    else
    {
        Console.WriteLine($"El resto de {x} entre {y} es: " + x % y);
    }
    
}