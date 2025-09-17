using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
class ProgramaConsole
{
    static void Main(string[] args)
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
        int opcion = Convert.ToInt32(Console.ReadLine());
        bool salir = false;

        do
        {
            switch (opcion)
            {

            }

        } while (salir);
    }
}
