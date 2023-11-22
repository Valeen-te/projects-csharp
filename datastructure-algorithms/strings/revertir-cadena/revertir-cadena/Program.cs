Console.WriteLine("Dame una palabra");
string? cadena = Console.ReadLine();

string resultado = "";

for(int i = cadena.Length - 1; i >= 0;i--)
{
    resultado += cadena[i];
}

Console.WriteLine($"\nPalabra invertida: {resultado}");