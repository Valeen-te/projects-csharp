LinkedList<int> lista = new();

lista.AddLast(1);
lista.AddLast(2);
lista.AddLast(3);
lista.AddLast(4);
lista.AddLast(5);

Console.WriteLine("Lista: ");

foreach (int i in lista)
{
    Console.Write(i + " ");
}

Console.WriteLine();

MostraUltimo(lista);

static void MostraUltimo(LinkedList<int> lista)
{
    if (lista.Count < 1 || lista.First == null)
    {
        return;
    }

    LinkedListNode<int> node = lista.First;

    int length = lista.Count - 1;

    for (int i = 0; i < length; i++)
    {
        node = node.Next;
    }

    Console.WriteLine("Último elemento: " + node.Value);
}