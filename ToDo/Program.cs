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

//Generador aleatorio de tareas pendientes

for (int i = 0; i < 8; i++)
{
    tareasPendientes.Add(new Tarea{Descripcion = descripcionesRandom[Random.Shared.Next(descripcionesRandom.Length)], 
                                    Duracion = Random.Shared.Next(10,101),
                                    TareaID = i,
                                    Realizada = false});
}
