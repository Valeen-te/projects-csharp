Console.Write("Ingresa un número: ");
string nroArmstrong = Console.ReadLine();

char[] numeros = nroArmstrong.ToCharArray();
double resultado = 0;

for (int i = 0; i < numeros.Length; i++)
{
    int temp;
    int.TryParse(numeros[i].ToString(), out temp);
    resultado += Math.Pow(temp, numeros.Length);
}

if (resultado == int.Parse(nroArmstrong))
{
    Console.WriteLine($"El número {nroArmstrong} es un número de Armstrong.");
}
else
{
    Console.WriteLine($"El número {nroArmstrong} no es un número de Armstrong.");
}