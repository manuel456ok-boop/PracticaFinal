using System;
using System.Collections.Generic;
using System.Linq;

enum EstadoSolicitud
{
    Pendiente,
    EnProceso,
    Completada,
    Cancelada
}

class Solicitud
{
    public int Id { get; set; }
    public string NombreCliente { get; set; }
    public string Descripcion { get; set; }
    public EstadoSolicitud Estado { get; set; }

    public Solicitud(int id, string nombreCliente, string descripcion, EstadoSolicitud estado)
    {
        Id = id;
        NombreCliente = nombreCliente;
        Descripcion = descripcion;
        Estado = estado;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Cliente: {NombreCliente}");
        Console.WriteLine($"Descripción: {Descripcion}");
        Console.WriteLine($"Estado: {Estado}");
        Console.WriteLine(new string('=', 50));
    }
}

class GestorSolicitudes
{
    private List<Solicitud> solicitudes = new List<Solicitud>();
    private int proximoId = 1;

    public void RegistrarSolicitud()
    {
        Console.WriteLine("\n--- Registrar Nueva Solicitud ---");

        Console.Write("Nombre del cliente: ");
        string nombreCliente = Console.ReadLine();

        Console.Write("Descripción de la solicitud: ");
        string descripcion = Console.ReadLine();

        Solicitud nuevaSolicitud = new Solicitud(proximoId, nombreCliente, descripcion, EstadoSolicitud.Pendiente);
        solicitudes.Add(nuevaSolicitud);
        proximoId++;

        Console.WriteLine($"\n✓ Solicitud registrada exitosamente con ID: {nuevaSolicitud.Id}");
    }

    public void MostrarTodasLasSolicitudes()
    {
        if (solicitudes.Count == 0)
        {
            Console.WriteLine("\nNo hay solicitudes registradas.");
            return;
        }

        Console.WriteLine("\n--- Todas las Solicitudes ---");
        foreach (var solicitud in solicitudes)
        {
            solicitud.MostrarInformacion();
        }
    }

    public Solicitud BuscarSolicitudPorId(int id)
    {
        return solicitudes.FirstOrDefault(s => s.Id == id);
    }

    public void CambiarEstadoSolicitud()
    {
        Console.WriteLine("\n--- Cambiar Estado de Solicitud ---");

        Console.Write("Ingrese el ID de la solicitud: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        Solicitud solicitud = BuscarSolicitudPorId(id);

        if (solicitud == null)
        {
            Console.WriteLine($"No se encontró solicitud con ID: {id}");
            return;
        }

        Console.WriteLine($"\nEstado actual: {solicitud.Estado}");
        Console.WriteLine("\nSeleccione el nuevo estado:");
        Console.WriteLine("0 - Pendiente");
        Console.WriteLine("1 - En Proceso");
        Console.WriteLine("2 - Completada");
        Console.WriteLine("3 - Cancelada");

        Console.Write("Opción: ");
        if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 0 || opcion > 3)
        {
            Console.WriteLine("Opción inválida.");
            return;
        }

        solicitud.Estado = (EstadoSolicitud)opcion;
        Console.WriteLine($"✓ Estado actualizado a: {solicitud.Estado}");
    }

    public void BuscarYMostrarSolicitud()
    {
        Console.WriteLine("\n--- Buscar Solicitud por ID ---");

        Console.Write("Ingrese el ID de la solicitud: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        Solicitud solicitud = BuscarSolicitudPorId(id);

        if (solicitud == null)
        {
            Console.WriteLine($"No se encontró solicitud con ID: {id}");
            return;
        }

        solicitud.MostrarInformacion();
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        GestorSolicitudes gestor = new GestorSolicitudes();
        bool continuar = true;

        Console.WriteLine("╔════════════════════════════════════════════════════╗");
        Console.WriteLine("║   Sistema de Gestión de Solicitudes de Servicio   ║");
        Console.WriteLine("╚════════════════════════════════════════════════════╝");

        while (continuar)
        {
            Console.WriteLine("\n--- Menú Principal ---");
            Console.WriteLine("1 - Registrar nueva solicitud");
            Console.WriteLine("2 - Mostrar todas las solicitudes");
            Console.WriteLine("3 - Buscar solicitud por ID");
            Console.WriteLine("4 - Cambiar estado de una solicitud");
            Console.WriteLine("5 - Salir");

            Console.Write("\nSeleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    gestor.RegistrarSolicitud();
                    break;
                case "2":
                    gestor.MostrarTodasLasSolicitudes();
                    break;
                case "3":
                    gestor.BuscarYMostrarSolicitud();
                    break;
                case "4":
                    gestor.CambiarEstadoSolicitud();
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine("\n¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }
}
