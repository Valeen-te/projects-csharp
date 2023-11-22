string[] palabras = new string[]
{
    "CsharpCurso",
    "Google",
    "Yahoo",
    "CNN" 
};

foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);

    string resultado = "";

    foreach (char s in palabra)
    {
        if (!resultado.Contains(s))
        {
            resultado += s;
        }
    }

    Console.WriteLine(resultado);
    Console.WriteLine();
}