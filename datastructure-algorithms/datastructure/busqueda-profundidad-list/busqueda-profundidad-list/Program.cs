empleado bill = new("Bill");
empleado steve = new("Steve");
empleado mark = new("Mark");
empleado robert = new("Robert");
empleado carl = new("Carl");
empleado luis = new("Luis");
empleado ruben = new("ruben");

bill.JefeDe(steve);
bill.JefeDe(mark);

steve.JefeDe(robert);
steve.JefeDe(carl);

mark.JefeDe(luis);
mark.JefeDe(ruben);

DepthFirstAlgorithm b = new(bill);

empleado raiz = b.ObtenerRaiz();

Console.WriteLine("Empleados: ");

b.mostrar(raiz);

Console.WriteLine("\nBuscar: ");

empleado e;

e = b.Buscar(raiz,"Mark");

if (e != null)
    Console.WriteLine(e.name);
else
    Console.WriteLine("Empleado no encontrado");

e = b.Buscar(raiz, "Carl");

if (e != null)
    Console.WriteLine(e.name);
else
    Console.WriteLine("Empleado no encontrado");

e = b.Buscar(raiz, "Juan");

if (e != null)
    Console.WriteLine(e.name);
else
    Console.WriteLine("Empleado no encontrado");

public class empleado
{
    public empleado(string name)
    {
        this.name = name;
    }

    public string name { get; set; }

    public List<empleado> empleadosLista = new();

    public List<empleado> empleados { get { return empleadosLista; } }

    public void JefeDe(empleado e)
    {
        empleadosLista.Add(e);
    }

    public string NombreEmpleado()
    {
        return name;
    }

}

public class DepthFirstAlgorithm
{
    public empleado raiz;

    public DepthFirstAlgorithm(empleado raiz)
    {
        this.raiz = raiz;
    }

    public empleado ObtenerRaiz()
    {
        return raiz;
    }

    public empleado Buscar(empleado raiz, string nombre)
    {
        if(raiz.name == nombre)
        {
            return raiz;
        }

        empleado empleadoEncontrado = null;
        for(int i = 0; i < raiz.empleados.Count; i++)
        {
            empleadoEncontrado = Buscar(raiz.empleados[i], nombre);
            if (empleadoEncontrado != null)
                break;
        }

        return empleadoEncontrado;
    }

    public void mostrar(empleado raiz)
    {
        Console.WriteLine(raiz.name);
        for(int i = 0; i < raiz.empleadosLista.Count; i++) 
        {
            mostrar(raiz.empleadosLista[i]);
        }
    }
}