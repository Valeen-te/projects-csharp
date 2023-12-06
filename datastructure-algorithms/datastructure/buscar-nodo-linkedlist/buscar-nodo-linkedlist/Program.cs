//Crear de Linkedlist
LinkedList<string> listaEnlazada = new();

//Añadir objetos al LinkedList
listaEnlazada.AddLast("A");
listaEnlazada.AddLast("B");
listaEnlazada.AddLast("C");

//Buscar nodo con el método find
LinkedListNode<string> nodo = listaEnlazada.Find("A");

//Agregar un nuevo objeto despues del nodo
listaEnlazada.AddAfter(nodo, "String");

//Imprimir LinkedList
foreach (string str in listaEnlazada)
{
    Console.WriteLine(str);
}