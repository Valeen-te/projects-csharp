Empleado empl1 = new("Juan", 01);
Empleado empl2 = new("Dani", 02);
Empleado empl3 = new("Maria", 03);
Empleado empl4 = new("Jose", 04);
Empleado empl5 = new("pedro", 05);
Empleado empl6 = new("sergio", 06);

ArbolBusquedaBinaria arb = new();

arb.Ingresar(empl3);
arb.Ingresar(empl2);
arb.Ingresar(empl4);
arb.Ingresar(empl6);
arb.Ingresar(empl1);
arb.Ingresar(empl5);

NodoArbol nodo = arb.ObternerRaiz();

arb.inorder(nodo);


public class Empleado
{
    public int id { get; set; }
    public string nombre { get; set; }

    public Empleado(string nombre,int id)
    {
        this.nombre = nombre;
        this.id = id;
    }
}

public class NodoArbol
{
    public Empleado empleado { get; set; }
    public NodoArbol izquierda { get; set; }
    public NodoArbol derecha { get; set; }

    public NodoArbol(Empleado empleado)
    {
        this.empleado = empleado;
        izquierda = null;
        derecha = null;
    }
}

public class ArbolBusquedaBinaria
{

    private NodoArbol raiz;

    public ArbolBusquedaBinaria()
    {
        raiz = null;
    }

    public NodoArbol ObternerRaiz()
    {
        return raiz;
    }

    public void Ingresar(Empleado empleado)
    {

        NodoArbol nuevoNodo = new(empleado);

        if (raiz == null)
        {
            raiz = nuevoNodo;
        }
        else
        {
            ingresarRecursivo(nuevoNodo, raiz);
        }
    }

    public void ingresarRecursivo(NodoArbol nuevoNodo,NodoArbol raiz)
    {

        int id = nuevoNodo.empleado.id;

        if(id < raiz.empleado.id)
        {
            if(raiz.izquierda == null)
            {
                raiz.izquierda = nuevoNodo;
            }
            else
            {
                ingresarRecursivo(nuevoNodo, raiz.izquierda);
            }
        }
        else
        {
            if (raiz.derecha == null)
            {
                raiz.derecha = nuevoNodo;
            }
            else
            {
                ingresarRecursivo(nuevoNodo, raiz.derecha);
            }
        }
    }

    public void inorder(NodoArbol nodoActual)
    {
        if(nodoActual != null)
        {
            inorder(nodoActual.izquierda);
            Console.WriteLine(nodoActual.empleado.nombre);
            inorder(nodoActual.derecha);
        }
    }

    public void BreadthFirsSearch()
    {
        if(raiz == null)
        {
            Console.WriteLine("El arbol está vacío.");
            return;
        }

        Queue<NodoArbol> queue = new();

        queue.Enqueue(raiz);

        while (queue.Count > 0)
        {
            n
        }
    }

}