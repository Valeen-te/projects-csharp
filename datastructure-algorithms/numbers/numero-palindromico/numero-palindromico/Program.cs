Console.Write("Ingrese un número: ");

string numero = Console.ReadLine();

char[] numeroChar = numero.ToCharArray();

string? resultado = null;

for (int i = numeroChar.Length -1 ; i > -1; i--)
{
    int num;

    int.TryParse(numeroChar[i].ToString(),out num);

    resultado += numeroChar[i];
}

if  (resultado == numero)
{
    Console.WriteLine($"El número {numero} es palindrómico");
}
else
{
    Console.WriteLine($"El número {numero} no es palindrómico");
}