ArbolBusquedaBinaria arb = new();

arb.Ingresar(new("Maria", 4));
arb.Ingresar(new("Dani", 2));
arb.Ingresar(new("Jose", 6));
arb.Ingresar(new("sergio", 1));
arb.Ingresar(new("Juan", 3));
arb.Ingresar(new("pedro", 5));
arb.Ingresar(new("Luis", 7));

NodoArbol nodo = arb.ObternerRaiz();

Console.WriteLine("Empleados:");

arb.Inorder(nodo);

Console.WriteLine("Busqueda:");

arb.BreadthFirsSearch(2);
arb.BreadthFirsSearch(3);
arb.BreadthFirsSearch(5);
arb.BreadthFirsSearch(9);

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
            IngresarRecursivo(nuevoNodo, raiz);
        }
    }

    public void IngresarRecursivo(NodoArbol nuevoNodo,NodoArbol raiz)
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
                IngresarRecursivo(nuevoNodo, raiz.izquierda);
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
                IngresarRecursivo(nuevoNodo, raiz.derecha);
            }
        }
    }

    public void Inorder(NodoArbol nodoActual)
    {
        if(nodoActual != null)
        {
            Inorder(nodoActual.izquierda);
            Console.WriteLine($"ID: {nodoActual.empleado.id}, Nombre: {nodoActual.empleado.nombre}");
            Inorder(nodoActual.derecha);
        }
    }

    public void BreadthFirsSearch(int id)
    {
        if(raiz == null)
        {
            Console.WriteLine("El arbol está vacío.");
            return;
        }

        Queue<NodoArbol> cola = new();

        cola.Enqueue(raiz);

        while (cola.Count > 0)
        {
            NodoArbol actual = cola.Dequeue();

            if(id == actual.empleado.id)
            {
                Console.WriteLine($"ID: {actual.empleado.id}, Nombre: {actual.empleado.nombre}");
                return;
            }

            if (actual.izquierda != null)
            {
                cola.Enqueue(actual.izquierda);
            }

            if(actual.derecha != null)
            {
                cola.Enqueue(actual.derecha);
            }
        }

        Console.WriteLine("Empleado no encontrado");
    }

}