using System;
using System.Diagnostics;
using ClassLibrary1.Services;
using ClassLibrary1;
using ClassLibrary1.Data;

class PruebaSistemaNomina
{
    public static void Main()
    {

        EmpleadoServices services = new EmpleadoServices();

        EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado("Juan", "Perez", "101", 800m);
        EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras("Ana", "Gomez", "102", 20m, 40);
        EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision("Luis", "Martinez", "103", 0.06m, 10000m);
        EmpleadoAsalariadoPorComision empleadoAsalariadoPorComision = new EmpleadoAsalariadoPorComision("Maria", "Lopez", "104", 0.04m, 300m, 5000m);

        EmpleadoRepository repository = new EmpleadoRepository();
        repository.AgregarEmpleado(empleadoAsalariado);
        repository.AgregarEmpleado(empleadoPorHoras);
        repository.AgregarEmpleado(empleadoPorComision);
        repository.AgregarEmpleado(empleadoAsalariadoPorComision);
        Stopwatch stopwatch = new Stopwatch();

        
        for (int i = 0; i < repository.ObtenerEmpleados().Count; i++)
        {
            Console.WriteLine(repository.ObtenerEmpleados()[i]);
            Console.WriteLine($"Pago: {repository.ObtenerEmpleados()[i].Ingresos():C}\n");
        }
        
        
        stopwatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            repository.AgregarEmpleado(new EmpleadoAsalariado($"Nombre: Test{i}", $"Apellido Ta{i}", $"{i:D3}-{i:D2}-{i:D4}", 1000.00m + i));

        }
        stopwatch.Stop();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Tiempo que tardo en agregar a 10000 Empleados: {stopwatch.Elapsed.TotalSeconds} ms");
        Console.ReadLine();
        stopwatch.Reset();



        stopwatch.Start();
        services.ListarEmpleados();
        stopwatch.Stop();
        Console.WriteLine($"Tiempo que tardo en mostrar la lista de 10000: {stopwatch.Elapsed.TotalSeconds} ms");
    }
}