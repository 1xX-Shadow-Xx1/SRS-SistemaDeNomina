using ClassLibrary1.Data;
using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class EmpleadoServices : IEmpleadoServices
    {
        EmpleadoRepository repository = new EmpleadoRepository();

        public void AddEmpleado(Empleado empleado)
        {
            repository.AgregarEmpleado(empleado);
        }
        public void RemoveEmpleado(string NSS)
        {
            repository.EliminarEmpleado(NSS);
        }
        public void ActualizarEmpleado(Empleado empleado, string nss)
        {
            repository.ActualizarEmpleado(empleado,nss);
        }
        public void ListarEmpleados()
        {
            Console.Clear();
            Console.WriteLine("---- Lista de Empleados ----");
            var empleados = EmpleadoRepository.empleados;

            for(int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine("Nombre: {0} {1} || NSS: {2} || Salario: {3}$", empleados[i].PrimerNombre, empleados[i].ApellidoPaterno, empleados[i].NumeroSeguroSocial, empleados[i].Ingresos());
            }
            Console.WriteLine("--------------------------- ");
            Console.ReadLine();
            Console.Clear();
        }
        public Empleado BuscarEmpleado(string NSS)
        {
            return repository.ObtenerEmpleadoPorNSS(NSS);
        }

        public void EliminarTodosEmpleadosConsole()
        {
            Console.WriteLine("Estas Seguro de querer eliminar todos los empleados de la lista?(Si/No)");
            string opcion = Console.ReadLine();
            if (opcion == "Si")
                repository.EliminarTodosEmpleados();
            else
                Console.WriteLine("Operacion cancelada");
            Console.ReadLine();
            Console.Clear();
        }
        public void LimpiarListaEmpleadosForm()
        {
            repository.EliminarTodosEmpleados();
        }

        public void GenerarReporte()
        {
            Console.Clear();
            Console.WriteLine("---- Reporte de Empleados ----");
            var empleados = EmpleadoRepository.empleados;
            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine("Nombre: {0} {1} || NSS: {2} || Tipo de Empleado: {3} || Pago: {4}$", empleados[i].PrimerNombre, empleados[i].ApellidoPaterno, empleados[i].NumeroSeguroSocial, empleados[i].GetType().Name, empleados[i].Ingresos());
            }
            Console.WriteLine("--------------------------- ");
            decimal totalPagar = empleados.Sum(e => e.Ingresos());
            Console.WriteLine($"Total a Pagar: {totalPagar}$");
            Console.ReadLine();
            Console.Clear();
        }

        public void GenerarReporteEnArchivo()
        {
            StringBuilder reporte = new StringBuilder();
            reporte.AppendLine("---- Reporte de Empleados ----");

            var empleados = EmpleadoRepository.empleados;

            foreach (var empleado in empleados)
            {
                reporte.AppendLine(
                    $"Nombre: {empleado.PrimerNombre} {empleado.ApellidoPaterno} || NSS: {empleado.NumeroSeguroSocial} || Tipo de Empleado: {empleado.GetType().Name} || Salario: {empleado.Ingresos():C}"
                );
            }

            reporte.AppendLine("--------------------------- ");
            decimal totalPagar = empleados.Sum(e => e.Ingresos());
            reporte.AppendLine($"Total a Pagar: {totalPagar:C}");

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Directory.GetParent(basePath).Parent.Parent.Parent.FullName;
            string carpetaReportes = Path.Combine(projectPath, "Reportes");
            if(!Directory.Exists(carpetaReportes))
                Directory.CreateDirectory(carpetaReportes);
            rutaArchivo = Path.Combine(carpetaReportes, "Reporte de Empleados.Txt");

            try
            {
                File.WriteAllText(rutaArchivo, reporte.ToString());
                Console.WriteLine($"Reporte generado exitosamente en: {rutaArchivo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar el reporte: {ex.Message}");
            }
        }

        public void ListaDePagos()
        {
            Console.Clear();
            Console.WriteLine("---- Lista de Pagos ----");
            var empleados = EmpleadoRepository.empleados;
            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine("Nombre: {0} {1} || NSS: {2} || Tipo de Empleado: {3} || Pago: {4}$", empleados[i].PrimerNombre, empleados[i].ApellidoPaterno, empleados[i].NumeroSeguroSocial, empleados[i].GetType().Name, empleados[i].Ingresos());
            }
            Console.WriteLine("--------------------------- ");
            decimal totalPagar = empleados.Sum(e => e.Ingresos());
            Console.WriteLine($"Total a Pagar: {totalPagar}$");
            Console.ReadLine();
            Console.Clear();
        }

        public void EliminarEmpleados()
        {
            repository.EliminarTodosEmpleados();
            Console.Clear();
            Console.WriteLine("Todos los empleados han sido eliminados.");
            Console.ReadLine();
            Console.Clear();
        }
        public void BuscarEmpleadoPorNSS(string nss)
        {
            Empleado empleadoEncontrado = BuscarEmpleado(nss);
            if (empleadoEncontrado != null)
            {
                Console.WriteLine(empleadoEncontrado.ToString());
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public string rutaArchivo {  get; set; }

    }

}
