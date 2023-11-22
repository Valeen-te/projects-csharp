Console.WriteLine("Ingrese una palabra:");
string cadena = Console.ReadLine().ToLower();

string cadenaInversa = "";

for(int i = cadena.Length - 1;  i >= 0; i--)
{
    cadenaInversa += cadena[i];
}

Console.WriteLine();

if(cadena == cadenaInversa)
{
    Console.WriteLine($"{cadena} es un palíndromo");
} else
    Console.WriteLine($"{cadena} no es un palíndromo");
