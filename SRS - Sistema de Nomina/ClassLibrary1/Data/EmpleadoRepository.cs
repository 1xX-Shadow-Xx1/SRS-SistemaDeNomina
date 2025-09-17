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
            List<Empleado> empleados = ObtenerEmpleados();
            if(empleados != null)
            {
                return empleados.FirstOrDefault(e => e.NumeroSeguroSocial == nss);
            }
            return null;

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
                $"--------------------------\n" +
                $"{empleados.FirstOrDefault(ObtenerEmpleadoPorNSS(nss)).ToString()}");
        }
        public void ActualizarEmpleado(Empleado empleado)
        {
            // Lógica para actualizar un empleado en la base de datos o colección
            var empleadoExistente = ObtenerEmpleadoPorNSS(empleado.NumeroSeguroSocial);
            Empleado empleadoAntiguo = empleadoExistente;
            if (empleadoExistente != null)
            {
                empleados.Remove(empleadoExistente);
                empleados.Add(empleado);
            }
            Console.WriteLine($"Empleado {empleado.PrimerNombre} {empleado.ApellidoPaterno} actualizado.");
            Console.WriteLine(
                "---Detalles del cambio---\n" +
                "Antigua informacion" +
                empleadoAntiguo.ToString());

            Console.WriteLine(
                "\nNueva Informacion" +
                $"\n{empleado.ToString()}");
        }
        public void EliminarTodosEmpleados()
        {
            empleados.Clear();
            Console.WriteLine("Todos los empleados han sido eliminados.");
        }
    }
}
