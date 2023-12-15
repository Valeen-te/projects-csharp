Stack<int> pila = new();

pila.Push(53);
pila.Push(10);
pila.Push(30);
pila.Push(23);
pila.Push(7);

Console.WriteLine("Pila Original: ");

MostrarStack(pila);

pila = InvertirStack(pila);

Console.WriteLine("Pila Inversa: ");

MostrarStack(pila); 

static void MostrarStack(Stack<int> p)
{
    foreach (int i in p)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static Stack<int> InvertirStack(Stack<int> p)
{
    Stack<int> temp = new();

    while (p.Count > 0)
    {
        temp.Push(p.Pop());
    }

    return temp;
}