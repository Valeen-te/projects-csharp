//Crear LinkedList y añadir 5 objetos
LinkedList<int> list = new LinkedList<int>();

list.AddLast(5);
list.AddLast(10);
list.AddLast(15);
list.AddLast(20);
list.AddLast(25);

//Mostrar Linkedlist original llamando al función MostrarLinkedList
Console.WriteLine("Linked List inicial:");

MostrarLinkedList(list);

//Se invierte la LinkedList llamando a la función InvertirLinkedList
InvertirLinkedList(list);

//Mostrar Linkedlist inverso
Console.WriteLine("Linked List inverso:");

MostrarLinkedList(list);

static void InvertirLinkedList(LinkedList<int> lista)
{
    //Se guardan el primer y segundo nodo de la LinkedList
    LinkedListNode<int> first = lista.First;
    LinkedListNode<int> second = lista.First.Next;

    /*Se guarda la longitud de la linkedlist menos uno, esto permitira 
    mover los valores de los nodos a su posición final*/
    int repeticiones = lista.Count - 1;

    /*Declaramos un buble for con el indice i igual a las repeticiones,
    este va indicar la posicion a la que se movera el nodo*/
    for (int i = repeticiones;  i >= 0; i--)
    {
        //Declaramos un bucle for que movera el nodo a su nueva posción 
        for(int j = i; j > 0; j--)
        {
            LinkedListNode<int> temp = second;

            /*Llamamos al metodo CambiarNodos, este intercambiara los valores
            de first y second*/
            CambiarNodos(first, second);

            second = second.Next;

            first = temp;

        }

        //Reiniciamos los valores de first y second
        first = lista.First;
        second = lista.First.Next;

    }

}

//La función CambiarNodos intercambia los valores de los nodos ingresados
static void CambiarNodos(LinkedListNode<int> node1, LinkedListNode<int> node2)
{
    int temp = node2.Value;

    node2.Value = node1.Value;

    node1.Value = temp;

}

//La función MostrarLinkedList imprime en consola el LinkedList ingresado
static void MostrarLinkedList(LinkedList<int> list)
{
    foreach (int i in list)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
