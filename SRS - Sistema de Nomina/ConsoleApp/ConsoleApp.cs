using ClassLibrary1;
using ClassLibrary1.Services;
using ConsoleApp.Menu;
using SRS___Sistema_de_Nomina.Menu;

public class ProgramaConsole
{
    static EmpleadoServices services = new EmpleadoServices();
    public static void Main(string[] args)
    {
        MenuAgregar menuAgregar = new MenuAgregar();
        MenuEditar menuEditar = new MenuEditar();

        bool salir = true;
        int opcion;
        do
        {
            Console.WriteLine("-----Sistema de Nomina-----");

            Console.WriteLine(
                "\n1. Agregar Empleados" +
                "\n2. Lista de Empleados" +
                "\n3. Eliminar un Empleado" +
                "\n4. Editar un Empleado" +
                "\n5. Buscar a un Empleado por NSS" +
                "\n6. Generar Reporte" +
                "\n7. Generar Reporte en archivo.Txt" +
                "\n8. Lista de Pagos" +
                "\n9. Eliminar Empleados" +
                "\n10. Salir del programa");

            Console.Write("\nSeleccione una opcion: ");
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
            }catch (FormatException)
            {
                Console.WriteLine("Por favor ingrese un numero valido");
                opcion = 0;
            }


            switch (opcion)
            {
                case 1:
                    menuAgregar.MenuAgregarInicio(); 
                    break;
                case 2:
                    services.ListarEmpleados();
                    break;
                case 3:
                    Console.Clear();
                    eliminarEmpleado();
                    break;
                case 4:
                    Console.Clear();
                    menuEditar.MostrarMenuEditar();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Ingrese el NSS del empleado a buscar: ");
                    string nssBuscar = Console.ReadLine();
                    services.BuscarEmpleadoPorNSS(nssBuscar);
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    services.GenerarReporte();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    services.GenerarReporteEnArchivo();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    services.ListaDePagos();
                    Console.Clear();
                    break;
                case 9:
                    Console.Clear();
                    services.EliminarEmpleados();
                    Console.Clear();
                    break;
                case 10:
                    salir = false;
                    Console.Clear();
                    Console.WriteLine("Cerrando Programa...");
                    break;
                default :
                    Console.Clear();
                    Console.WriteLine("Opcion no valida, intente de nuevo");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

        } while (salir);
        Console.WriteLine("Programa cerrado correctamente");

    }
    private static void eliminarEmpleado()
    {
        bool op = true;
        do
        {
            Console.Write("Ingrese el NSS del empleado a eliminar(Para terminar dejalo vacio y presiona Enter): ");
            string nssEliminar = Console.ReadLine();
            if (nssEliminar == "")
            {
                op = false;
                Console.Clear();
                break;
            }
            services.RemoveEmpleado(nssEliminar);
            Console.ReadLine();
            Console.Clear();
        } while (op);
    }

}