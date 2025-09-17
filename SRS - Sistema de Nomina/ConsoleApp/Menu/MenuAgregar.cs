using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Services;

namespace SRS___Sistema_de_Nomina.Menu
{
    public class MenuAgregar
    {
        EmpleadoServices services = new EmpleadoServices();
        public void MenuAgregarInicio()
        {      
            bool volver = false;

            do
            {
                Console.Clear();
                Console.WriteLine(
                    "---Tipos de Empleados---\n" +
                    "\n1. Empleado Asalariado" +
                    "\n2. Empleado por Hora" +
                    "\n3. Empleado por comision" +
                    "\n4. Empleado Asalariado por comision" +
                    "\n5. Volver al Menu Principal\n");
                Console.Write("\nSeleccione una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AgregarEmpleadoAsalariado();
                        break;
                    case 2:
                        AgregarEmpleadoPorHora();
                        break;
                    case 3:
                        AgregarEmpleadoPorComision();
                        break;
                    case 4:
                        AgregarEmpleadoAsalariadoPorComision();
                        break;
                    case 5:
                        volver = true;
                        break;
                }
            } while (volver == false);
            Console.Clear();
        }

        private void AgregarEmpleadoAsalariado()
        {
            Console.WriteLine("-- Agregando un Empleado Asalariado --\n");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("NSS: ");
            string nss = Console.ReadLine();
            Console.WriteLine("Salario: ");
            decimal salario = Decimal.Parse(Console.ReadLine());
            EmpleadoAsalariado empleado = new EmpleadoAsalariado(nombre, apellido, nss, salario);
            services.AddEmpleado(empleado);
            Console.WriteLine("Agregado Correctamente");
            Console.ReadLine();
        }
        private void AgregarEmpleadoPorHora()
        {
            Console.WriteLine("-- Agregando un Empleado de sueldo por hora --\n");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("NSS: ");
            string nss = Console.ReadLine();
            Console.WriteLine("Sueldo: ");
            decimal sueldo = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Horas Trabajadas: ");
            int horas = Int32.Parse(Console.ReadLine());
            EmpleadoPorHoras empleado = new EmpleadoPorHoras(nombre,apellido,nss,sueldo,horas);
            services.AddEmpleado(empleado);
            Console.WriteLine("Agregado Correctamente");
            Console.ReadLine();
        }
        private void AgregarEmpleadoPorComision()
        {
            Console.WriteLine("-- Agregando un Empleado por Comision --\n");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("NSS: ");
            string nss = Console.ReadLine();
            Console.WriteLine("Tarifa de la comision(0% a 100%): ");
            int tarifa = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las ventas brutas hechas por el Empleado: ");
            decimal ventasBrutas = decimal.Parse(Console.ReadLine());

            decimal Tarifa = tarifa / 100M;

            Console.WriteLine(Tarifa);
            EmpleadoPorComision empleado = new EmpleadoPorComision(nombre, apellido, nss, Tarifa, ventasBrutas);
            services.AddEmpleado(empleado);
            Console.WriteLine("Agregado Correctamente");
            Console.ReadLine();
        }
        private void AgregarEmpleadoAsalariadoPorComision()
        {
            Console.WriteLine("-- Agregando un Empleado por Comision --\n");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("NSS: ");
            string nss = Console.ReadLine();
            Console.WriteLine("Salario: ");
            decimal salario = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Venta bruta: ");
            decimal venta = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Tarifa de la comision(0% a 100%): ");
            int tarifa = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Agregado Correctamente");
            Console.ReadLine();

            decimal Tarifa = tarifa / 100M;
            EmpleadoAsalariadoPorComision empleado = new EmpleadoAsalariadoPorComision(nombre,apellido, nss, Tarifa, venta, salario);
            services.AddEmpleado(empleado);
        }
    }
}
