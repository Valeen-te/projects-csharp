
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

Nodo node =  arb1.MostrarRaiz();

Console.WriteLine("Inorder: ");

arb1.inorder(node);

Console.WriteLine("\nPreorder: ");

arb1.Preorder(node);

Console.WriteLine("\nPostorder: ");

arb1.Postorder(node);

public class Nodo
{
    public Nodo(int valor)
    {
        this.valor = valor;
        izquierda = null;
        derecha = null;
    }

    public int valor {get;set;}
    public Nodo? izquierda { get;set;}
    public Nodo? derecha { get;set;}
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


    public void inorder(Nodo node)
    {

        if (node != null)
        {
            inorder(node.izquierda);
            Console.Write(node.valor + " ");
            inorder(node.derecha);
        }

    }

    public void Preorder(Nodo node)
    {

        if (node != null)
        {
            Console.Write(node.valor + " ");
            Preorder(node.izquierda);
            Preorder(node.derecha);
        }

    }

    public void Postorder(Nodo node)
    {

        if (node != null)
        {
            Postorder(node.izquierda);
            Postorder(node.derecha);
            Console.Write(node.valor + " ");
        }

    }

}