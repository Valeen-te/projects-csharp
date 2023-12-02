int num, exponente;
double? resultado;

Console.WriteLine("Calculadora de potencias\n");

Console.WriteLine("Ingrese un número:");

num = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su exponente:");

exponente = int.Parse(Console.ReadLine());

resultado = CalcularPotencia(num, exponente);

if(resultado != null)
{
    Console.WriteLine($"\nLa potencia de {num}^{exponente} es: {resultado}");
}

static double? CalcularPotencia(int num, int exponente)
{
    switch (exponente)
    {
        case < 0:
            Console.WriteLine("\nSolo se admiten exponentes positivos");
            return null;
        case 1:
            return num;
        case 0:
            return 1;
        default:
            return num * CalcularPotencia(num, exponente - 1);
    }
}