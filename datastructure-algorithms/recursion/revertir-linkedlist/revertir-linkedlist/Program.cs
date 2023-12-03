int[] numeros = { 1, 2, 3, 4, 5};

LinkedList<int> lista = new LinkedList<int>(numeros);

ImprimirLista(lista);

LinkedList<int> listaRevertida = RevertirLista(lista);

Console.WriteLine("Lista revertida:");

ImprimirLista(listaRevertida);

static LinkedList<int> RevertirLista(LinkedList<int> lista)
{
    if (lista.First == null || lista.First.Next == null)
    {
        return lista;
    }
    else
    {
        int node = lista.Last.Value;

        lista.RemoveLast();

        LinkedList<int> listTemp = new LinkedList<int>(RevertirLista(lista));

        listTemp.AddFirst(node);

        return listTemp;
    }
}

static void ImprimirLista(LinkedList<int> lista)
{
    foreach (int i in lista)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}