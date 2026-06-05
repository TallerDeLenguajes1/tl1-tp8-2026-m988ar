// See https://aka.ms/new-console-template for more information\
using Tareas;

string[] descripcionesRandom =
{
    "Terminar informe mensual",
    "Responder correos pendientes",
    "Actualizar documentación del proyecto",
    "Revisar solicitudes de clientes",
    "Preparar presentación para la reunión",
    "Corregir errores reportados",
    "Organizar archivos del sistema",
    "Realizar copia de seguridad"
};

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

//Generador aleatorio de tareas pendientes

for (int i = 0; i < 8; i++)
{
    tareasPendientes.Add(new Tarea
    {
        Descripcion = descripcionesRandom[Random.Shared.Next(descripcionesRandom.Length)],
        Duracion = Random.Shared.Next(10, 101),
        TareaID = i,
        Realizada = Random.Shared.Next(0,2)
    });
}


int menu = 999;
do
{
    System.Console.WriteLine("====MENU====");
    System.Console.WriteLine("\n0)Salir\n1)Mover tareas pendientes a realizadas\n2)Buscar tarea por decricpcion\n3)Mostrar Listas\n");
    if (!int.TryParse(Console.ReadLine(), out menu))
    {
        System.Console.WriteLine("Elegi bien");
    }
    switch (menu)
    {
        case 1:
            moverTareas(ref tareasPendientes, ref tareasRealizadas);
            System.Console.WriteLine("Tareas Movidas Exitosamente");
            System.Console.WriteLine("Pendientes");
            mostrarTareas(tareasPendientes);
            System.Console.WriteLine("Realizadas");
            mostrarTareas(tareasRealizadas);
            break;
        case 2:
            System.Console.WriteLine("Ingrese la descripcion de la tarea que desea buscar");
            string descripcion = Console.ReadLine();
            if(!buscarTareas(tareasPendientes, descripcion) &&
                !buscarTareas(tareasRealizadas, descripcion))
            {
                System.Console.WriteLine("No se ecnontro niguna tarea con esa descripcion");
            }
            break;
        case 3:
            System.Console.WriteLine("Pendientes");
            mostrarTareas(tareasPendientes);
            System.Console.WriteLine("Realizadas");
            mostrarTareas(tareasRealizadas);
            break;
    }
} while (menu != 0);

static void moverTareas(ref List<Tarea> pendientes, ref List<Tarea> realizadas)
{
    foreach (Tarea tarea in pendientes.ToList())
    {
        pendientes.Add(tarea);
        realizadas.Remove(tarea);
    }
}

static bool buscarTareas(List<Tarea> lista, string descripcionB)
{
    foreach (Tarea tarea in lista)
    {
        if (tarea.Descripcion.Contains(descripcionB, StringComparison.OrdinalIgnoreCase))
        {
            System.Console.WriteLine(tarea.Descripcion);
            return true;
        }
    }
    return false;
}

static void mostrarTareas(List<Tarea> lista)
{
    foreach (Tarea tarea in lista)
    {
        System.Console.WriteLine($"Descripcion: {tarea.Descripcion}");
        System.Console.WriteLine($"Id: {tarea.TareaID}");
        System.Console.WriteLine($"Duracion: {tarea.Duracion}");
        if (tarea.Realizada == 1)
        {
            System.Console.WriteLine($"Estado: Realizada");
        }
        else
        {
            System.Console.WriteLine("Estado: Pendiente");
        }

    }
}