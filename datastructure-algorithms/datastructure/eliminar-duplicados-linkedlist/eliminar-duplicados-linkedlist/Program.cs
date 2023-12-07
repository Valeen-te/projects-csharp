LinkedList<int> lista = new();

lista.AddLast(1);
lista.AddLast(2);
lista.AddLast(1);
lista.AddLast(3);
lista.AddLast(2);
lista.AddLast(4);
lista.AddLast(4);

Console.WriteLine("Lista original: ");

MostrarLista(lista);

EliminarDuplicados(lista);

Console.WriteLine("Eliminando duplicados: ");

MostrarLista(lista);

static void EliminarDuplicados(LinkedList<int> lista)
{
    LinkedListNode<int> nodeRef = lista.First;

    int length = lista.Count;

    while (nodeRef != null)
    {
        LinkedListNode<int> temp = lista.First;

        for (int i = 0; i < length; i++)
        {
            if(temp != nodeRef)
            {
                if(temp.Value == nodeRef.Value)
                {
                    temp = temp.Previous;

                    lista.Remove(temp.Next);

                    length--;
                }
            }

            temp = temp.Next;
        }

        nodeRef = nodeRef.Next;
    }
}


static void MostrarLista(LinkedList<int> lista)
{
    foreach (int i in lista)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}