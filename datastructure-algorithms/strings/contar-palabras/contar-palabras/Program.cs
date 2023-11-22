Console.WriteLine("Ingrese una frase:");
string frase = Console.ReadLine();

string[] palabras = frase.Split(" ");

Console.WriteLine($"\nLa frase tiene {palabras.Length} palabras");