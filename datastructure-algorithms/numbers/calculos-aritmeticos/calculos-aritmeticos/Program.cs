// Seleccionar operación

Console.WriteLine("Opciones");
Console.WriteLine("1) sumar\n2) restar\n3) multiplicar\n4) dividir");

Console.Write("\nSelecciona una opción: ");

int opcion;

int.TryParse(Console.ReadLine(), out opcion);

// Verificar si es una opcion valida

if (opcion > 0 && opcion < 5)
{
    //Ingresar valores a calcular

    Console.Write("\nDame el primer número: ");

    int a = int.Parse(Console.ReadLine());

    Console.Write("Dame el segundo número: ");

    int b = int.Parse(Console.ReadLine());

    //Mostrar operación

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"\n {a} + {b} = " + (a + b));
            break;
        case 2:
            Console.WriteLine($"\n {a} - {b} = " + (a - b));
            break;
        case 3:
            Console.WriteLine($"\n {a} * {b} = " + (a * b));
            break;
        case 4:
            Console.WriteLine($"\n {a} / {b} = " + (a / b));
            break;
    }

}
else
{
    Console.WriteLine("No exite esa opcion");
}

