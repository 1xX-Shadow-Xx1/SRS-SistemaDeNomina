using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        public static List<Empleado> empleados = new List<Empleado>();
        public List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }

        public Empleado ObtenerEmpleadoPorNSS(string nss)
        {
            Empleado emp = empleados.FirstOrDefault(e => e.NumeroSeguroSocial == nss);
            if (empleados != null)
            {
                return emp;
            }
            else return null;

        }
        public void AgregarEmpleado(Empleado empleado)
        {
            // Lógica para agregar un empleado a la base de datos o colección
            empleados.Add(empleado);
            Console.WriteLine($"Empleado {empleado.PrimerNombre} {empleado.ApellidoPaterno} agregado.");
        }
        public void EliminarEmpleado(string nss)
        {
            // Lógica para eliminar un empleado de la base de datos o colección
            empleados.Remove(ObtenerEmpleadoPorNSS(nss));
            Console.WriteLine($"Empleado con NSS {nss} eliminado.\n" +
                $"--------------------------\n");
        }
        public void ActualizarEmpleado(Empleado empleado, string nss)
        {
            // Lógica para actualizar un empleado en la base de datos o colección

            Empleado emp = ObtenerEmpleadoPorNSS(nss);

            if (emp != null)
            {
                empleados.Remove(emp);
                empleados.Add(empleado);

                Console.WriteLine($"Empleado {empleado.PrimerNombre} {empleado.ApellidoPaterno} actualizado.");

                Console.WriteLine(
                    "--------Detallles de la edicion--------\n" +
                    "----Vieja informacion---" +
                    $"\n{emp.ToString()}\n");

                Console.WriteLine(
                    "\n---Nueva Informacion---" +
                    $"\n{empleado.ToString()}");
            }
            else Console.WriteLine("Usuario no encontrado");
            
        }
        public void EliminarTodosEmpleados()
        {
            empleados.Clear();
            Console.WriteLine("Todos los empleados han sido eliminados.");
        }
    }
}
