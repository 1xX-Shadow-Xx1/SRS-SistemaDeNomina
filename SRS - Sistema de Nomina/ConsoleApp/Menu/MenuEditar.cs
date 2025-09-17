using ClassLibrary1;
using ClassLibrary1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Menu
{
    public class MenuEditar
    {
        EmpleadoServices services = new EmpleadoServices();
        public MenuEditar() { }
        public void MostrarMenuEditar()
        {
            Console.Clear();
            Console.WriteLine("---- Editar Empleado ----");
            Console.WriteLine("Ingresa su NSS");
            Console.WriteLine("-------------------------------");
            Console.Write("NSS:");
            string nss = Console.ReadLine();
            EditarEmpleado(nss);
        }

        public void EditarEmpleado(string nss)
        {
            string nnsAntiguo = nss;
            Empleado empleado = services.BuscarEmpleado(nss);
            if(empleado == null)
            {
                Console.WriteLine("No se encontro ningun empleado con ese NSS, regresando al menu principal");
                Console.ReadLine();
                return;
            }
            string nombre = empleado.PrimerNombre;
            string apellido = empleado.ApellidoPaterno;

            Console.Clear();
            Console.WriteLine(
                "---- Editando a Empleado -----" +
                "\nNombre: {0} {1} || NSS: {2} || Tipo de Empleado: {3}" +
                "\n------------------------------", empleado.PrimerNombre, empleado.ApellidoPaterno, empleado.NumeroSeguroSocial, empleado.TipoEmpleado);
            Console.WriteLine("\nNombre: ");
            string nombreIngresado = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellidoIngresado = Console.ReadLine();
            Console.WriteLine("NSS: ");
            string nssIngresado = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("--- Tipo de Empleado ---");
            Console.WriteLine("Seccione el tipo de empleado al que desea cambiarlo o modificar(Presione Enter si no quiere modificarlo)\n");
            Console.WriteLine("1. Empleado por Horas");
            Console.WriteLine("2. Empleado Asalariado");
            Console.WriteLine("3. Empleado por Comision");
            Console.WriteLine("4. Empleado Base mas Comision");
            Console.Write("Seleccione una opcion: ");
            int tipoEmpleado;
            try
            {
                tipoEmpleado = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                tipoEmpleado = 10;
            }



            if (tipoEmpleado == 10)
            {
                Console.WriteLine("No se selecciono ningun tipo de empleado, regresando al menu principal");

                empleado.PrimerNombre = nombreIngresado != "" ? nombreIngresado : nombre;
                empleado.ApellidoPaterno = apellidoIngresado != "" ? apellidoIngresado : apellido;
                empleado.NumeroSeguroSocial = nssIngresado != "" ? nssIngresado : nss;

                services.ActualizarEmpleado(empleado, nnsAntiguo);
                return;

            }

            switch (tipoEmpleado)
            {
                case 1:
                    Console.WriteLine("Ingrese las horas trabajadas: ");
                    int horasTrabajadas = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo sueldo por hora: ");
                    decimal tarifaPorHora = decimal.Parse(Console.ReadLine());
                    EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras(
                        nombreIngresado != "" ? nombreIngresado : nombre,
                        apellidoIngresado != "" ? apellidoIngresado : apellido,
                        nssIngresado != "" ? nssIngresado : nss,
                        tarifaPorHora, 
                        horasTrabajadas);
                    services.ActualizarEmpleado(empleadoPorHoras, nnsAntiguo);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nuevo salario semanal: ");
                    decimal salarioSemanal = decimal.Parse(Console.ReadLine());
                    EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado(
                        nombreIngresado != "" ? nombreIngresado : nombre,
                        apellidoIngresado != "" ? apellidoIngresado : apellido,
                        nssIngresado != "" ? nssIngresado : nss,
                        salarioSemanal);
                    services.ActualizarEmpleado(empleadoAsalariado, nnsAntiguo);
                    break;
                case 3:
                    Console.WriteLine("Ingrese las ventas brutas: ");
                    decimal ventasBrutas = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nuevo % de comision(0% al 100%): ");
                    int tarifaComision = Int32.Parse(Console.ReadLine());
                    decimal tarifa = tarifaComision / 100M;

                    EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision(
                        nombreIngresado != "" ? nombreIngresado : nombre,
                        apellidoIngresado != "" ? apellidoIngresado : apellido,
                        nssIngresado != "" ? nssIngresado : nss,
                        tarifa,
                        ventasBrutas);
                    services.ActualizarEmpleado(empleadoPorComision, nnsAntiguo);
                    break;
                case 4:
                    Console.WriteLine("Ingrese las ventas brutas: ");
                    decimal ventasBrutas2 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nuevo % de comision(0% al 100%): ");
                    int tarifaComision2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo salario base: ");
                    decimal salarioBase = decimal.Parse(Console.ReadLine());
                    decimal tarifa2 = tarifaComision2 / 100M;

                    EmpleadoAsalariadoPorComision empleadoBaseMasComision = new EmpleadoAsalariadoPorComision(
                        nombreIngresado != "" ? nombreIngresado : nombre,
                        apellidoIngresado != "" ? apellidoIngresado : apellido,
                        nssIngresado != "" ? nssIngresado : nss,
                        tarifa2,
                        ventasBrutas2,
                        salarioBase);
                    services.ActualizarEmpleado(empleadoBaseMasComision, nnsAntiguo);
                    break;

            }
            
        }

        
    }
}
