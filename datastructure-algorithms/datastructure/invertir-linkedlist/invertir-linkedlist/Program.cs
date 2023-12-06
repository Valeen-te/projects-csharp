LinkedList<int> list = new LinkedList<int>();

list.AddLast(5);
list.AddLast(10);
list.AddLast(15);
list.AddLast(20);
list.AddLast(25);

Console.WriteLine("Linked List inicial:");

MostrarLinkedList(list);

InvertirLinkedList(list);

Console.WriteLine("Linked List inverso:");

MostrarLinkedList(list);

static void InvertirLinkedList(LinkedList<int> lista)
{

    LinkedListNode<int> first = lista.First;
    LinkedListNode<int> second = lista.First.Next;

    int repeticiones = lista.Count - 1;

    for (int i = repeticiones;  i >= 0; i--)
    {
        int j = i;

        while (j != 0)
        {

            LinkedListNode<int> temp = second;

            CambiarNumeros(first, second);

            second = second.Next;

            first = temp;

            j--;
        }

        first = lista.First;
        second = lista.First.Next;

    }

}

static void CambiarNumeros(LinkedListNode<int> node1, LinkedListNode<int> node2)
{
    int temp = node2.Value;

    node2.Value = node1.Value;

    node1.Value = temp;

}

static void MostrarLinkedList(LinkedList<int> list)
{
    foreach (int i in list)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
