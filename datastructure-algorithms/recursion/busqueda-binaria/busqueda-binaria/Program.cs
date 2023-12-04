int? buscar = null, posicion = null;

Console.WriteLine("ingresa la longitud de la cadena:");

int[] listaNumeros = new int[int.Parse(Console.ReadLine())];

for (int i = 0; i < listaNumeros.Length; i++)
{
    listaNumeros[i]= i + 1;
}

Console.WriteLine("Ingrese el número a buscar:");

buscar = int.Parse(Console.ReadLine());

if (buscar < 1 || buscar > listaNumeros.Length ) 
{
    Console.WriteLine("Valor no valido");
}
else
{
   posicion = Buscarnumero(listaNumeros,0,listaNumeros.Length - 1,buscar);
}

Console.WriteLine("la posición del en la array es: " + posicion);

static int Buscarnumero(int[] lista, int min, int max, int? num)
{

    int med = (min + max) / 2;

    if (lista[med] == num)
    {
        return med;
    }
    else
    {
        if (lista[med] < num)
        {
            min = med;
            return Buscarnumero (lista, min, max, num);
        }
        else
        {
            max = med;
            return Buscarnumero(lista, min, max, num);
        }
    }
}