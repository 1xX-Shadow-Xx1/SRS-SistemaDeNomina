using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces
{
    public interface IEmpleadoServices
    {
        void AddEmpleado(Empleado empleado);
        void RemoveEmpleado(string NSS);
        void ActualizarEmpleado(Empleado empleado);
        void ListarEmpleados();
        Empleado BuscarEmpleado(string NSS);
    }
}
