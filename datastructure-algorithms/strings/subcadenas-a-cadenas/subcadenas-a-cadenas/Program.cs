string cadena = "srtuvwxyz";

for (int i = 1; i <= cadena.Length; i++)
{
    
    for (int j = 0; j < cadena.Length - i; j++)
    {
        string subcadena = cadena.Substring(j,i);
        
        Console.WriteLine(subcadena);
    }
}