
using System.Collections;

//Programa que verifica si una palabra es un palíndromo

CsharpStack Lista = new CsharpStack(); //Crear una instancia de CsharpStack

string palabra = "rapar"; //Palabra a verificar

string? inverso = null; //Cadena para almacenar palabra invertida

foreach (char c in palabra) //Agregar caracteres de la palabra a la pila
{
    Lista.Push(c);
}

while (Lista.count() > 0) //Remueve los caracteres de la pila y lo agrega a inverso
{
    inverso += Lista.Pop();
}

if (inverso == palabra)//Comprueba si la palabra es palíndromo 
{
    Console.WriteLine($"\"{palabra}\" es un palíndromo");
}
else
{
    Console.WriteLine($"{palabra} no es un palímdromo");
}


//Clase que crea pilas 

public class CsharpStack
{
    private List<object>? list; // Lista interna para almacenar los elementos de la pila

    public CsharpStack()
    {
        list = new List<object>(); // Inicializar la lista en el constructor
    }

    public int count() //Devolver la longitud de la pila
    {
        return list.Count;
    }

    public void Push(object item) //Agregar un objeto a la pila
    {
        list.Add(item);
    }

    public object Pop() //Devuelve el ultimo elemento de la pila y lo elimina de la misma
    {
        object e = list.Last();
        list.RemoveAt(list.Count - 1);
        return e;
    }

    public void Clear() //Elimina la pila
    {
        list.Clear();
    }

    public object next() //Mustra el sigiente elemento a ser removido (el ultimo de la lista)
    {
        return list.Last();
    }
}