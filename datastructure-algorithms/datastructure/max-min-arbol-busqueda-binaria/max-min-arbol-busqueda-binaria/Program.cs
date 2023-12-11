ArbolBinario arb1 = new ArbolBinario();

arb1.Insertar(10);
arb1.Insertar(5);
arb1.Insertar(13);
arb1.Insertar(3);
arb1.Insertar(15);
arb1.Insertar(7);
arb1.Insertar(9);
arb1.Insertar(1);
arb1.Insertar(4);
arb1.Insertar(12);

Console.WriteLine("Mínimo: ");

arb1.Minimo();

Console.WriteLine("Máximo: ");

arb1.Maximo();

public class Nodo
{
    public Nodo(int valor)
    {
        this.valor = valor;
        izquierda = null;
        derecha = null;
    }

    public int valor { get; set; }
    public Nodo? izquierda { get; set; }
    public Nodo? derecha { get; set; }
}

public class ArbolBinario()
{
    private Nodo? raiz { get; set; }

    public Nodo MostrarRaiz()
    {
        return raiz;
    }

    public void Insertar(int valor)
    {
        if (raiz == null)
        {
            raiz = new Nodo(valor);
        }
        else
        {
            InsertarRecursivo(valor, raiz);
        }
    }

    public void InsertarRecursivo(int valor, Nodo nodoActual)
    {
        if (valor < nodoActual.valor)
        {
            if (nodoActual.izquierda == null)
            {
                nodoActual.izquierda = new Nodo(valor);
            }
            else
            {
                nodoActual = nodoActual.izquierda;
                InsertarRecursivo(valor, nodoActual);
            }
        }
        else
        {
            if (nodoActual.derecha == null)
            {
                nodoActual.derecha = new Nodo(valor);
            }
            else
            {
                nodoActual = nodoActual.derecha;
                InsertarRecursivo(valor, nodoActual);
            }
        }
    }
    public void Minimo()
    {
        Nodo nodo = raiz;

        while (nodo.izquierda != null)
        {
            nodo = nodo.izquierda;
        }

        Console.WriteLine(nodo.valor);
    }

    public void Maximo()
    {
        Nodo nodo = raiz;

        while (nodo.derecha != null)
        {
            nodo = nodo.derecha;
        }

        Console.WriteLine(nodo.valor);

    }
}