
Console.WriteLine("Ingrese la primera palabra: ");
string palabra1 = Console.ReadLine();
Console.WriteLine("Ingrese la segunda palabra: ");
string palabra2 = Console.ReadLine();

char[] caracteres1 = palabra1.ToLower().ToCharArray();
char[] caracteres2 = palabra1.ToLower().ToCharArray();

Array.Sort(caracteres1);
Array.Sort(caracteres2);

string cadena1 = caracteres1.ToString();
string cadena2 = caracteres2.ToString();

Console.WriteLine();

if(cadena1 == cadena2)
{
    Console.WriteLine($"{palabra1} y {palabra2} son anagramas");
}
else
{
    Console.WriteLine($"{palabra1} y {palabra2} no son anagramas");
}