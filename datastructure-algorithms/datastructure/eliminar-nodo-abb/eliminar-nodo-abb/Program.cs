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
arb1.Insertar(6);

Nodo raiz = arb1.MostrarRaiz();

arb1.mostrar(raiz);

Console.WriteLine();

arb1.Eliminar(10);

arb1.mostrar(raiz);

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

    public void Eliminar(int valor)
    {
        raiz = EliminarRecursivo(valor, raiz);
    }

    private Nodo EliminarRecursivo(int valor, Nodo nodoActual)
    {
        if(nodoActual == null)
        {
            return nodoActual;
        }

        if(valor < nodoActual.valor)
        {
            nodoActual.izquierda = EliminarRecursivo(valor, nodoActual.izquierda);
        }
        else if(valor > nodoActual.valor)
        {
            nodoActual.derecha = EliminarRecursivo(valor, nodoActual.derecha);
        }
        else
        {
            if (nodoActual.derecha == null && nodoActual.izquierda == null)
            {
                return null;
            }
            else if (nodoActual.derecha == null)
            {
                return nodoActual.izquierda;
            }
            else if(nodoActual.izquierda == null)
            {
                return nodoActual.derecha;
            }
            else
            {
                nodoActual = Reemplazar(nodoActual);

                
            }
        }

        return nodoActual;
    }

    private Nodo Reemplazar(Nodo nodoActual)
    {
        Nodo reemplazo = nodoActual.derecha;

        if(reemplazo.izquierda != null)
        {
            while(reemplazo.izquierda != null)
            {
                reemplazo = reemplazo.izquierda;
            }
        }

        nodoActual.valor = reemplazo.valor;

        EliminarRecursivo(nodoActual.valor, nodoActual.derecha);

        return nodoActual;
    }

    public void mostrar(Nodo raiz)
    {
        if(raiz != null)
        {
            mostrar(raiz.izquierda);
            Console.Write(raiz.valor + " ");
            mostrar(raiz.derecha);
        }
    }


}