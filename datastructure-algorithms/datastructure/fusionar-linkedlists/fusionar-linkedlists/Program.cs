
LinkedList<int> listaA = new();

listaA.AddLast(2);
listaA.AddLast(4);
listaA.AddLast(6);

Console.WriteLine("LinkedList A:");
MostrarLinkedList(listaA);

LinkedList<int> listaB = new();

listaB.AddLast(1);
listaB.AddLast(7);
listaB.AddLast(5);
listaB.AddLast(3);

Console.WriteLine("LinkedList B:");
MostrarLinkedList(listaB);


foreach (int i in listaB)
{
    listaA.AddLast(i);
}

Console.WriteLine("LinkedList A & B fusionadas:");
MostrarLinkedList(listaA);

Ordenar(listaA);

Console.WriteLine("LinkedList A & B ordenadas:");
MostrarLinkedList(listaA);


static void Ordenar(LinkedList<int> lista)
{
    if(lista == null || lista.Count < 1)
    {
        return;
    }

    LinkedListNode<int> pivoteNode = lista.Last;

    LinkedList<int> menores = new();
    LinkedList<int> mayores = new();

    LinkedListNode<int> current = lista.First;

    while(current != pivoteNode)
    {
        LinkedListNode<int> temp = current;
        if(current.Value <= pivoteNode.Value)
        {
            menores.AddLast(temp.Value);
        } else
        {
            mayores.AddLast(temp.Value);
        }
        temp = temp.Next;
        lista.Remove(current);
        current = temp;
    }

    Ordenar(menores);
    Ordenar(mayores);

    lista.Clear();

    foreach(int i in menores)
    {
        lista.AddLast(i);
    }

    lista.AddLast(pivoteNode);

    foreach(int i in mayores)
    {
        lista.AddLast(i);
    }
}
static void MostrarLinkedList(LinkedList<int> lista)
{
    foreach(int i in lista)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

